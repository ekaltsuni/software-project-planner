using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;
using static SoftwarePlanner.SQLConstants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwarePlanner
{
    public partial class UserProfileForm : ParentForm
    {
        string email, username, password, role, name, surname, gender, skills, cv, portfolio, date_of_birth,
                link, description, other, portfolio_title, portfolio_link;
        string selectedImagePath = "";
        DateTime dateOfBirth;
        int[] skillArray = new int[8];
        int[] devVisibilityArray = new int[8];
        int[] clientVisibilityArray = new int[8];
        private int selectedProjectId = -1;
        private int selectedUserId = -1;


        public UserProfileForm()
        {
            InitializeComponent();
            initialState();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            if (UserSearch.isSearchedUser == true && UserSearchedRole.isDeveloper == true)
            {
                fillMajorFields(UserSearch.id);
                fillDeveloperFields(UserSearch.id);
                checkDevVisibility();
                hidePrivateFields();

            }
            else if (UserSearch.isSearchedUser == true && UserSearchedRole.isClient == true)
            {
                fillMajorFields(UserSearch.id);
                fillClientFields(UserSearch.id);
                checkClientVisibility();
                hidePrivateFields();
            }
            else if (UserSearch.isSearchedUser == false && Role.isClient)
            {
                fillMajorFields(User.id);
                fillClientFields(User.id);

            }
            else if (UserSearch.isSearchedUser == false && Role.isDeveloper)
            {
                fillMajorFields(User.id);
                fillDeveloperFields(User.id);
                showNotifications(User.id);
                showOffers(User.id);
                showProjects(User.id);
            }
        }



        private void fillMajorFields(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_USER_VARIABLES, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        email = reader.GetString(reader.GetOrdinal("email"));
                        username = reader.GetString(reader.GetOrdinal("username"));
                        password = reader.GetString(reader.GetOrdinal("password"));

                        if (!reader.IsDBNull(reader.GetOrdinal("name")))
                        {
                            name = reader.GetString(reader.GetOrdinal("name"));
                            nameBox.Text = name;

                        }
                        else
                        {
                            nameBox.Text = "";
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("surname")))
                        {
                            surname = reader.GetString(reader.GetOrdinal("surname"));
                            surnameBox.Text = surname;
                        }
                        else
                        {
                            surnameBox.Text = "";
                        }
                        if (reader["image_data"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["image_data"];
                            if (imageData != null && imageData.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    profileImagePictureBox.Image = Image.FromStream(ms);
                                    profileImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                            else
                            {
                                profileImagePictureBox.Image = SoftwarePlanner.Properties.Resources.upload_icon;
                                profileImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                        usernameBox.Text = username;
                        emailBox.Text = email;
                        passwordBox.Text = password;
                    }

                }
            }
        }

        private void fillClientFields(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_CLIENT_VARIABLES, connection))
            using (SQLiteCommand visibilityCommand = new SQLiteCommand(RETURN_CLIENT_VISIBILITY, connection))

            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                visibilityCommand.Parameters.AddWithValue("@id", id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("date_of_birth")))
                        {
                            date_of_birth = reader.GetString(reader.GetOrdinal("date_of_birth"));
                            datePicker.Value = DateTime.Parse(date_of_birth);
                        }
                        else
                        {
                            datePicker.Value = DateTime.Today;
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("link")))
                        {
                            link = reader.GetString(reader.GetOrdinal("link"));
                            linkBox.Text = link;
                        }
                        else
                        {
                            linkBox.Text = "";

                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("description")))
                        {
                            description = reader.GetString(reader.GetOrdinal("description"));
                            descriptionBox.Text = description;
                        }
                        else
                        {
                            descriptionBox.Text = "";
                        }
                    }
                }
                using (SQLiteDataReader reader = visibilityCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        for (int i = 0; i < clientVisibilityArray.Length; i++) clientVisibilityArray[i] = reader.GetInt32(i);

                    }
                    for (int i = 0; i < clientVisibilityArray.Length; i++) clientVisibilityFields.SetItemChecked(i, clientVisibilityArray[i] == 1);
                }

            }
        }

        private void fillDeveloperFields(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand skillsCommand = new SQLiteCommand(RETURN_SKILLS, connection))
            //using (SQLiteCommand cvCommand = new SQLiteCommand(AppConstants.RETURN_CV, connection))
            using (SQLiteCommand portfolioCommand = new SQLiteCommand(RETURN_PORTFOLIO_VARIABLES, connection))
            using (SQLiteCommand visibilityCommand = new SQLiteCommand(RETURN_DEVELOPER_VISIBILITY, connection))
            {
                connection.Open();
                skillsCommand.Parameters.AddWithValue("@id", id);
                //cvCommand.Parameters.AddWithValue("@id", User.id);
                portfolioCommand.Parameters.AddWithValue("@id", id);
                visibilityCommand.Parameters.AddWithValue("@id", id);
                using (SQLiteDataReader reader = skillsCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        for (int i = 0; i < skillArray.Length; i++) skillArray[i] = reader.GetInt32(i + 1);
                        int otherColumnIndex = reader.GetOrdinal("other");
                        if (!reader.IsDBNull(otherColumnIndex)) other = reader.GetString(otherColumnIndex);
                        else other = "";
                    }
                    for (int i = 0; i < skillArray.Length; i++) skillsListBox.SetItemChecked(i, skillArray[i] == 1);
                    skillsBox.Text = other;
                }

                using (SQLiteDataReader reader = visibilityCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        for (int i = 0; i < devVisibilityArray.Length; i++)
                        {
                            devVisibilityArray[i] = reader.GetInt32(i);
                        }
                    }
                    for (int i = 0; i < devVisibilityArray.Length; i++) developerVisibilityFields.SetItemChecked(i, devVisibilityArray[i] == 1);
                }
                /*using (SQLiteDataReader reader = cvCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //cv
                    }
                } */
                using (SQLiteDataReader reader = portfolioCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        portfolio_title = reader.IsDBNull(reader.GetOrdinal("portfolio_title")) ? "" : reader.GetString(reader.GetOrdinal("portfolio_title"));
                        portfolio_link = reader.IsDBNull(reader.GetOrdinal("portfolio_link")) ? "" : reader.GetString(reader.GetOrdinal("portfolio_link"));
                        dataGridView.Rows.Add(portfolio_title, portfolio_link);
                    }

                }

            }
        }

        private void UserProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSearch.isSearchedUser = false;
        }

        // Update fields if user exists or create user if visitor
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Role.isDeveloper) updateDeveloper();
            else if (Role.isClient) updateClient();
            else
            {
                if (!string.IsNullOrEmpty(usernameBox.Text) &&
                    !string.IsNullOrEmpty(passwordBox.Text) &&
                    !string.IsNullOrEmpty(emailBox.Text) &&
                    roleComboBox.SelectedIndex == 0)
                {
                    createClient();
                }
                else if (!string.IsNullOrEmpty(usernameBox.Text) &&
                    !string.IsNullOrEmpty(passwordBox.Text) &&
                    !string.IsNullOrEmpty(emailBox.Text) &&
                    roleComboBox.SelectedIndex == 1)
                {
                    createDeveloper();
                }
                else MessageBox.Show("Παρακαλώ συμπληρώστε τα υποχρεωτικά πεδία.");
            }
            updateProfileImage();
        }

        private void updateDeveloper()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(UPDATE_USER_VARIABLES, connection))
            using (SQLiteCommand skillsCommand = new SQLiteCommand(UPDATE_SKILLS, connection))
            using (SQLiteCommand portfolioUpdateEntryCommand = new SQLiteCommand(UPDATE_PORTFOLIO_ENTRY, connection))
            using (SQLiteCommand visibilityCommand = new SQLiteCommand(UPDATE_DEVELOPER_VISIBILITY, connection))
            {
                connection.Open();
                // Update user related fields
                command.Parameters.AddWithValue("@id", User.id);
                command.Parameters.AddWithValue("@username", usernameBox.Text);
                command.Parameters.AddWithValue("@password", passwordBox.Text);
                command.Parameters.AddWithValue("@email", emailBox.Text);
                command.Parameters.AddWithValue("@name", nameBox.Text);
                command.Parameters.AddWithValue("@surname", surnameBox.Text);
                command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                command.ExecuteNonQuery();
                // Update skill related fields
                skillsCommand.Parameters.AddWithValue("@id", User.id);
                skillsCommand.Parameters.AddWithValue("@c", returnFlag(0));
                skillsCommand.Parameters.AddWithValue("@css", returnFlag(1));
                skillsCommand.Parameters.AddWithValue("@html", returnFlag(2));
                skillsCommand.Parameters.AddWithValue("@java", returnFlag(3));
                skillsCommand.Parameters.AddWithValue("@javascript", returnFlag(4));
                skillsCommand.Parameters.AddWithValue("@php", returnFlag(5));
                skillsCommand.Parameters.AddWithValue("@python", returnFlag(6));
                skillsCommand.Parameters.AddWithValue("@ruby", returnFlag(7));
                skillsCommand.Parameters.AddWithValue("@other", skillsBox.Text);
                skillsCommand.ExecuteNonQuery();
                // Update portfolio related fields
                readPortfolio();
                portfolioUpdateEntryCommand.Parameters.AddWithValue("@id", User.id);
                portfolioUpdateEntryCommand.Parameters.AddWithValue("@portfolio_title", portfolio_title);
                portfolioUpdateEntryCommand.Parameters.AddWithValue("@portfolio_link", portfolio_link);
                portfolioUpdateEntryCommand.ExecuteNonQuery();

                // Update visibility fields
                visibilityCommand.Parameters.AddWithValue("@id", User.id);
                visibilityCommand.Parameters.AddWithValue("@email_visibility_flag", returnDevVisibilityFlag(0));
                visibilityCommand.Parameters.AddWithValue("@username_visibility_flag", returnDevVisibilityFlag(1));
                visibilityCommand.Parameters.AddWithValue("@name_visibility_flag", returnDevVisibilityFlag(2));
                visibilityCommand.Parameters.AddWithValue("@surname_visibility_flag", returnDevVisibilityFlag(3));
                visibilityCommand.Parameters.AddWithValue("@gender_visibility_flag", returnDevVisibilityFlag(4));
                visibilityCommand.Parameters.AddWithValue("@skills_visibility_flag", returnDevVisibilityFlag(5));
                visibilityCommand.Parameters.AddWithValue("@cv_visibility_flag", returnDevVisibilityFlag(6));
                visibilityCommand.Parameters.AddWithValue("@portfolio_visibility_flag", returnDevVisibilityFlag(7));
                visibilityCommand.ExecuteNonQuery();

                MessageBox.Show("Οι αλλαγές αποθηκεύτηκαν με επιτυχία.");
            }
        }

        private void createDeveloper()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(CREATE_USER_VARIABLES, connection))
            using (SQLiteCommand userIDcommand = new SQLiteCommand(RETURN_LATEST_USER_ID, connection))
            using (SQLiteCommand skillsCommand = new SQLiteCommand(CREATE_SKILLS, connection))
            using (SQLiteCommand portfolioCommand = new SQLiteCommand(CREATE_PORTFOLIO_VARIABLES, connection))
            using (SQLiteCommand visibilityCommand = new SQLiteCommand(CREATE_DEVELOPER_VISIBILITY, connection))
            {
                    connection.Open();
                    command.Parameters.AddWithValue("@username", usernameBox.Text);
                    command.Parameters.AddWithValue("@password", passwordBox.Text);
                    command.Parameters.AddWithValue("@email", emailBox.Text);
                    command.Parameters.AddWithValue("@role", roleComboBox.Text);
                    command.Parameters.AddWithValue("@name", nameBox.Text);
                    command.Parameters.AddWithValue("@surname", surnameBox.Text);
                    command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                    command.Parameters.AddWithValue("@signing_date", DateTime.Now.ToString("yyyy-MM-dd"));
                    command.ExecuteNonQuery();
                    using (SQLiteDataReader reader = userIDcommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Update skill related fields
                            skillsCommand.Parameters.AddWithValue("@id", reader.GetInt32(0));
                            skillsCommand.Parameters.AddWithValue("@other", skillsBox.Text);
                            skillsCommand.Parameters.AddWithValue("@c", returnFlag(0));
                            skillsCommand.Parameters.AddWithValue("@css", returnFlag(1));
                            skillsCommand.Parameters.AddWithValue("@html", returnFlag(2));
                            skillsCommand.Parameters.AddWithValue("@java", returnFlag(3));
                            skillsCommand.Parameters.AddWithValue("@javascript", returnFlag(4));
                            skillsCommand.Parameters.AddWithValue("@php", returnFlag(5));
                            skillsCommand.Parameters.AddWithValue("@python", returnFlag(6));
                            skillsCommand.Parameters.AddWithValue("@ruby", returnFlag(7));
                            skillsCommand.ExecuteNonQuery();

                            readPortfolio();
                            portfolioCommand.Parameters.AddWithValue("@id", reader.GetInt32(0));
                            portfolioCommand.Parameters.AddWithValue("@portfolio_title", portfolio_title);
                            portfolioCommand.Parameters.AddWithValue("@portfolio_link", portfolio_link);
                            portfolioCommand.ExecuteNonQuery();

                            // Update visibility settings
                            visibilityCommand.Parameters.AddWithValue("@id", reader.GetInt32(0));
                            visibilityCommand.Parameters.AddWithValue("@email_visibility_flag", returnDevVisibilityFlag(0));
                            visibilityCommand.Parameters.AddWithValue("@username_visibility_flag", returnDevVisibilityFlag(1));
                            visibilityCommand.Parameters.AddWithValue("@name_visibility_flag", returnDevVisibilityFlag(2));
                            visibilityCommand.Parameters.AddWithValue("@surname_visibility_flag", returnDevVisibilityFlag(3));
                            visibilityCommand.Parameters.AddWithValue("@gender_visibility_flag", returnDevVisibilityFlag(4));
                            visibilityCommand.Parameters.AddWithValue("@skills_visibility_flag", returnDevVisibilityFlag(5));
                            visibilityCommand.Parameters.AddWithValue("@cv_visibility_flag", returnDevVisibilityFlag(6));
                            visibilityCommand.Parameters.AddWithValue("@portfolio_visibility_flag", returnDevVisibilityFlag(7));
                            visibilityCommand.ExecuteNonQuery();

                            MessageBox.Show("Τα στοιχεία σας αποθηκεύτηκαν με επιτυχία.");
                        }
                    }
            }
        }

        private void updateClient()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(UPDATE_USER_VARIABLES, connection))
            using (SQLiteCommand clientOnlyCommand = new SQLiteCommand(UPDATE_CLIENT_VARIABLES, connection))
            using (SQLiteCommand userIDcommand = new SQLiteCommand(RETURN_LATEST_USER_ID, connection))
            using (SQLiteCommand visibilityCommand = new SQLiteCommand(UPDATE_CLIENT_VISIBILITY, connection))
            {                
                connection.Open();
                // Update user related fields
                command.Parameters.AddWithValue("@id", User.id);
                command.Parameters.AddWithValue("@username", usernameBox.Text);
                command.Parameters.AddWithValue("@password", passwordBox.Text);
                command.Parameters.AddWithValue("@email", emailBox.Text);
                command.Parameters.AddWithValue("@name", nameBox.Text);
                command.Parameters.AddWithValue("@surname", surnameBox.Text);
                command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                command.ExecuteNonQuery();
                // Update client related fields
                clientOnlyCommand.Parameters.AddWithValue("@id", User.id);
                clientOnlyCommand.Parameters.AddWithValue("@date_of_birth", datePicker.Value.ToString(DATE_FORMAT));
                clientOnlyCommand.Parameters.AddWithValue("@link", linkBox.Text);
                clientOnlyCommand.Parameters.AddWithValue("@description", descriptionBox.Text);
                clientOnlyCommand.ExecuteNonQuery();

                // Update visibility setting
                using (SQLiteDataReader reader = userIDcommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        visibilityCommand.Parameters.AddWithValue("@id", reader.GetInt32(0));
                        visibilityCommand.Parameters.AddWithValue("@email_visibility_flag", returnClientVisibilityFlag(0));
                        visibilityCommand.Parameters.AddWithValue("@username_visibility_flag", returnClientVisibilityFlag(1));
                        visibilityCommand.Parameters.AddWithValue("@name_visibility_flag", returnClientVisibilityFlag(2));
                        visibilityCommand.Parameters.AddWithValue("@surname_visibility_flag", returnClientVisibilityFlag(3));
                        visibilityCommand.Parameters.AddWithValue("@gender_visibility_flag", returnClientVisibilityFlag(4));
                        visibilityCommand.Parameters.AddWithValue("@date_of_birth_visibility_flag", returnClientVisibilityFlag(5));
                        visibilityCommand.Parameters.AddWithValue("@description_visibility_flag", returnClientVisibilityFlag(6));
                        visibilityCommand.Parameters.AddWithValue("@link_visibility_flag", returnClientVisibilityFlag(7));
                        visibilityCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Οι αλλαγές αποθηκεύτηκαν με επιτυχία.");
            }
        }

        private void createClient()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(CREATE_USER_VARIABLES, connection))
            using (SQLiteCommand userIDcommand = new SQLiteCommand(RETURN_LATEST_USER_ID, connection))
            using (SQLiteCommand clientCommand = new SQLiteCommand(CREATE_CLIENT_VARIABLES, connection))
            using (SQLiteCommand visibilityCommand = new SQLiteCommand(CREATE_CLIENT_VISIBILITY, connection))
            {
                connection.Open();
                // Update user related fields
                command.Parameters.AddWithValue("@username", usernameBox.Text);
                command.Parameters.AddWithValue("@password", passwordBox.Text);
                command.Parameters.AddWithValue("@email", emailBox.Text);
                command.Parameters.AddWithValue("@role", roleComboBox.Text);
                command.Parameters.AddWithValue("@name", nameBox.Text);
                command.Parameters.AddWithValue("@surname", surnameBox.Text);
                command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                command.Parameters.AddWithValue("@signing_date", DateTime.Now.ToString("yyyy-MM-dd"));
                using (SQLiteDataReader reader = userIDcommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Update client related fields
                        clientCommand.Parameters.AddWithValue("@id", reader.GetInt32(0));
                        clientCommand.Parameters.AddWithValue("@date_of_birth", datePicker.Value.ToString(DATE_FORMAT));
                        clientCommand.Parameters.AddWithValue("@description", descriptionBox.Text);
                        clientCommand.Parameters.AddWithValue("@link", linkBox.Text);
                        command.ExecuteNonQuery();
                        clientCommand.ExecuteNonQuery();

                        // Update visibility
                        visibilityCommand.Parameters.AddWithValue("@id", reader.GetInt32(0));
                        visibilityCommand.Parameters.AddWithValue("@email_visibility_flag", returnClientVisibilityFlag(0));
                        visibilityCommand.Parameters.AddWithValue("@username_visibility_flag", returnClientVisibilityFlag(1));
                        visibilityCommand.Parameters.AddWithValue("@name_visibility_flag", returnClientVisibilityFlag(2));
                        visibilityCommand.Parameters.AddWithValue("@surname_visibility_flag", returnClientVisibilityFlag(3));
                        visibilityCommand.Parameters.AddWithValue("@gender_visibility_flag", returnClientVisibilityFlag(4));
                        visibilityCommand.Parameters.AddWithValue("@date_of_birth_visibility_flag", returnClientVisibilityFlag(5));
                        visibilityCommand.Parameters.AddWithValue("@description_visibility_flag", returnClientVisibilityFlag(6));
                        visibilityCommand.Parameters.AddWithValue("@link_visibility_flag", returnClientVisibilityFlag(7));
                        visibilityCommand.ExecuteNonQuery();

                        MessageBox.Show("Τα στοιχεία σας αποθηκεύτηκαν με επιτυχία.");
                    }
                }
            }
        }

        private int returnFlag(int index)
        {
            return skillsListBox.GetItemChecked(index) ? 1 : 0;
        }

        private int returnDevVisibilityFlag(int index)
        {
            return developerVisibilityFields.GetItemChecked(index) ? 1 : 0;
        }

        private void offersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int clickedRowIndex = e.RowIndex;
                DataGridViewRow clickedRow = offersDataGrid.Rows[clickedRowIndex];

                // Retrieve project ID and user ID from the clicked row
                selectedProjectId = Convert.ToInt32(clickedRow.Cells["ProjectID"].Value);

                // Show a message box with different actions based on the selected row
                DialogResult result = MessageBox.Show("Would you like to accept this project?",
                    "Project Assignment", MessageBoxButtons.YesNoCancel);

                // Perform different actions based on the user's choice
                switch (result)
                {
                    case DialogResult.Yes:
                        UpdateProjectAssignment(selectedProjectId, User.id, "Accepted");
                        MessageBox.Show($"Project is assigned.");
                        break;
                    case DialogResult.No:
                        // Do something for the "No" option
                        UpdateProjectOfferStatus(selectedProjectId, User.id, "Declined");
                        MessageBox.Show($"Project is declined");
                        break;
                    case DialogResult.Cancel:
                        break;
                }

                // Reset selected IDs
                selectedProjectId = -1;
                selectedUserId = -1;
            }
        }

        private void UpdateProjectAssignment(int projectId, int userId, string status)
        {

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(UPDATE_PROJECT_ASSIGNMENT, connection))
            using (SQLiteCommand offerCommand = new SQLiteCommand(UPDATE_OFFER_STATUS, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@projectId", projectId);
                command.ExecuteNonQuery();                

                offerCommand.Parameters.AddWithValue("@status", status);
                offerCommand.Parameters.AddWithValue("@projectId", projectId);
                offerCommand.Parameters.AddWithValue("@userId", userId);
                offerCommand.ExecuteNonQuery();
            }
        }

        private void UpdateProjectOfferStatus(int projectId, int userId, string status)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(UPDATE_OFFER_STATUS, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@projectId", projectId);
                command.Parameters.AddWithValue("@userId", userId);
                command.ExecuteNonQuery();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {            
            delete(DELETE_USER_PORTFOLIO);
            delete(DELETE_USER_SKILL);
            delete(DELETE_USER_NOTIFICATION);
            delete(DELETE_USER_COMMENT);
            delete(DELETE_USER_OFFER);
            delete(DELETE_USER_PROJECT);
            delete(DELETE_USER_DEVELOPER);
            delete(DELETE_USER_CLIENT);            
            delete(DELETE_USER);
            MessageBox.Show("Ο χρήστης διαγράφηκε.");
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
                command.Parameters.AddWithValue("@id", UserSearch.id);                    
                command.ExecuteNonQuery();                  
            }
        }

        private int returnClientVisibilityFlag(int index) 
        {
            return clientVisibilityFields.GetItemChecked(index)? 1 : 0;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedIndex == 0)
            {
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox18.Visible = true;
                datePicker.Visible = true;
                descriptionBox.Visible = true;
                linkBox.Visible = true;
                dataGridView.Visible = false;
                clientVisibilityFields.Visible = true;
                developerVisibilityFields.Visible = false;
                skillsBox.Visible = false;
                skillsListBox.Visible = false;

            }
            else if (roleComboBox.SelectedIndex == 1)
            {
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox18.Visible = false;
                datePicker.Visible = false;
                descriptionBox.Visible = false;
                linkBox.Visible = false;
                dataGridView.Visible = true;
                clientVisibilityFields.Visible = false;
                developerVisibilityFields.Visible = true;
                skillsBox.Visible = true;
                skillsListBox.Visible = true;
            }
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void profileImagePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                profileImagePictureBox.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void updateProfileImage()
        {
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                byte[] imageData;
                using (Image image = Image.FromFile(selectedImagePath))
                {
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        imageData = ms.ToArray();
                    }
                }

                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    string query = "UPDATE User SET image_data = @image_data WHERE id = @userId";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@image_data", imageData);
                        cmd.Parameters.AddWithValue("@userId", User.id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    
        private void readPortfolio()
        {

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                portfolio_title = row.Cells[0].Value?.ToString();
                portfolio_link = row.Cells[1].Value?.ToString();

                if (string.IsNullOrWhiteSpace(portfolio_title) || string.IsNullOrWhiteSpace(portfolio_link))
                {
                    continue;
                }

            }
        }

        private void initialState()
        {
            getRole();
            if (UserSearch.isSearchedUser == false && Role.isDeveloper == true)           
            {
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox18.Visible = false;
                developerVisibilityFields.Visible = true;
                roleComboBox.Enabled = false;
                roleComboBox.Text = "Developer";
                datePicker.Visible = false;
                descriptionBox.Visible = false;
                linkBox.Visible = false;
                dataGridView.Visible = true;
                skillsBox.Visible = true;
                skillsListBox.Visible = true;
            }
            else if (UserSearch.isSearchedUser == true && UserSearchedRole.isDeveloper)
            {
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox18.Visible = false;
                developerVisibilityFields.Visible = true;
                roleComboBox.Enabled = false;
                roleComboBox.Text = "Developer";
                datePicker.Visible = false;
                descriptionBox.Visible = false;
                linkBox.Visible = false;
                dataGridView.Visible = true;
                skillsBox.Visible = true;
                skillsListBox.Visible = true;
            }
            else if (UserSearch.isSearchedUser == false && Role.isClient == true)
            {
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox18.Visible = true;
                clientVisibilityFields.Visible = true;
                roleComboBox.Enabled = false;
                roleComboBox.Text = "Πελάτης";
                datePicker.Visible = true;
                descriptionBox.Visible = true;
                linkBox.Visible = true;
                dataGridView.Visible = false;
                skillsBox.Visible= false;
                skillsListBox.Visible = false;
            }
            else if (UserSearch.isSearchedUser == true && UserSearchedRole.isClient)
            {
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox18.Visible = true;
                clientVisibilityFields.Visible = true;
                roleComboBox.Enabled = false;
                roleComboBox.Text = "Πελάτης";
                datePicker.Visible = true;
                descriptionBox.Visible = true;
                linkBox.Visible = true;
                dataGridView.Visible = false;
                skillsBox.Visible = false;
                skillsListBox.Visible = false;
            }
            else
            {
                roleComboBox.Enabled = true;
                newsFeedTextBox.Visible = false;
                offersTextBox.Visible = false;
                notificationsDataGrid.Visible = false;
                offersDataGrid.Visible = false;
                projectsTextBox.Visible = false;
                projectsDataGrid.Visible = false;
                ratingsTextBox.Visible = false;
                ratingsRichTextBox.Visible = false;
            }
            if (Role.isAdmin && UserSearch.isSearchedUser)
            {
                deleteButton.Visible = true;
            }
        }

        private void checkDevVisibility()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_DEVELOPER_VISIBILITY, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", UserSearch.id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int emailVisibilityFlag = Convert.ToInt32(reader["email_visibility_flag"]);
                        int usernameVisibilityFlag = Convert.ToInt32(reader["username_visibility_flag"]);
                        int nameVisibilityFlag = Convert.ToInt32(reader["name_visibility_flag"]);
                        int surnameVisibilityFlag = Convert.ToInt32(reader["surname_visibility_flag"]);
                        int genderVisibilityFlag = Convert.ToInt32(reader["gender_visibility_flag"]);
                        int skillsVisibilityFlag = Convert.ToInt32(reader["skills_visibility_flag"]);
                        int cvVisibilityFlag = Convert.ToInt32(reader["cv_visibility_flag"]);
                        int portfolioVisibilityFlag = Convert.ToInt32(reader["portfolio_visibility_flag"]);

                        if (emailVisibilityFlag == 1)
                        {
                            textBox3.Visible = true;
                            emailBox.Visible = true;
                            emailBox.ReadOnly = true;
                        }
                        else
                        {
                            textBox3.Visible = false;
                            emailBox.Visible = false;
                            emailBox.ReadOnly = true;
                        }

                        if (nameVisibilityFlag == 1)
                        {
                            textBox2.Visible = true;
                            nameBox.Visible = true;
                            nameBox.ReadOnly = true;
                        }
                        else
                        {
                            textBox2.Visible = false;
                            nameBox.Visible = false;
                            nameBox.ReadOnly = true;
                        }
                        if (surnameVisibilityFlag == 1)
                        {
                            textBox8.Visible = true;
                            surnameBox.Visible = true;
                            surnameBox.ReadOnly = true;
                        }
                        else
                        {
                            textBox8.Visible = false;
                            surnameBox.Visible = false;
                            surnameBox.ReadOnly = true;
                        }
                        if (genderVisibilityFlag == 1)
                        {
                            roleComboBox.Visible = true;
                            roleComboBox.Enabled = false;
                        }
                        else
                        {
                            roleComboBox.Visible = false;
                        }
                        if (skillsVisibilityFlag == 1)
                        {
                            textBox11.Visible = true;
                            skillsListBox.Visible = true;
                            skillsListBox.Enabled = false;
                            skillsBox.Visible = true; 
                            skillsBox.ReadOnly = true;
                        }
                        else
                        {
                            textBox11.Visible = false;
                            skillsListBox.Visible = false;
                            skillsBox.Visible = false;
                            skillsBox.ReadOnly = true;
                            skillsListBox.Enabled = false;
                        }
                        if (portfolioVisibilityFlag == 1)
                        {
                            textBox13.Visible = true;
                            dataGridView.Visible = true;
                            dataGridView.Enabled = false;
                        }
                        else
                        {
                            textBox13.Visible = false;
                            dataGridView.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("An error occurred.");
                    }
                }
            }
        }

        private void checkClientVisibility()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_CLIENT_VISIBILITY, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", UserSearch.id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int emailVisibilityFlag = Convert.ToInt32(reader["email_visibility_flag"]);
                        int usernameVisibilityFlag = Convert.ToInt32(reader["username_visibility_flag"]);
                        int nameVisibilityFlag = Convert.ToInt32(reader["name_visibility_flag"]);
                        int surnameVisibilityFlag = Convert.ToInt32(reader["surname_visibility_flag"]);
                        int genderVisibilityFlag = Convert.ToInt32(reader["gender_visibility_flag"]);
                        int dateVisibilityFlag = Convert.ToInt32(reader["date_of_birth_visibility_flag"]);
                        int descriptionVisibilityFlag = Convert.ToInt32(reader["description_visibility_flag"]);
                        int linkVisibilityFlag = Convert.ToInt32(reader["link_visibility_flag"]);

                        if (emailVisibilityFlag == 1)
                        {
                            textBox3.Visible = true;
                            emailBox.Visible = true;
                            emailBox.ReadOnly = true;
                        }
                        else
                        {
                            textBox3.Visible = false;
                            emailBox.Visible = false;
                            emailBox.ReadOnly = true;
                        }

                        if (nameVisibilityFlag == 1)
                        {
                            textBox2.Visible = true;
                            nameBox.Visible = true;
                            nameBox.ReadOnly = true;
                        }
                        else
                        {
                            textBox2.Visible = false;
                            nameBox.Visible = false;
                            nameBox.ReadOnly = true;
                        }
                        if (surnameVisibilityFlag == 1)
                        {
                            textBox8.Visible = true;
                            surnameBox.Visible = true;
                            surnameBox.ReadOnly = true;
                        }
                        else
                        {
                            textBox8.Visible = false;
                            surnameBox.Visible = false;
                            surnameBox.ReadOnly = true;
                        }
                        if (genderVisibilityFlag == 1)
                        {
                            roleComboBox.Visible = true;
                            roleComboBox.Enabled = false;
                        }
                        else
                        {
                            roleComboBox.Visible = false;
                        }
                        if (dateVisibilityFlag == 1)
                        {
                            textBox10.Visible = true;
                            datePicker.Visible = true;
                            datePicker.Enabled = false;
                        }
                        else
                        {
                            textBox10.Visible = false;
                            datePicker.Visible = false;
                        }
                        if (descriptionVisibilityFlag == 1)
                        {
                            textBox9.Visible = true;
                            descriptionBox.Visible = true;
                            descriptionBox.ReadOnly = true;
                        }
                        else
                        {
                            textBox9.Visible = false;
                            descriptionBox.Visible = false;
                        }
                        if (linkVisibilityFlag == 1)
                        {
                            textBox18.Visible = true;
                            linkBox.Visible = true;
                            linkBox.Enabled = false;
                        }
                        else
                        {
                            textBox18.Visible = false;
                            linkBox.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("An error occurred.");
                    }
                }
            }
        }

        private void hidePrivateFields()
        {
            usernameBox.ReadOnly = true;
            textBox21.Visible = false;
            textBox4.Visible = false;
            textBox6.Visible = false;
            passwordBox.Visible = false;
            textBox7.Visible = false;
            textBox5.Visible = false;
            saveButton.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            developerVisibilityFields.Visible = false;
            clientVisibilityFields.Visible = false;
            textBox1.Visible = false;
            profileImagePictureBox.Enabled = false;

        }

        private void showNotifications(int matchedUserId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(SHOW_NOTIFICATIONS, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@matchedUserId", matchedUserId);
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    notificationsDataGrid.DataSource = dataTable;
                }
            }
        }

        private void showOffers(int matchedUserId) 
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(SHOW_OFFERS, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@matchedUserId", matchedUserId);
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    offersDataGrid.DataSource = dataTable;
                }
            }
        }

        private void showProjects(int matchedUserId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(SHOW_ASSIGNED_PROJECTS, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@matchedUserId", matchedUserId);
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    projectsDataGrid.DataSource = dataTable;
                }
            }
        }

        private void UserProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnClosing(e);
        }
    }
}
