using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;
using static SoftwarePlanner.SQLConstants;
using static SoftwarePlanner.Translations;

namespace SoftwarePlanner
{
    public partial class ProjectCreationForm : ParentForm
    {
        public ProjectCreationForm()
        {
            InitializeComponent();
            populateDropdown();
        }

        private void populateDropdown()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_PROJECT_TYPES, connection))
            {
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectTypeDropdown.Items.Add(TranslationDictionary[reader.GetString(reader.GetOrdinal("type"))]);
                        }
                    }
                }
            }
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
            using (SQLiteCommand command = new SQLiteCommand(RETURN_PROJECT_PAYMENT, connection))
            {
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectPaymentDropdown.Items.Add(TranslationDictionary[reader.GetString(reader.GetOrdinal("type"))]);
                        }
                    }
                }
            }
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_PROJECT_DURATION, connection))
            {
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectDurationDropdown.Items.Add(TranslationDictionary[reader.GetString(reader.GetOrdinal("type"))]);
                        }
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<int> technologyIds = updateTechnologiesInDB();
            int typeId = getIdOfDropdownItem(RETURN_ID_BY_PROJECT_TYPE, "@type", projectTypeDropdown.SelectedItem.ToString());
            int categoryId = getIdOfDropdownItem(RETURN_ID_BY_PROJECT_CATEGORY, "@name", projectCategoryDropdown.SelectedItem.ToString());
            int subCategoryId = getIdOfDropdownItem(RETURN_ID_BY_PROJECT_SUBCATEGORY, "@name", projectSubcategoryDropdown.SelectedItem.ToString());
            int paymentId = getIdOfDropdownItem(RETURN_ID_BY_PROJECT_PAYMENT, "@type", projectPaymentDropdown.SelectedItem.ToString());
            int durationId = getIdOfDropdownItem(RETURN_ID_BY_PROJECT_DURATION, "@type", projectDurationDropdown.SelectedItem != null ? projectDurationDropdown.SelectedItem.ToString() : null);

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand baseCommand = new SQLiteCommand(SAVE_PROJECT, connection))
            using (SQLiteCommand returnLatestId = new SQLiteCommand(RETURN_LATEST_PROJECT_ID, connection))
            using (SQLiteCommand technologyCommand = new SQLiteCommand(UPDATE_PROJECT_TECHNOLOGY, connection))
            {
                {
                    connection.Open();

                    baseCommand.Parameters.AddWithValue("@title", titleBox.Text);
                    baseCommand.Parameters.AddWithValue("@description", descriptionBox.Text);
                    baseCommand.Parameters.AddWithValue("@type", typeId);
                    baseCommand.Parameters.AddWithValue("@category", categoryId);
                    baseCommand.Parameters.AddWithValue("@subcategory", subCategoryId);
                    baseCommand.Parameters.AddWithValue("@payment", paymentId);
                    baseCommand.Parameters.AddWithValue("@client_id", User.id);
                    int maxPrice = -1;
                    if (int.TryParse(maxPriceBox.Text.Trim(), out maxPrice)) baseCommand.Parameters.AddWithValue("@max_price", maxPrice);
                    else if (maxPriceBox.Text.Trim().Length == 0) baseCommand.Parameters.AddWithValue("@max_price", null);
                    else
                    {
                        MessageBox.Show("Invalid price input.");
                        return;
                    }
                    if (durationId != -1) baseCommand.Parameters.AddWithValue("@duration", durationId);
                    else baseCommand.Parameters.AddWithValue("@duration", null);
                    int biddingDuration = -1;
                    if (int.TryParse(biddingDurationBox.Text.Trim(), out biddingDuration)) baseCommand.Parameters.AddWithValue("@bidding_duration", biddingDuration);
                    else if (biddingDurationBox.Text.Trim().Length == 0) baseCommand.Parameters.AddWithValue("@bidding_duration", null);
                    else
                    {
                        MessageBox.Show("Invalid bidding duration input.");
                        return;
                    }
                    baseCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString(DATE_FORMAT));
                    baseCommand.ExecuteNonQuery();

                    int projectId = -1;
                    using (SQLiteDataReader reader = returnLatestId.ExecuteReader())
                    {
                        if (reader.Read()) projectId = reader.GetInt32(0);
                    }
                    foreach (int id in technologyIds)
                    {
                        technologyCommand.Parameters.AddWithValue("@project_id", projectId);
                        technologyCommand.Parameters.AddWithValue("@technology_id", id);
                        technologyCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Το έργο σας αποθηκεύτηκε επιτυχώς.");
                }
                this.Hide();
                HomeForm home = new HomeForm();
                home.ShowDialog();
                this.Close();
            }
        }

        private int getIdOfDropdownItem(string sqlQuery, string parameter, string selectedItem)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
            {
                connection.Open();
                int id = -1;
                command.Parameters.AddWithValue(parameter, getTranslationKey(selectedItem));
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) id = reader.GetInt32(0);
                }
                return id;
            }
        }

        private List<int> updateTechnologiesInDB()
        {
            List<int> ids = new List<int>();
            string[] tags = technologyBox.Text.Split(',');
            for (int i = 0; i < tags.Length; i++)
            {
                tags[i] = tags[i].Trim();
                updateTechnologyInDB(tags[i]);
                ids.Add(getTechnologyId(tags[i]));
            }
            return ids;
        }

        private void updateTechnologyInDB(string technology)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(UPDATE_TECHNOLOGY, connection))
            {
                connection.Open();                
                command.Parameters.AddWithValue("@description", technology);
                command.ExecuteNonQuery();
            }
        }

        private int getTechnologyId(string technology)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_ID_BY_TECHNOLOGY, connection))
            {
                connection.Open();
                int id = -1;
                command.Parameters.AddWithValue("@description", technology);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) id = reader.GetInt32(0);
                }
                return id;
            }

        }

        private void projectCategoriesDropdown_SelectedIndexChanged(object sender, EventArgs e)
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
