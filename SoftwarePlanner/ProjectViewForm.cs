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

namespace SoftwarePlanner
{
    public partial class ProjectViewForm : Form
    {
        public ProjectViewForm(String projectName)
        {
            InitializeComponent();
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
                        //projectInfoGrid.Rows.Add("type", reader.GetString(reader.GetOrdinal("type")));

                    }
                }
            }
        }
    }
}
