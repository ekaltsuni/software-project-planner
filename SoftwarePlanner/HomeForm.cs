using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq.Expressions;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;
using static SoftwarePlanner.SQLConstants;

namespace SoftwarePlanner
{
    public partial class HomeForm : ParentForm
    {
        public HomeForm()
        {
            InitializeComponent();
            userFilter.Items.Add(UserFilterOption.DEVELOPER);
            userFilter.Items.Add(UserFilterOption.CLIENT);
            userFilter.SelectedItem = UserFilterOption.DEVELOPER;
            UserSearch.isSearchedUser = false;
        }

        private void advancedSearchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (advancedUserSearchCheckBox.Checked)
            {
                advancedSearchGroup.Visible = true;
                if (((UserFilterOption)userFilter.SelectedItem).Equals(UserFilterOption.DEVELOPER))
                {
                    devAdvancedSearchGroup.Visible = true;
                }
            }
            else
            {
                advancedSearchGroup.Visible = false;
                devAdvancedSearchGroup.Visible = false;
            }    
        }

        private void advancedProjectSearchBox_CheckedChanged(object sender, EventArgs e)
        {
            if (advancedProjectSearchBox.Checked)
            {
                advancedProjectSearchGroup.Visible = true;
            }
            else
            {
                advancedProjectSearchGroup.Visible = false;
            }
        }

        private void userFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((UserFilterOption)userFilter.SelectedItem).Equals(UserFilterOption.CLIENT))
            {
                devAdvancedSearchGroup.Visible = false;
            }
            else if (((UserFilterOption)userFilter.SelectedItem).Equals(UserFilterOption.DEVELOPER) && advancedUserSearchCheckBox.Checked)
            {
                devAdvancedSearchGroup.Visible = true;
            }
        }

        private void searchUserButton_Click(object sender, EventArgs e)
        {
            userTable.Rows.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                // TODO: sanitize inputs
                SQLiteCommand command = new SQLiteCommand();
                if (((UserFilterOption)userFilter.SelectedItem).Equals(UserFilterOption.DEVELOPER)) {
                    if (advancedUserSearchCheckBox.Checked)
                    {
                        command = new SQLiteCommand(RETURN_DEV_ADVANCED, connection);
                        command.Parameters.AddWithValue("@username", "%" + searchUserBox.Text + "%");
                        command.Parameters.AddWithValue("@dateBefore", dateBefore.Value.ToString(DATE_FORMAT));
                        command.Parameters.AddWithValue("@dateAfter", dateAfter.Value.ToString(DATE_FORMAT));
                        command.Parameters.AddWithValue("@minRating", minRating.Text.Trim().Equals("") ? -1 : int.Parse(minRating.Text));
                        command.Parameters.AddWithValue("@maxRating", maxRating.Text.Trim().Equals("") ? int.MaxValue : int.Parse(maxRating.Text));
                        command.Parameters.AddWithValue("@minCount", minCount.Text.Trim().Equals("") ? -1 : int.Parse(minCount.Text));
                        command.Parameters.AddWithValue("@maxCount", maxCount.Text.Trim().Equals("") ? int.MaxValue : int.Parse(maxCount.Text));
                    }
                    else 
                    {
                        command = new SQLiteCommand(RETURN_DEV_SIMPLE, connection);
                        command.Parameters.AddWithValue("@username", "%" + searchUserBox.Text + "%");
                    }
                }
                else
                {
                    if (advancedUserSearchCheckBox.Checked)
                    {
                        command = new SQLiteCommand(RETURN_CLIENT_ADVANCED, connection);
                        command.Parameters.AddWithValue("@username", "%" + searchUserBox.Text + "%");
                        command.Parameters.AddWithValue("@dateBefore", dateBefore.Value.ToString(DATE_FORMAT));
                        command.Parameters.AddWithValue("@dateAfter", dateAfter.Value.ToString(DATE_FORMAT));
                    }
                    else
                    {
                        command = new SQLiteCommand(RETURN_CLIENT_SIMPLE, connection);
                        command.Parameters.AddWithValue("@username", "%" + searchUserBox.Text + "%");
                    }
                }
                using (command)
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userTable.Rows.Add(reader.GetString(reader.GetOrdinal("username")));
                        }
                    }
                }
            }
        }

        private void searchProjectButton_Click(object sender, EventArgs e)
        {
            projectTable.Rows.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                // TODO: sanitize inputs
                SQLiteCommand command = new SQLiteCommand();               
                if (advancedUserSearchCheckBox.Checked)
                {
                    command = new SQLiteCommand(RETURN_PROJECT_ADVANCED, connection);
                    command.Parameters.AddWithValue("@title", "%" + searchProjectBox.Text + "%");
                    command.Parameters.AddWithValue("@dateBefore", projectDateBefore.Value.ToString(DATE_FORMAT));
                    command.Parameters.AddWithValue("@dateAfter", projectDateAfter.Value.ToString(DATE_FORMAT));
                    command.Parameters.AddWithValue("@category", categoryDropdown.SelectedItem);
                    command.Parameters.AddWithValue("@subcategory", subcategoryDropdown.SelectedItem);
                    command.Parameters.AddWithValue("@technologies", new List<string>(){"TEST"});
                }
                else
                {
                    command = new SQLiteCommand(RETURN_PROJECT_SIMPLE, connection);
                    command.Parameters.AddWithValue("@title", "%" + searchProjectBox.Text + "%");
                }              
                using (command)
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectTable.Rows.Add(reader.GetString(reader.GetOrdinal("title")));
                        }
                    }
                }
            }
        }

        private void userTable_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            // string userText = userTable.Rows[0].Cells[0].Value?.ToString();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (grid == null || grid.CurrentRow.Cells[0].Value == null) return;
                string username = grid.CurrentRow.Cells[0].Value.ToString().Trim();
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
                                    if (UserSearch.id != User.id && UserSearch.role.Equals("Developer"))
                                    {
                                        UserSearch.isSearchedUser = true;
                                        UserSearchedRole.isDeveloper = true;
                                        UserSearchedRole.isClient = false;
                                        this.Hide();
                                        UserProfileForm userProfile = new UserProfileForm();
                                        userProfile.ShowDialog();
                                        this.Close();
                                    }
                                    else if (UserSearch.id != User.id && UserSearch.role.Equals("Πελάτης"))
                                    {
                                        UserSearch.isSearchedUser = true;
                                        UserSearchedRole.isDeveloper = false;
                                        UserSearchedRole.isClient = true;
                                        this.Hide();
                                        UserProfileForm userProfile = new UserProfileForm();
                                        userProfile.ShowDialog();
                                        this.Close();

                                    }
                                    else if (UserSearch.id == User.id)
                                    {
                                        UserSearch.isSearchedUser = false;
                                        this.Hide();
                                        UserProfileForm userProfile = new UserProfileForm();
                                        userProfile.ShowDialog();
                                        this.Close();
                                    }
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

    

        private void projectTable_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            if (grid == null || grid.CurrentRow.Cells[0].Value == null) return;
            this.Hide();
            ProjectViewForm form = new ProjectViewForm(grid.CurrentRow.Cells[0].Value.ToString().Trim());
            form.ShowDialog();
            this.Close();         
        }

        private void HomeForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            OnClosing(e);
        }
    }
}
