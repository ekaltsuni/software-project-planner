using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwarePlanner
{
    public partial class ParentForm : Form
    {
        // TODO: change when actual login is implemented
        bool isLoggedIn = true;
        bool isClient = true;

        public ParentForm()
        {
            InitializeComponent();
            if (isLoggedIn)
            {
                loginButton.Text = "Αποσύνδεση";
                if (isClient)
                {
                    ToolStripMenuItem createProjectButton = new ToolStripMenuItem();
                    createProjectButton.Name = "createProject";
                    createProjectButton.Text = "Νέο Έργο";
                    createProjectButton.Click += new EventHandler(CreateProjectClickHandler);
                    toolStripMenu.Items.Add(createProjectButton);
                }
            }
            else
            {
                loginButton.Text = "Σύνδεση";
            }
        }

        private void CreateProjectClickHandler(object sender, EventArgs e) 
        {
            ProjectCreationForm projectCreationForm = new ProjectCreationForm();
            projectCreationForm.Show();
        }
    }
}
