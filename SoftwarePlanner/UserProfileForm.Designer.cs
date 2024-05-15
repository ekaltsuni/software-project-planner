namespace SoftwarePlanner
{
    partial class UserProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            this.emailLabel = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.emailRequiredLabel = new System.Windows.Forms.TextBox();
            this.requiredLabel = new System.Windows.Forms.TextBox();
            this.passwordRequiredLabel = new System.Windows.Forms.TextBox();
            this.roleRequiredLabel = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.profileImageTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.TextBox();
            this.skillLabel = new System.Windows.Forms.TextBox();
            this.cvLabel = new System.Windows.Forms.TextBox();
            this.portfolioLabel = new System.Windows.Forms.TextBox();
            this.configLabel = new System.Windows.Forms.TextBox();
            this.visibleLabel = new System.Windows.Forms.TextBox();
            this.clientVisibilityFields = new System.Windows.Forms.CheckedListBox();
            this.developerVisibilityFields = new System.Windows.Forms.CheckedListBox();
            this.newsFeedTextBox = new System.Windows.Forms.TextBox();
            this.projectsTextBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.profileImagePictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.usernameRequiredLabel = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.skillsBox = new System.Windows.Forms.RichTextBox();
            this.skillsListBox = new System.Windows.Forms.CheckedListBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificationsDataGrid = new System.Windows.Forms.DataGridView();
            this.projectsDataGrid = new System.Windows.Forms.DataGridView();
            this.offersDataGrid = new System.Windows.Forms.DataGridView();
            this.offersTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.commentGrid = new System.Windows.Forms.DataGridView();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devBox = new System.Windows.Forms.GroupBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.ratingLabel = new System.Windows.Forms.TextBox();
            this.clientBox = new System.Windows.Forms.GroupBox();
            this.clientProjectGrid = new System.Windows.Forms.DataGridView();
            this.projectTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox16 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentGrid)).BeginInit();
            this.devBox.SuspendLayout();
            this.clientBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientProjectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(50, 161);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.ReadOnly = true;
            this.emailLabel.Size = new System.Drawing.Size(200, 15);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.TabStop = false;
            this.emailLabel.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(140, 158);
            this.emailBox.MaxLength = 40;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(172, 22);
            this.emailBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.passwordLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(50, 118);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.ReadOnly = true;
            this.passwordLabel.Size = new System.Drawing.Size(200, 15);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(140, 114);
            this.passwordBox.MaxLength = 32;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(172, 22);
            this.passwordBox.TabIndex = 1;
            // 
            // roleComboBox
            // 
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.roleComboBox.Items.AddRange(new object[] {
            "Πελάτης",
            "Developer"});
            this.roleComboBox.Location = new System.Drawing.Point(49, 202);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(157, 24);
            this.roleComboBox.TabIndex = 3;
            this.roleComboBox.TabStop = false;
            this.roleComboBox.Text = "Ρόλος";
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.roleComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // emailRequiredLabel
            // 
            this.emailRequiredLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.emailRequiredLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailRequiredLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.emailRequiredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRequiredLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.emailRequiredLabel.Location = new System.Drawing.Point(87, 161);
            this.emailRequiredLabel.Name = "emailRequiredLabel";
            this.emailRequiredLabel.ReadOnly = true;
            this.emailRequiredLabel.Size = new System.Drawing.Size(27, 15);
            this.emailRequiredLabel.TabIndex = 8;
            this.emailRequiredLabel.Text = "*";
            // 
            // requiredLabel
            // 
            this.requiredLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.requiredLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requiredLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.requiredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredLabel.Location = new System.Drawing.Point(50, 260);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.ReadOnly = true;
            this.requiredLabel.Size = new System.Drawing.Size(200, 13);
            this.requiredLabel.TabIndex = 9;
            this.requiredLabel.Text = "*Υποχρεωτικό Πεδίο";
            // 
            // passwordRequiredLabel
            // 
            this.passwordRequiredLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.passwordRequiredLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordRequiredLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passwordRequiredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRequiredLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.passwordRequiredLabel.Location = new System.Drawing.Point(113, 118);
            this.passwordRequiredLabel.Name = "passwordRequiredLabel";
            this.passwordRequiredLabel.ReadOnly = true;
            this.passwordRequiredLabel.Size = new System.Drawing.Size(20, 15);
            this.passwordRequiredLabel.TabIndex = 10;
            this.passwordRequiredLabel.Text = "*";
            // 
            // roleRequiredLabel
            // 
            this.roleRequiredLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.roleRequiredLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roleRequiredLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.roleRequiredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleRequiredLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.roleRequiredLabel.Location = new System.Drawing.Point(213, 202);
            this.roleRequiredLabel.Name = "roleRequiredLabel";
            this.roleRequiredLabel.ReadOnly = true;
            this.roleRequiredLabel.Size = new System.Drawing.Size(27, 15);
            this.roleRequiredLabel.TabIndex = 11;
            this.roleRequiredLabel.Text = "*";
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(50, 297);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.ReadOnly = true;
            this.nameLabel.Size = new System.Drawing.Size(200, 15);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Όνομα";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(140, 293);
            this.nameBox.MaxLength = 40;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(172, 22);
            this.nameBox.TabIndex = 4;
            // 
            // surnameLabel
            // 
            this.surnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.surnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(50, 341);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.ReadOnly = true;
            this.surnameLabel.Size = new System.Drawing.Size(200, 15);
            this.surnameLabel.TabIndex = 14;
            this.surnameLabel.Text = "Επίθετο";
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.Location = new System.Drawing.Point(140, 338);
            this.surnameBox.MaxLength = 40;
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(172, 22);
            this.surnameBox.TabIndex = 5;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Άντρας",
            "Γυναίκα",
            "Άλλο",
            "Προτιμώ να μην πω"});
            this.genderComboBox.Location = new System.Drawing.Point(50, 388);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(157, 24);
            this.genderComboBox.TabIndex = 6;
            this.genderComboBox.Text = "Φύλο";
            this.genderComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // profileImageTextBox
            // 
            this.profileImageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.profileImageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profileImageTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileImageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileImageTextBox.Location = new System.Drawing.Point(52, 454);
            this.profileImageTextBox.Name = "profileImageTextBox";
            this.profileImageTextBox.ReadOnly = true;
            this.profileImageTextBox.Size = new System.Drawing.Size(112, 15);
            this.profileImageTextBox.TabIndex = 17;
            this.profileImageTextBox.Text = "Εικόνα Προφίλ";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(52, 545);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.ReadOnly = true;
            this.dateLabel.Size = new System.Drawing.Size(200, 15);
            this.dateLabel.TabIndex = 18;
            this.dateLabel.Text = "Ημερομηνία Γέννησης";
            this.dateLabel.Visible = false;
            // 
            // skillLabel
            // 
            this.skillLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.skillLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skillLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.skillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLabel.Location = new System.Drawing.Point(457, 254);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.ReadOnly = true;
            this.skillLabel.Size = new System.Drawing.Size(200, 15);
            this.skillLabel.TabIndex = 19;
            this.skillLabel.Text = "Δεξιότητες";
            this.skillLabel.Visible = false;
            // 
            // cvLabel
            // 
            this.cvLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.cvLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cvLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvLabel.Location = new System.Drawing.Point(457, 369);
            this.cvLabel.Name = "cvLabel";
            this.cvLabel.ReadOnly = true;
            this.cvLabel.Size = new System.Drawing.Size(200, 15);
            this.cvLabel.TabIndex = 20;
            this.cvLabel.Text = "Υποβολή Βιογραφικού";
            this.cvLabel.Visible = false;
            // 
            // portfolioLabel
            // 
            this.portfolioLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.portfolioLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portfolioLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.portfolioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portfolioLabel.Location = new System.Drawing.Point(457, 445);
            this.portfolioLabel.Name = "portfolioLabel";
            this.portfolioLabel.ReadOnly = true;
            this.portfolioLabel.Size = new System.Drawing.Size(200, 15);
            this.portfolioLabel.TabIndex = 21;
            this.portfolioLabel.Text = "Portfolio";
            this.portfolioLabel.Visible = false;
            // 
            // configLabel
            // 
            this.configLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.configLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.configLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configLabel.ForeColor = System.Drawing.Color.White;
            this.configLabel.Location = new System.Drawing.Point(457, 65);
            this.configLabel.Name = "configLabel";
            this.configLabel.ReadOnly = true;
            this.configLabel.Size = new System.Drawing.Size(246, 17);
            this.configLabel.TabIndex = 22;
            this.configLabel.Text = " Ρυθμίσεις Προφίλ";
            // 
            // visibleLabel
            // 
            this.visibleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.visibleLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.visibleLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.visibleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibleLabel.Location = new System.Drawing.Point(457, 90);
            this.visibleLabel.Name = "visibleLabel";
            this.visibleLabel.ReadOnly = true;
            this.visibleLabel.Size = new System.Drawing.Size(200, 15);
            this.visibleLabel.TabIndex = 24;
            this.visibleLabel.Text = "Επιλέξτε Ορατά Πεδία";
            // 
            // clientVisibilityFields
            // 
            this.clientVisibilityFields.FormattingEnabled = true;
            this.clientVisibilityFields.Items.AddRange(new object[] {
            "Username",
            "Email",
            "Όνομα",
            "Επίθετο",
            "Φύλο",
            "Ημερομηνία Γέννησης",
            "Περιγραφή",
            "Σύνδεσμος"});
            this.clientVisibilityFields.Location = new System.Drawing.Point(457, 123);
            this.clientVisibilityFields.Name = "clientVisibilityFields";
            this.clientVisibilityFields.Size = new System.Drawing.Size(246, 79);
            this.clientVisibilityFields.TabIndex = 27;
            this.clientVisibilityFields.Visible = false;
            // 
            // developerVisibilityFields
            // 
            this.developerVisibilityFields.FormattingEnabled = true;
            this.developerVisibilityFields.Items.AddRange(new object[] {
            "Username",
            "Email",
            "Όνομα",
            "Επίθετο",
            "Φύλο",
            "Δεξιότητες",
            "Βιογραφικό",
            "Portfolio"});
            this.developerVisibilityFields.Location = new System.Drawing.Point(457, 117);
            this.developerVisibilityFields.Name = "developerVisibilityFields";
            this.developerVisibilityFields.Size = new System.Drawing.Size(246, 79);
            this.developerVisibilityFields.TabIndex = 28;
            this.developerVisibilityFields.Visible = false;
            // 
            // newsFeedTextBox
            // 
            this.newsFeedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.newsFeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newsFeedTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.newsFeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsFeedTextBox.ForeColor = System.Drawing.Color.White;
            this.newsFeedTextBox.Location = new System.Drawing.Point(64, 183);
            this.newsFeedTextBox.Name = "newsFeedTextBox";
            this.newsFeedTextBox.ReadOnly = true;
            this.newsFeedTextBox.Size = new System.Drawing.Size(350, 17);
            this.newsFeedTextBox.TabIndex = 29;
            this.newsFeedTextBox.Text = " Προτάσεις";
            // 
            // projectsTextBox
            // 
            this.projectsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.projectsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectsTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.projectsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsTextBox.ForeColor = System.Drawing.Color.White;
            this.projectsTextBox.Location = new System.Drawing.Point(64, 342);
            this.projectsTextBox.Name = "projectsTextBox";
            this.projectsTextBox.ReadOnly = true;
            this.projectsTextBox.Size = new System.Drawing.Size(350, 17);
            this.projectsTextBox.TabIndex = 31;
            this.projectsTextBox.Text = " Έργα";
            // 
            // commentLabel
            // 
            this.commentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.commentLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLabel.ForeColor = System.Drawing.Color.White;
            this.commentLabel.Location = new System.Drawing.Point(831, 530);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.ReadOnly = true;
            this.commentLabel.Size = new System.Drawing.Size(277, 17);
            this.commentLabel.TabIndex = 33;
            this.commentLabel.Text = " Αξιολογήσεις";
            this.commentLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(206)))), ((int)(((byte)(246)))));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.saveButton.Location = new System.Drawing.Point(315, 593);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 53);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "Αποθήκευση";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // profileImagePictureBox
            // 
            this.profileImagePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileImagePictureBox.Image = global::SoftwarePlanner.Properties.Resources.upload_icon;
            this.profileImagePictureBox.Location = new System.Drawing.Point(171, 454);
            this.profileImagePictureBox.Name = "profileImagePictureBox";
            this.profileImagePictureBox.Size = new System.Drawing.Size(69, 70);
            this.profileImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImagePictureBox.TabIndex = 38;
            this.profileImagePictureBox.TabStop = false;
            this.profileImagePictureBox.Click += new System.EventHandler(this.profileImagePictureBox_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(457, 250);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.ReadOnly = true;
            this.descriptionLabel.Size = new System.Drawing.Size(200, 15);
            this.descriptionLabel.TabIndex = 39;
            this.descriptionLabel.Text = "Περιγραφή";
            this.descriptionLabel.Visible = false;
            // 
            // linkLabel
            // 
            this.linkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.linkLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linkLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(457, 373);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.ReadOnly = true;
            this.linkLabel.Size = new System.Drawing.Size(200, 15);
            this.linkLabel.TabIndex = 40;
            this.linkLabel.Text = "Σύνδεσμος";
            this.linkLabel.Visible = false;
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(140, 72);
            this.usernameBox.MaxLength = 32;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(172, 22);
            this.usernameBox.TabIndex = 0;
            // 
            // usernameRequiredLabel
            // 
            this.usernameRequiredLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.usernameRequiredLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameRequiredLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usernameRequiredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRequiredLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.usernameRequiredLabel.Location = new System.Drawing.Point(117, 72);
            this.usernameRequiredLabel.Name = "usernameRequiredLabel";
            this.usernameRequiredLabel.ReadOnly = true;
            this.usernameRequiredLabel.Size = new System.Drawing.Size(20, 15);
            this.usernameRequiredLabel.TabIndex = 43;
            this.usernameRequiredLabel.Text = "*";
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.usernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(50, 76);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.ReadOnly = true;
            this.usernameLabel.Size = new System.Drawing.Size(200, 15);
            this.usernameLabel.TabIndex = 41;
            this.usernameLabel.Text = "Username";
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(49, 573);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(135, 20);
            this.datePicker.TabIndex = 44;
            this.datePicker.Value = new System.DateTime(2024, 4, 16, 0, 0, 0, 0);
            this.datePicker.Visible = false;
            // 
            // linkBox
            // 
            this.linkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBox.Location = new System.Drawing.Point(457, 395);
            this.linkBox.MaxLength = 40;
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(295, 22);
            this.linkBox.TabIndex = 8;
            this.linkBox.Visible = false;
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionBox.Location = new System.Drawing.Point(457, 274);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionBox.MaxLength = 300;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(295, 31);
            this.descriptionBox.TabIndex = 7;
            this.descriptionBox.Text = "";
            this.descriptionBox.Visible = false;
            // 
            // skillsBox
            // 
            this.skillsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skillsBox.Location = new System.Drawing.Point(569, 274);
            this.skillsBox.Margin = new System.Windows.Forms.Padding(2);
            this.skillsBox.MaxLength = 300;
            this.skillsBox.Name = "skillsBox";
            this.skillsBox.Size = new System.Drawing.Size(184, 64);
            this.skillsBox.TabIndex = 9;
            this.skillsBox.Text = "";
            this.skillsBox.Visible = false;
            // 
            // skillsListBox
            // 
            this.skillsListBox.CheckOnClick = true;
            this.skillsListBox.FormattingEnabled = true;
            this.skillsListBox.Items.AddRange(new object[] {
            "C",
            "CSS",
            "HTML",
            "Java",
            "JavaScript",
            "PHP",
            "Python",
            "Ruby"});
            this.skillsListBox.Location = new System.Drawing.Point(457, 274);
            this.skillsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.skillsListBox.Name = "skillsListBox";
            this.skillsListBox.Size = new System.Drawing.Size(109, 64);
            this.skillsListBox.TabIndex = 45;
            this.skillsListBox.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Column1});
            this.dataGridView.Location = new System.Drawing.Point(457, 465);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(294, 98);
            this.dataGridView.TabIndex = 47;
            this.dataGridView.Visible = false;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Link";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // notificationsDataGrid
            // 
            this.notificationsDataGrid.AllowUserToAddRows = false;
            this.notificationsDataGrid.AllowUserToDeleteRows = false;
            this.notificationsDataGrid.AllowUserToResizeRows = false;
            this.notificationsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notificationsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.notificationsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notificationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notificationsDataGrid.Location = new System.Drawing.Point(64, 200);
            this.notificationsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.notificationsDataGrid.Name = "notificationsDataGrid";
            this.notificationsDataGrid.ReadOnly = true;
            this.notificationsDataGrid.RowHeadersWidth = 62;
            this.notificationsDataGrid.RowTemplate.Height = 28;
            this.notificationsDataGrid.Size = new System.Drawing.Size(350, 115);
            this.notificationsDataGrid.TabIndex = 48;
            // 
            // projectsDataGrid
            // 
            this.projectsDataGrid.AllowUserToAddRows = false;
            this.projectsDataGrid.AllowUserToDeleteRows = false;
            this.projectsDataGrid.AllowUserToResizeRows = false;
            this.projectsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.projectsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGrid.Location = new System.Drawing.Point(64, 360);
            this.projectsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.projectsDataGrid.Name = "projectsDataGrid";
            this.projectsDataGrid.ReadOnly = true;
            this.projectsDataGrid.RowHeadersWidth = 62;
            this.projectsDataGrid.RowTemplate.Height = 28;
            this.projectsDataGrid.Size = new System.Drawing.Size(350, 113);
            this.projectsDataGrid.TabIndex = 49;
            // 
            // offersDataGrid
            // 
            this.offersDataGrid.AllowUserToAddRows = false;
            this.offersDataGrid.AllowUserToDeleteRows = false;
            this.offersDataGrid.AllowUserToResizeRows = false;
            this.offersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.offersDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.offersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.offersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offersDataGrid.Location = new System.Drawing.Point(64, 42);
            this.offersDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.offersDataGrid.Name = "offersDataGrid";
            this.offersDataGrid.ReadOnly = true;
            this.offersDataGrid.RowHeadersWidth = 62;
            this.offersDataGrid.RowTemplate.Height = 28;
            this.offersDataGrid.Size = new System.Drawing.Size(350, 123);
            this.offersDataGrid.TabIndex = 51;
            this.offersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.offersDataGrid_CellContentClick);
            // 
            // offersTextBox
            // 
            this.offersTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.offersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.offersTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.offersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offersTextBox.ForeColor = System.Drawing.Color.White;
            this.offersTextBox.Location = new System.Drawing.Point(64, 25);
            this.offersTextBox.Name = "offersTextBox";
            this.offersTextBox.ReadOnly = true;
            this.offersTextBox.Size = new System.Drawing.Size(350, 17);
            this.offersTextBox.TabIndex = 50;
            this.offersTextBox.Text = " Προσφορές";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(626, 593);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 53);
            this.deleteButton.TabIndex = 52;
            this.deleteButton.Text = "Διαγραφή";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // commentGrid
            // 
            this.commentGrid.AllowUserToAddRows = false;
            this.commentGrid.AllowUserToDeleteRows = false;
            this.commentGrid.AllowUserToResizeRows = false;
            this.commentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commentGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.commentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comment});
            this.commentGrid.Location = new System.Drawing.Point(831, 548);
            this.commentGrid.Margin = new System.Windows.Forms.Padding(2);
            this.commentGrid.Name = "commentGrid";
            this.commentGrid.ReadOnly = true;
            this.commentGrid.RowHeadersWidth = 62;
            this.commentGrid.RowTemplate.Height = 28;
            this.commentGrid.Size = new System.Drawing.Size(277, 89);
            this.commentGrid.TabIndex = 53;
            this.commentGrid.Visible = false;
            // 
            // comment
            // 
            this.comment.HeaderText = "Σχόλιο";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            // 
            // devBox
            // 
            this.devBox.Controls.Add(this.offersDataGrid);
            this.devBox.Controls.Add(this.offersTextBox);
            this.devBox.Controls.Add(this.projectsDataGrid);
            this.devBox.Controls.Add(this.notificationsDataGrid);
            this.devBox.Controls.Add(this.projectsTextBox);
            this.devBox.Controls.Add(this.newsFeedTextBox);
            this.devBox.Location = new System.Drawing.Point(806, 41);
            this.devBox.Name = "devBox";
            this.devBox.Size = new System.Drawing.Size(446, 483);
            this.devBox.TabIndex = 54;
            this.devBox.TabStop = false;
            this.devBox.Visible = false;
            // 
            // ratingBox
            // 
            this.ratingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ratingBox.Location = new System.Drawing.Point(1124, 547);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.ReadOnly = true;
            this.ratingBox.Size = new System.Drawing.Size(111, 90);
            this.ratingBox.TabIndex = 55;
            this.ratingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ratingBox.Visible = false;
            // 
            // ratingLabel
            // 
            this.ratingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.ratingLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratingLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.ForeColor = System.Drawing.Color.White;
            this.ratingLabel.Location = new System.Drawing.Point(1124, 530);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.ReadOnly = true;
            this.ratingLabel.Size = new System.Drawing.Size(111, 17);
            this.ratingLabel.TabIndex = 54;
            this.ratingLabel.Text = "Βαθμός";
            this.ratingLabel.Visible = false;
            // 
            // clientBox
            // 
            this.clientBox.Controls.Add(this.clientProjectGrid);
            this.clientBox.Controls.Add(this.textBox16);
            this.clientBox.Location = new System.Drawing.Point(806, 41);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(445, 319);
            this.clientBox.TabIndex = 55;
            this.clientBox.TabStop = false;
            this.clientBox.Visible = false;
            // 
            // clientProjectGrid
            // 
            this.clientProjectGrid.AllowUserToAddRows = false;
            this.clientProjectGrid.AllowUserToDeleteRows = false;
            this.clientProjectGrid.AllowUserToResizeRows = false;
            this.clientProjectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientProjectGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.clientProjectGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientProjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientProjectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectTitle,
            this.finished});
            this.clientProjectGrid.Location = new System.Drawing.Point(47, 35);
            this.clientProjectGrid.Margin = new System.Windows.Forms.Padding(2);
            this.clientProjectGrid.Name = "clientProjectGrid";
            this.clientProjectGrid.ReadOnly = true;
            this.clientProjectGrid.RowHeadersWidth = 62;
            this.clientProjectGrid.RowTemplate.Height = 28;
            this.clientProjectGrid.Size = new System.Drawing.Size(350, 262);
            this.clientProjectGrid.TabIndex = 51;
            this.clientProjectGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientProjectGrid_CellClick);
            // 
            // projectTitle
            // 
            this.projectTitle.HeaderText = "Τίτλος";
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.ReadOnly = true;
            // 
            // finished
            // 
            this.finished.HeaderText = "Ολοκληρωμένο";
            this.finished.Name = "finished";
            this.finished.ReadOnly = true;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.White;
            this.textBox16.Location = new System.Drawing.Point(47, 17);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(350, 17);
            this.textBox16.TabIndex = 50;
            this.textBox16.Text = " Έργα";
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.commentGrid);
            this.Controls.Add(this.profileImagePictureBox);
            this.Controls.Add(this.skillsListBox);
            this.Controls.Add(this.skillsBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.usernameRequiredLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.developerVisibilityFields);
            this.Controls.Add(this.clientVisibilityFields);
            this.Controls.Add(this.visibleLabel);
            this.Controls.Add(this.configLabel);
            this.Controls.Add(this.portfolioLabel);
            this.Controls.Add(this.cvLabel);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.profileImageTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.roleRequiredLabel);
            this.Controls.Add(this.passwordRequiredLabel);
            this.Controls.Add(this.requiredLabel);
            this.Controls.Add(this.emailRequiredLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.devBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Προφίλ Χρήστη";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserProfileForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserProfileForm_FormClosed);
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            this.Controls.SetChildIndex(this.devBox, 0);
            this.Controls.SetChildIndex(this.emailLabel, 0);
            this.Controls.SetChildIndex(this.emailBox, 0);
            this.Controls.SetChildIndex(this.passwordLabel, 0);
            this.Controls.SetChildIndex(this.roleComboBox, 0);
            this.Controls.SetChildIndex(this.emailRequiredLabel, 0);
            this.Controls.SetChildIndex(this.requiredLabel, 0);
            this.Controls.SetChildIndex(this.passwordRequiredLabel, 0);
            this.Controls.SetChildIndex(this.roleRequiredLabel, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.Controls.SetChildIndex(this.nameBox, 0);
            this.Controls.SetChildIndex(this.surnameLabel, 0);
            this.Controls.SetChildIndex(this.surnameBox, 0);
            this.Controls.SetChildIndex(this.genderComboBox, 0);
            this.Controls.SetChildIndex(this.profileImageTextBox, 0);
            this.Controls.SetChildIndex(this.dateLabel, 0);
            this.Controls.SetChildIndex(this.skillLabel, 0);
            this.Controls.SetChildIndex(this.cvLabel, 0);
            this.Controls.SetChildIndex(this.portfolioLabel, 0);
            this.Controls.SetChildIndex(this.configLabel, 0);
            this.Controls.SetChildIndex(this.visibleLabel, 0);
            this.Controls.SetChildIndex(this.clientVisibilityFields, 0);
            this.Controls.SetChildIndex(this.developerVisibilityFields, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.passwordBox, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            this.Controls.SetChildIndex(this.linkLabel, 0);
            this.Controls.SetChildIndex(this.usernameLabel, 0);
            this.Controls.SetChildIndex(this.usernameRequiredLabel, 0);
            this.Controls.SetChildIndex(this.usernameBox, 0);
            this.Controls.SetChildIndex(this.datePicker, 0);
            this.Controls.SetChildIndex(this.linkBox, 0);
            this.Controls.SetChildIndex(this.descriptionBox, 0);
            this.Controls.SetChildIndex(this.commentLabel, 0);
            this.Controls.SetChildIndex(this.skillsBox, 0);
            this.Controls.SetChildIndex(this.skillsListBox, 0);
            this.Controls.SetChildIndex(this.profileImagePictureBox, 0);
            this.Controls.SetChildIndex(this.commentGrid, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.deleteButton, 0);
            this.Controls.SetChildIndex(this.ratingLabel, 0);
            this.Controls.SetChildIndex(this.clientBox, 0);
            this.Controls.SetChildIndex(this.ratingBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.profileImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentGrid)).EndInit();
            this.devBox.ResumeLayout(false);
            this.devBox.PerformLayout();
            this.clientBox.ResumeLayout(false);
            this.clientBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientProjectGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.TextBox emailRequiredLabel;
        private System.Windows.Forms.TextBox requiredLabel;
        private System.Windows.Forms.TextBox passwordRequiredLabel;
        private System.Windows.Forms.TextBox roleRequiredLabel;
        private System.Windows.Forms.TextBox nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameLabel;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox profileImageTextBox;
        private System.Windows.Forms.TextBox dateLabel;
        private System.Windows.Forms.TextBox skillLabel;
        private System.Windows.Forms.TextBox cvLabel;
        private System.Windows.Forms.TextBox portfolioLabel;
        private System.Windows.Forms.TextBox configLabel;
        private System.Windows.Forms.TextBox visibleLabel;
        private System.Windows.Forms.CheckedListBox clientVisibilityFields;
        private System.Windows.Forms.CheckedListBox developerVisibilityFields;
        private System.Windows.Forms.TextBox newsFeedTextBox;
        private System.Windows.Forms.TextBox projectsTextBox;
        private System.Windows.Forms.TextBox commentLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox profileImagePictureBox;
        private System.Windows.Forms.TextBox descriptionLabel;
        private System.Windows.Forms.TextBox linkLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox usernameRequiredLabel;
        private System.Windows.Forms.TextBox usernameLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.RichTextBox skillsBox;
        private System.Windows.Forms.CheckedListBox skillsListBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView notificationsDataGrid;
        private System.Windows.Forms.DataGridView projectsDataGrid;
        private System.Windows.Forms.DataGridView offersDataGrid;
        private System.Windows.Forms.TextBox offersTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView commentGrid;
        private System.Windows.Forms.GroupBox devBox;
        private System.Windows.Forms.GroupBox clientBox;
        private System.Windows.Forms.DataGridView clientProjectGrid;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn finished;
        private System.Windows.Forms.TextBox ratingLabel;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
    }
}