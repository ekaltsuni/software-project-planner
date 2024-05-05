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
        public ProjectViewForm(String projectName)
        {
            InitializeComponent();
            int typeId = -1;
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_PROJECT_FULL, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@title", projectName);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        projectInfoGrid.Rows.Add("title", reader.GetString(reader.GetOrdinal("title")));
                        projectInfoGrid.Rows.Add("description", reader.GetString(reader.GetOrdinal("description")));
                        projectInfoGrid.Rows.Add("max_price", reader.GetInt64(reader.GetOrdinal("max_price")));
                        projectInfoGrid.Rows.Add("bidding_duration", reader.GetInt64(reader.GetOrdinal("bidding_duration")));

                        typeId = reader.GetInt32(reader.GetOrdinal("type"));
                    }
                }                                                
            }

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand typeCommand = new SQLiteCommand(RETURN_PROJECT_TYPE_NAME, connection))
            {
                connection.Open();
                typeCommand.Parameters.AddWithValue("@id", typeId.ToString());
                using (SQLiteDataReader typeReader = typeCommand.ExecuteReader())
                {
                    if (typeReader.Read())
                    {
                        projectInfoGrid.Rows.Add("type", TranslationDictionary[typeReader.GetString(typeReader.GetOrdinal("type"))]);
                    }
                }
            }            
        }

        private void ProjectViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnClosing(e);
        }
    }
}
