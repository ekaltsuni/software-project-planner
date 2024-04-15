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
            // TODO: Get these values from DB
            categoryDropdown.Items.Add(ProjectCategory.WEBSITE);
            categoryDropdown.Items.Add(ProjectCategory.ESHOP);
            // TODO: Filter based on category (will be easy with DB)
            subcategoryDropdown.Items.Add(ProjectSubCategory.CORPORATE);
            subcategoryDropdown.Items.Add(ProjectSubCategory.PORTAL);
            subcategoryDropdown.Items.Add(ProjectSubCategory.WORDPRESS);
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
            while (userTable.Controls.Count > 0)
            {
                userTable.Controls[0].Dispose();
            }
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
                        int i = 0;
                        while (reader.Read())
                        {
                            userTable.RowStyles.Add(new RowStyle(SizeType.AutoSize, 100F));
                            Label label = new Label();
                            label.Text = reader.GetString(reader.GetOrdinal("username"));
                            label.Font = new Font(FontFamily.GenericSansSerif, 12);
                            userTable.Controls.Add(label, 0, i);
                            i++;
                        }
                    }
                }
            }
        }

        private void searchProjectButton_Click(object sender, EventArgs e)
        {
            while (projectTable.Controls.Count > 0)
            {
                projectTable.Controls[0].Dispose();
            }
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
                        int i = 0;
                        while (reader.Read())
                        {
                            projectTable.RowStyles.Add(new RowStyle(SizeType.AutoSize, 100F));
                            Label label = new Label();
                            label.Text = reader.GetString(reader.GetOrdinal("title"));
                            label.Font = new Font(FontFamily.GenericSansSerif, 12);
                            projectTable.Controls.Add(label, 0, i);
                            i++;
                        }
                    }
                }
            }
        }
    }
}
