using System;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using static SoftwarePlanner.SQLConstants;
using static SoftwarePlanner.Translations;

namespace SoftwarePlanner
{
    public partial class ProjectCreationForm : Form
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
                            projectCategoriesDropdown.Items.Add(TranslationDictionary[reader.GetString(reader.GetOrdinal("name"))]);
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
            // TODO: sanitisation
            // TODO: fields are missing
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(SAVE_PROJECT, connection))
            {
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@title", titleBox.Text);
                    command.Parameters.AddWithValue("@description", descriptionBox.Text);
                    command.Parameters.AddWithValue("@max_price", int.Parse(maxPriceBox.Text));
                    command.Parameters.AddWithValue("@price_visibility", 1);
                    command.Parameters.AddWithValue("@bidding_duration", biddingDurationBox.Text);
                    command.ExecuteNonQuery();
                }
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
                    command.Parameters.AddWithValue("@categoryName", TranslationDictionary.FirstOrDefault(x => x.Value == projectCategoriesDropdown.SelectedItem.ToString()).Key);
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
