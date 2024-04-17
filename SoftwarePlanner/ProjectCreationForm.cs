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
                            projectTypeDropdown.Items.Add(Translations[reader.GetString(reader.GetOrdinal("type"))]);
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
                            projectCategoriesDropdown.Items.Add(Translations[reader.GetString(reader.GetOrdinal("name"))]);
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
                            projectPaymentDropdown.Items.Add(Translations[reader.GetString(reader.GetOrdinal("type"))]);
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
                            projectDurationDropdown.Items.Add(Translations[reader.GetString(reader.GetOrdinal("type"))]);
                        }
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // TODO: save to DB
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
                    command.Parameters.AddWithValue("@categoryName", Translations.FirstOrDefault(x => x.Value == projectCategoriesDropdown.SelectedItem.ToString()).Key);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectSubcategoryDropdown.Items.Add(Translations[reader.GetString(reader.GetOrdinal("name"))]);
                        }
                    }
                }
            }
        }
    }
}
