﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;

namespace SoftwarePlanner
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            setToolstripOptions();
        }

        private void setToolstripOptions()
        {
            if (!Role.isVisitor)
            {
                loginButton.Text = "Αποσύνδεση";
                loginButton.Click += new EventHandler(LogoutClickHandler);

                ToolStripMenuItem profileButton = new ToolStripMenuItem();
                profileButton.Name = "viewProfile";
                profileButton.Text = "Προφίλ";
                profileButton.Click += new EventHandler(ViewProfileClickHandler);
                toolStripMenu.Items.Add(profileButton);

                if (Role.isClient)
                {
                    ToolStripMenuItem createProjectButton = new ToolStripMenuItem();
                    createProjectButton.Name = "createProject";
                    createProjectButton.Text = "Νέο Έργο";
                    createProjectButton.Click += new EventHandler(CreateProjectClickHandler);
                    toolStripMenu.Items.Add(createProjectButton);
                }
                else if (Role.isDeveloper)
                {
                    ToolStripMenuItem createCategoryButton = new ToolStripMenuItem();
                    createCategoryButton.Name = "createCategory";
                    createCategoryButton.Text = "Νέα Κατηγορία";
                    createCategoryButton.Click += new EventHandler(CreateCategoryClickHandler);
                    toolStripMenu.Items.Add(createCategoryButton);
                }
            }
            else
            {
                loginButton.Text = "Σύνδεση";
                loginButton.Click += new EventHandler(LoginClickHandler);
            }
        }

        private void LogoutClickHandler(object sender, EventArgs e)
        {
            UserSearch.isSearchedUser = false;
            Role.isVisitor = true;
            Role.isClient = false;
            Role.isDeveloper = false;
            setToolstripOptions();
            this.Hide();
            HomeForm home = new HomeForm();
            home.ShowDialog();
            this.Close();
        }

        private void LoginClickHandler(object sender, EventArgs e)
        {            
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void CreateProjectClickHandler(object sender, EventArgs e) 
        {
            this.Hide();
            ProjectCreationForm projectCreationForm = new ProjectCreationForm();
            projectCreationForm.ShowDialog();
            this.Close();
        }

        private void CreateCategoryClickHandler(object sender, EventArgs e)
        {
            CategoryCreationModal categoryCreationModal = new CategoryCreationModal();
            categoryCreationModal.ShowDialog();
        }

        private void ViewProfileClickHandler(object sender, EventArgs e)
        {
            UserSearch.isSearchedUser = false;
            this.Hide();
            UserProfileForm userProfileForm = new UserProfileForm();
            userProfileForm.ShowDialog();
            this.Close();
        }

        protected void OnClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSearch.isSearchedUser = false;
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            this.Close();
        }

        private void ParentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }
    }
}
