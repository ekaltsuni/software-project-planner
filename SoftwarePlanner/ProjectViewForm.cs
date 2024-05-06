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

namespace SoftwarePlanner
{
    public partial class ProjectViewForm : ParentForm
    {
        private int projectId;

        public ProjectViewForm(string projectName)
        {
            InitializeComponent();
            fillProjectFields(projectName);
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

                        projectInfoGrid.Rows.Add("Τίτλος", reader.GetString(reader.GetOrdinal("title")));
                        projectInfoGrid.Rows.Add("Περιγραφή", reader.GetString(reader.GetOrdinal("description")));
                        projectInfoGrid.Rows.Add("Μέγιστη Τιμή", reader.GetInt64(reader.GetOrdinal("max_price")));
                        projectInfoGrid.Rows.Add("Διάρκεια Προσφορών", reader.GetInt64(reader.GetOrdinal("bidding_duration")));

                        typeId = reader.GetInt32(reader.GetOrdinal("type"));
                        durationId = reader.GetInt32(reader.GetOrdinal("duration"));
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
                        projectInfoGrid.Rows.Add("Τύπος", TranslationDictionary[typeReader.GetString(typeReader.GetOrdinal("type"))]);
                    }
                }
                durationCommand.Parameters.AddWithValue("@id", durationId.ToString());
                using (SQLiteDataReader durationReader = durationCommand.ExecuteReader())
                {
                    if (durationReader.Read())
                    {
                        projectInfoGrid.Rows.Add("Διάρκεια", TranslationDictionary[durationReader.GetString(durationReader.GetOrdinal("type"))]);
                    }
                }
                categoryCommand.Parameters.AddWithValue("@id", categoryId.ToString());
                using (SQLiteDataReader categoryReader = categoryCommand.ExecuteReader())
                {
                    if (categoryReader.Read())
                    {
                        projectInfoGrid.Rows.Add("Κατηγορία", TranslationDictionary[categoryReader.GetString(categoryReader.GetOrdinal("name"))]);
                    }
                }
                subCategoryCommand.Parameters.AddWithValue("@id", subCategoryId.ToString());
                using (SQLiteDataReader subCategoryReader = subCategoryCommand.ExecuteReader())
                {
                    if (subCategoryReader.Read())
                    {
                        projectInfoGrid.Rows.Add("Υποκατηγορία", TranslationDictionary[subCategoryReader.GetString(subCategoryReader.GetOrdinal("name"))]);
                    }
                }
                paymentCommand.Parameters.AddWithValue("@id", paymentId.ToString());
                using (SQLiteDataReader paymentReader = paymentCommand.ExecuteReader())
                {
                    if (paymentReader.Read())
                    {
                        projectInfoGrid.Rows.Add("Τρόπος Πληρωμής", TranslationDictionary[paymentReader.GetString(paymentReader.GetOrdinal("type"))]);
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
    }
}
