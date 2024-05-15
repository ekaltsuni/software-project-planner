using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;
using static SoftwarePlanner.SQLConstants;
using static SoftwarePlanner.Translations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoftwarePlanner
{
    public partial class ProjectViewForm : ParentForm
    {
        private int projectId;
        private bool isAssigned = false;
        private bool canOffer = true;
        private int clientId = -1;

        public ProjectViewForm(string projectName)
        {
            InitializeComponent();
            fillProjectFields(projectName);
            populateOfferGrid();
            showAssignedDev();
            if (!User.role.Equals("Developer"))
            {
                offerButton.Visible = false;
            }
            if (Role.isAdmin)
            {
                deleteButton.Visible = true;
            }
            if (isAssigned)
            {
                offerButton.Visible = false;
                recommendationButton.Visible = false;
            }
            populateCommentGrid();
        }

        private void fillProjectFields(string projectName)
        {
            int typeId = -1;
            int durationId = -1;
            int categoryId = -1;
            int subCategoryId = -1;
            int paymentId = -1;
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_PROJECT_FULL, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@title", projectName);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        projectId = reader.GetInt32(reader.GetOrdinal("project_id"));
                        clientId = reader.GetInt32(reader.GetOrdinal("client_id"));
                        projectInfoGrid.Rows.Add("Τίτλος", reader.GetString(reader.GetOrdinal("title")));
                        projectInfoGrid.Rows.Add("Περιγραφή", reader.GetString(reader.GetOrdinal("description")));
                        projectInfoGrid.Rows.Add("Δημιουργός", reader.GetString(reader.GetOrdinal("username")));
                        projectInfoGrid.Rows.Add("Ολοκληρωμένο", reader.GetInt32(reader.GetOrdinal("finished")) == 0 ? "Όχι" : "Ναι");
                        if (reader[5].GetType() != typeof(DBNull))
                        {
                            projectInfoGrid.Rows.Add("Μέγιστη Τιμή", reader.GetInt64(reader.GetOrdinal("max_price")) + "€");
                        }
                        if (reader[7].GetType() != typeof(DBNull))
                        {
                            projectInfoGrid.Rows.Add("Διάρκεια Προσφορών", reader.GetInt64(reader.GetOrdinal("bidding_duration")));
                        }
                        typeId = reader.GetInt32(reader.GetOrdinal("type"));
                        if (reader[6].GetType() != typeof(DBNull))
                        {
                            durationId = reader.GetInt32(reader.GetOrdinal("duration"));
                        }
                        categoryId = reader.GetInt32(reader.GetOrdinal("category"));
                        subCategoryId = reader.GetInt32(reader.GetOrdinal("subcategory"));
                        paymentId = reader.GetInt32(reader.GetOrdinal("payment"));
                    }
                }
            }
            fillForeignFields(typeId, durationId, categoryId, subCategoryId, paymentId);
        }

        private void fillForeignFields(int typeId, int durationId, int categoryId, int subCategoryId, int paymentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand typeCommand = new SQLiteCommand(RETURN_PROJECT_TYPE_NAME, connection))
            using (SQLiteCommand durationCommand = new SQLiteCommand(RETURN_PROJECT_DURATION_NAME, connection))
            using (SQLiteCommand categoryCommand = new SQLiteCommand(RETURN_PROJECT_CATEGORY_NAME, connection))
            using (SQLiteCommand subCategoryCommand = new SQLiteCommand(RETURN_PROJECT_SUBCATEGORY_NAME, connection))
            using (SQLiteCommand paymentCommand = new SQLiteCommand(RETURN_PROJECT_PAYMENT_NAME, connection))
            {
                connection.Open();
                typeCommand.Parameters.AddWithValue("@id", typeId.ToString());
                using (SQLiteDataReader typeReader = typeCommand.ExecuteReader())
                {
                    if (typeReader.Read())
                    {
                        projectInfoGrid.Rows.Add("Τύπος", getTranslation(typeReader.GetString(typeReader.GetOrdinal("type"))));
                    }
                }
                durationCommand.Parameters.AddWithValue("@id", durationId.ToString());
                using (SQLiteDataReader durationReader = durationCommand.ExecuteReader())
                {
                    if (durationReader.Read())
                    {
                        projectInfoGrid.Rows.Add("Διάρκεια", getTranslation(durationReader.GetString(durationReader.GetOrdinal("type"))));
                    }
                }
                categoryCommand.Parameters.AddWithValue("@id", categoryId.ToString());
                using (SQLiteDataReader categoryReader = categoryCommand.ExecuteReader())
                {
                    if (categoryReader.Read())
                    {
                        projectInfoGrid.Rows.Add("Κατηγορία", getTranslation(categoryReader.GetString(categoryReader.GetOrdinal("name"))));
                    }
                }
                subCategoryCommand.Parameters.AddWithValue("@id", subCategoryId.ToString());
                using (SQLiteDataReader subCategoryReader = subCategoryCommand.ExecuteReader())
                {
                    if (subCategoryReader.Read())
                    {
                        projectInfoGrid.Rows.Add("Υποκατηγορία", getTranslation(subCategoryReader.GetString(subCategoryReader.GetOrdinal("name"))));
                    }
                }
                paymentCommand.Parameters.AddWithValue("@id", paymentId.ToString());
                using (SQLiteDataReader paymentReader = paymentCommand.ExecuteReader())
                {
                    if (paymentReader.Read())
                    {
                        projectInfoGrid.Rows.Add("Τρόπος Πληρωμής", getTranslation(paymentReader.GetString(paymentReader.GetOrdinal("type"))));
                    }
                }
            }
        }

        private void ProjectViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnClosing(e);
        }

        private void recommendationButton_Click(object sender, EventArgs e)
        {
            ProjectRecommendationModal modal = new ProjectRecommendationModal(projectId);
            modal.ShowDialog();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (User.role.Equals("Developer"))
            {
                if (canOffer)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                    using (SQLiteCommand existCommand = new SQLiteCommand(OFFER_EXISTS_BY_USER_AND_PROJECT, connection))
                    using (SQLiteCommand command = new SQLiteCommand(UPDATE_OFFER, connection))
                    {
                        connection.Open();
                        existCommand.Parameters.AddWithValue("@project_id", projectId);
                        existCommand.Parameters.AddWithValue("@user_id", User.id);
                        bool exist = Convert.ToInt32(existCommand.ExecuteScalar()) != 0;
                        if (!exist)
                        {
                            command.Parameters.AddWithValue("@project", projectId);
                            command.Parameters.AddWithValue("@user", User.id);
                            command.Parameters.AddWithValue("@date", DateTime.Now.ToString(DATE_FORMAT));
                            command.ExecuteNonQuery();
                            MessageBox.Show("Η προσφορά σας αναρτήθηκε επιτυχώς.");
                            populateOfferGrid();
                            showAssignedDev();
                        }
                        else
                        {
                            MessageBox.Show("Έχετε υποβάλλει ήδη προσφορά για αυτό το έργο.");
                        }
                    }
                }
                else
                {
                    using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                    using (SQLiteCommand command = new SQLiteCommand(REMOVE_OFFER, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@project_id", projectId);
                        command.Parameters.AddWithValue("@user_id", User.id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Η προσφορά σας αποσύρθηκε.");
                        populateOfferGrid();
                    }
                }
               
            }
            
        }

        private void populateOfferGrid()
        {
            offerGrid.Rows.Clear();
            if (User.id == clientId)
            {
                DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn();
                actionColumn.Name = "Ενέργειες";
                int columnIndex = 3;
                if (offerGrid.Columns["actions"] == null)
                {
                    offerGrid.Columns.Insert(columnIndex, actionColumn);
                }
            }
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(GET_OFFERS_BY_PROJECT_ID, connection))
            using (SQLiteCommand userCommand = new SQLiteCommand(RETURN_USER_NAME, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@project_id", projectId);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    int count = 0;
                    bool offered = false;
                    while (reader.Read())
                    {
                        if (User.id == reader.GetInt32(reader.GetOrdinal("user_id")))
                        {
                            offerButton.Text = "Ακύρωση Προσφοράς";
                            canOffer = false;
                            offered = true;
                        }
                        userCommand.Parameters.AddWithValue("@id", reader.GetInt32(reader.GetOrdinal("user_id")));
                        using (SQLiteDataReader userReader = userCommand.ExecuteReader())
                        {
                            if (userReader.Read())
                            {
                                if (User.role.Equals("Developer"))
                                {
                                    offerGrid.Rows.Add("Προσφορά #" + (count + 1), userReader.GetString(userReader.GetOrdinal("username")), reader.GetString(reader.GetOrdinal("date")));
                                }
                                else if (User.role.Equals("Πελάτης"))
                                {
                                    offerGrid.Rows.Add("Προσφορά #" + (count + 1), userReader.GetString(userReader.GetOrdinal("username")), reader.GetString(reader.GetOrdinal("date")), "Ανάθεση");
                                }
                            }
                        }
                        count++;
                    }
                    if (!offered)
                    {
                        canOffer = true;
                        offerButton.Text = "Προσφορά";
                    }
                }
            }
        }

        private void showAssignedDev()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(GET_ASSIGNED_USER, connection))
            using (SQLiteCommand userCommand = new SQLiteCommand(RETURN_USER_NAME, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@project_id", projectId);
                if (command.ExecuteScalar() != DBNull.Value)
                {
                    offerGroup.Visible = false;
                    assignmentGroup.Visible = true;
                    isAssigned = true;
                    userCommand.Parameters.AddWithValue("@id", Convert.ToInt32(command.ExecuteScalar()));
                    using (SQLiteDataReader reader = userCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            assignmentBox.Text = reader.GetString(reader.GetOrdinal("username"));
                            projectInfoGrid.Rows.Add("Developer", reader.GetString(reader.GetOrdinal("username")));
                        }
                    }
                }
            }
        }

        private void offerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (offerGrid.Columns["Ενέργειες"] != null && e.ColumnIndex == offerGrid.Columns["Ενέργειες"].Index)
            {
                DataGridView grid = sender as DataGridView;
                if (grid == null || grid.CurrentRow.Cells[0].Value == null) return;
                string username = grid.CurrentRow.Cells[1].Value.ToString().Trim();
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                using (SQLiteCommand userCommand = new SQLiteCommand(RETURN_USER_ID, connection))
                using (SQLiteCommand command = new SQLiteCommand(ASSIGN_USER_TO_PROJECT, connection))
                {
                    connection.Open();
                    userCommand.Parameters.AddWithValue("@username", username);
                    using (SQLiteDataReader reader = userCommand.ExecuteReader()) 
                    { 
                        if (reader.Read())
                        {
                            command.Parameters.AddWithValue("@user_id", reader.GetInt32(reader.GetOrdinal("id")));
                            command.Parameters.AddWithValue("@project_id", projectId);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Αναθέσατε το έργο στον/στην " + username + ".");
                            offerGrid.Enabled = false;
                            showAssignedDev();
                        }
                    }
                    
                }
                
            }
            else
            {
                if (Role.isClient)
                {
                    string username = offerGrid.CurrentRow.Cells[1].Value.ToString().Trim();
                    if (!string.IsNullOrEmpty(username))
                    {
                        using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                        using (SQLiteCommand command = new SQLiteCommand(RETURN_SEARCH_USER_VARIABLES, connection))
                        {
                            try
                            {
                                connection.Open();
                                command.Parameters.AddWithValue("@username", username);
                                using (SQLiteDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        UserSearch.id = reader.GetInt32(reader.GetOrdinal("id"));
                                        UserSearch.role = reader.GetString(reader.GetOrdinal("role"));                                      
                                        UserSearch.isSearchedUser = true;
                                        UserSearchedRole.isDeveloper = true;
                                        UserSearchedRole.isClient = false;
                                        this.Hide();
                                        UserProfileForm userProfile = new UserProfileForm();
                                        userProfile.ShowDialog();
                                        this.Close();                                                                             
                                    }
                                    else
                                    {
                                        MessageBox.Show("User not found.");
                                    }

                                }
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred " + ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            if (Role.isVisitor)
            {
                MessageBox.Show("Παρακαλώ συνδεθείτε ή δημιουργήστε λογαριασμό.");
                return;
            }
            if (!commentBox.Text.Trim().Equals(""))
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(ADD_COMMENT, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@project_id", projectId);
                    command.Parameters.AddWithValue("@user_id", User.id);
                    command.Parameters.AddWithValue("@comment", commentBox.Text.Trim());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Το σχόλιό σας αναρτήθηκε επιτυχώς.");
                }
                populateCommentGrid();
            }
            else
            {
                MessageBox.Show("Παρακαλώ προσθέστε ένα σχόλιο.");
            }
        }

        private void populateCommentGrid()
        {
            commentGrid.Rows.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(GET_COMMENTS_BY_PROJECT, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@project_id", projectId);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        commentGrid.Rows.Add(reader.GetString(reader.GetOrdinal("comment")), reader.GetString(reader.GetOrdinal("username")));
                    }
                }

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete(DELETE_PROJECT_COMMENT);
            delete(DELETE_PROJECT_OFFER);
            delete(DELETE_PROJECT_TECHNOLOGY);
            delete(DELETE_PROJECT_NOTIFICATION);
            delete(DELETE_PROJECT);            
            MessageBox.Show("Το έργο διαγράφηκε.");
            this.Hide();
            HomeForm home = new HomeForm();
            home.ShowDialog();
            this.Close();
        }

        private void delete(string command_name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(command_name, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", projectId);
                command.ExecuteNonQuery();
            }
        }
    }
}
