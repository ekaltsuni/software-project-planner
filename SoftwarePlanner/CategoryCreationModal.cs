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
using static SoftwarePlanner.SQLConstants;
using static SoftwarePlanner.Translations;

namespace SoftwarePlanner
{
    public partial class CategoryCreationModal : Form
    {
        public CategoryCreationModal()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (categoryBox.Text.Trim().Length > 0)
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(ADD_CATEGORY, connection))
                { 
                    connection.Open();
                    command.Parameters.AddWithValue("@name", categoryBox.Text.Trim());
                    //command.ExecuteNonQuery();
                    MessageBox.Show("Η κατηγορία " + categoryBox.Text.Trim() + " προστέθηκε.");
                }
            }
        }
    }
}
