using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq.Expressions;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;
using static SoftwarePlanner.SQLConstants;
using static SoftwarePlanner.Translations;

namespace SoftwarePlanner
{
    public partial class HomeForm : ParentForm
    {
        private int userPage = 0;
        private int projectPage = 0;

        public HomeForm()
        {
            InitializeComponent();
            populateDropdowns();
            
            UserSearch.isSearchedUser = false;

            nextUserPage.Enabled = false;
            previousUserPage.Enabled = false;
            nextProjectPage.Enabled = false;
            previousProjectPage.Enabled = false;
        }

        private void populateDropdowns()
        {
            userFilter.Items.Add(UserFilterOption.DEVELOPER);
            userFilter.Items.Add(UserFilterOption.CLIENT);
            userFilter.SelectedItem = UserFilterOption.DEVELOPER;
            
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_PROJECT_CATEGORIES, connection))
            {
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectCategoryDropdown.Items.Add(TranslationDictionary[reader.GetString(reader.GetOrdinal("name"))]);
                        }
                    }
                }
            }

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_TECHNOLOGIES, connection))
            {
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectTechnologyDropdown.Items.Add(reader.GetString(reader.GetOrdinal("description")));
                        }
                    }
                }
            }
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
            if (advancedProjectSearchCheckBox.Checked)
            {
                advancedProjectSearchGroup.Visible = true;
            }
            else
            {
                advancedProjectSearchGroup.Visible = false;
                projectCategoryDropdown.Items.Clear();
                projectSubcategoryDropdown.Items.Clear();
                projectTechnologyDropdown.Items.Clear();
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
            userPage = 0;
            generalUserSearch();
        }

        private void searchProjectButton_Click(object sender, EventArgs e)
        {
            projectPage = 0;
            generalProjectSearch();
        }

        private void userTable_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
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
                                    }
                                    else if (UserSearch.id != User.id && UserSearch.role.Equals("Πελάτης"))
                                    {
                                        UserSearch.isSearchedUser = true;
                                        UserSearchedRole.isDeveloper = false;
                                        UserSearchedRole.isClient = true;
                                    }
                                    else if (UserSearch.id == User.id)
                                    {
                                        UserSearch.isSearchedUser = false;
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
                    this.Hide();
                    UserProfileForm userProfile = new UserProfileForm();
                    userProfile.ShowDialog();
                    this.Close();
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

        private void nextUserPage_Click(object sender, EventArgs e)
        {
            userPage++;
            previousUserPage.Enabled = true;
            generalUserSearch();            
        }

        private void previousUserPage_Click(object sender, EventArgs e)
        {
            userPage--;
            generalUserSearch();
            if (userPage == 0)
            {
                previousUserPage.Enabled = false;
            }
        }

        private void generalUserSearch()
        {
            userTable.Rows.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                SQLiteCommand command = new SQLiteCommand();
                if (((UserFilterOption)userFilter.SelectedItem).Equals(UserFilterOption.DEVELOPER))
                {
                    if (advancedUserSearchCheckBox.Checked)
                    {
                        command = new SQLiteCommand(RETURN_DEV_ADVANCED, connection);
                        command.Parameters.AddWithValue("@username", "%" + searchUserBox.Text + "%");
                        command.Parameters.AddWithValue("@dateBefore", dateBefore.Value.ToString(DATE_FORMAT));
                        command.Parameters.AddWithValue("@dateAfter", dateAfter.Value.ToString(DATE_FORMAT));
                        int minRatingNum = -1;
                        if (int.TryParse(minRating.Text.Trim(), out minRatingNum) || minRating.Text.Trim().Equals("")) command.Parameters.AddWithValue("@minRating", minRatingNum);
                        else
                        {
                            MessageBox.Show("Invalid minimum rating.");
                            return;
                        }
                        int maxRatingNum = -1;
                        if (int.TryParse(maxRating.Text.Trim(), out maxRatingNum)) command.Parameters.AddWithValue("@maxRating", maxRatingNum);
                        else if (maxRating.Text.Trim().Equals("")) command.Parameters.AddWithValue("@maxRating", int.MaxValue);
                        else
                        {
                            MessageBox.Show("Invalid maximum rating.");
                            return;
                        }
                        int minCountNum = -1;
                        if (int.TryParse(minCount.Text.Trim(), out minCountNum) || minCount.Text.Trim().Equals("")) command.Parameters.AddWithValue("@minCount", minCountNum);
                        else
                        {
                            MessageBox.Show("Invalid minimum count.");
                            return;
                        }
                        int maxCountNum = -1;
                        if (int.TryParse(maxCount.Text.Trim(), out maxCountNum)) command.Parameters.AddWithValue("@maxCount", maxCountNum);
                        else if (maxCount.Text.Trim().Equals("")) command.Parameters.AddWithValue("@maxCount", int.MaxValue);
                        else
                        {
                            MessageBox.Show("Invalid maximum count.");
                            return;
                        }                        
                        command.Parameters.AddWithValue("@page", userPage * 10);
                    }
                    else
                    {
                        command = new SQLiteCommand(RETURN_DEV_SIMPLE, connection);
                        command.Parameters.AddWithValue("@username", "%" + searchUserBox.Text + "%");
                        command.Parameters.AddWithValue("@page", userPage * 10);
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
                        command.Parameters.AddWithValue("@page", userPage * 10);
                    }
                    else
                    {
                        command = new SQLiteCommand(RETURN_CLIENT_SIMPLE, connection);
                        command.Parameters.AddWithValue("@username", "%" + searchUserBox.Text + "%");
                        command.Parameters.AddWithValue("@page", userPage * 10);
                    }
                }
                using (command)
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                            if (count < 10)
                            {
                                userTable.Rows.Add(reader.GetString(reader.GetOrdinal("username")));
                            }                                                         
                        }
                        if (count > 10) nextUserPage.Enabled = true;
                        else nextUserPage.Enabled = false;
                    }
                }
            }
        }

        private void nextProjectPage_Click(object sender, EventArgs e)
        {
            projectPage++;
            previousProjectPage.Enabled = true;
            generalProjectSearch();
        }

        private void previousProjectPage_Click(object sender, EventArgs e)
        {
            projectPage--;
            generalProjectSearch();
            if (projectPage == 0)
            {
                previousProjectPage.Enabled = false;
            }
        }

        private void generalProjectSearch()
        {
            projectTable.Rows.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                SQLiteCommand command = new SQLiteCommand();
                if (advancedProjectSearchCheckBox.Checked)
                {
                    if (User.id >= 0) command = new SQLiteCommand(RETURN_PROJECT_ADVANCED, connection);
                    else command = new SQLiteCommand(RETURN_PUBLIC_PROJECT_ADVANCED, connection);
                    command.Parameters.AddWithValue("@title", "%" + searchProjectBox.Text + "%");
                    command.Parameters.AddWithValue("@dateBefore", projectDateBefore.Value.ToString(DATE_FORMAT));
                    command.Parameters.AddWithValue("@dateAfter", projectDateAfter.Value.ToString(DATE_FORMAT));
                    command.Parameters.AddWithValue("@category", projectCategoryDropdown.SelectedItem == null ? "%" : getTranslationKey(projectCategoryDropdown.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@subcategory", projectSubcategoryDropdown.SelectedItem == null ? "%" : getTranslationKey(projectSubcategoryDropdown.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@technology", projectTechnologyDropdown.SelectedItem == null ? "%" : projectTechnologyDropdown.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@page", projectPage * 10);
                }
                else
                {
                    if (User.id >= 0) command = new SQLiteCommand(RETURN_PROJECT_SIMPLE, connection);
                    else command = new SQLiteCommand(RETURN_PUBLIC_PROJECT_SIMPLE, connection);
                    command.Parameters.AddWithValue("@title", "%" + searchProjectBox.Text + "%");
                    command.Parameters.AddWithValue("@page", projectPage * 10);
                }
                using (command)
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                            if (count < 10)
                            {
                                projectTable.Rows.Add(reader.GetString(reader.GetOrdinal("title")));
                            }
                        }
                        if (count > 10) nextProjectPage.Enabled = true;
                        else nextProjectPage.Enabled = false;
                    }
                }
            }
        }

        private void projectCategoryDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            projectSubcategoryDropdown.Items.Clear();
            projectSubcategoryDropdown.ResetText();
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_SUBCATEGORIES_BY_CATEGORY, connection))
            {
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@categoryName", getTranslationKey(projectCategoryDropdown.SelectedItem.ToString()));
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectSubcategoryDropdown.Items.Add(TranslationDictionary[reader.GetString(reader.GetOrdinal("name"))]);
                        }
                    }
                }
            }
        }
    }
}
