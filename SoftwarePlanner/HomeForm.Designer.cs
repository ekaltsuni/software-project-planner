namespace SoftwarePlanner
{
    partial class HomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.searchUserBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userFilter = new System.Windows.Forms.ComboBox();
            this.minRating = new System.Windows.Forms.TextBox();
            this.devAdvancedSearchGroup = new System.Windows.Forms.GroupBox();
            this.maxCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.minCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxRating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateBefore = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.advancedUserSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.dateAfter = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.advancedSearchGroup = new System.Windows.Forms.GroupBox();
            this.categoryDropdown = new System.Windows.Forms.ComboBox();
            this.subcategoryDropdown = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchProjectButton = new System.Windows.Forms.Button();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.advancedProjectSearchBox = new System.Windows.Forms.CheckBox();
            this.searchProjectBox = new System.Windows.Forms.TextBox();
            this.advancedProjectSearchGroup = new System.Windows.Forms.GroupBox();
            this.projectDateAfter = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.projectDateBefore = new System.Windows.Forms.DateTimePicker();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextUserPage = new System.Windows.Forms.Button();
            this.previousUserPage = new System.Windows.Forms.Button();
            this.previousProjectPage = new System.Windows.Forms.Button();
            this.nextProjectPage = new System.Windows.Forms.Button();
            this.devAdvancedSearchGroup.SuspendLayout();
            this.advancedSearchGroup.SuspendLayout();
            this.advancedProjectSearchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTable)).BeginInit();
            this.SuspendLayout();
            // 
            // searchUserBox
            // 
            this.searchUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchUserBox.Location = new System.Drawing.Point(84, 86);
            this.searchUserBox.Name = "searchUserBox";
            this.searchUserBox.Size = new System.Drawing.Size(393, 31);
            this.searchUserBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Χρήστες";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(655, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Έργα";
            // 
            // userFilter
            // 
            this.userFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userFilter.FormattingEnabled = true;
            this.userFilter.Location = new System.Drawing.Point(349, 48);
            this.userFilter.Name = "userFilter";
            this.userFilter.Size = new System.Drawing.Size(128, 21);
            this.userFilter.TabIndex = 8;
            this.userFilter.SelectedIndexChanged += new System.EventHandler(this.userFilter_SelectedIndexChanged);
            // 
            // minRating
            // 
            this.minRating.Location = new System.Drawing.Point(72, 19);
            this.minRating.Name = "minRating";
            this.minRating.Size = new System.Drawing.Size(48, 20);
            this.minRating.TabIndex = 9;
            // 
            // devAdvancedSearchGroup
            // 
            this.devAdvancedSearchGroup.Controls.Add(this.maxCount);
            this.devAdvancedSearchGroup.Controls.Add(this.label8);
            this.devAdvancedSearchGroup.Controls.Add(this.minCount);
            this.devAdvancedSearchGroup.Controls.Add(this.label5);
            this.devAdvancedSearchGroup.Controls.Add(this.maxRating);
            this.devAdvancedSearchGroup.Controls.Add(this.label4);
            this.devAdvancedSearchGroup.Controls.Add(this.label3);
            this.devAdvancedSearchGroup.Controls.Add(this.minRating);
            this.devAdvancedSearchGroup.Location = new System.Drawing.Point(84, 168);
            this.devAdvancedSearchGroup.Name = "devAdvancedSearchGroup";
            this.devAdvancedSearchGroup.Size = new System.Drawing.Size(520, 48);
            this.devAdvancedSearchGroup.TabIndex = 10;
            this.devAdvancedSearchGroup.TabStop = false;
            this.devAdvancedSearchGroup.Visible = false;
            // 
            // maxCount
            // 
            this.maxCount.Location = new System.Drawing.Point(418, 19);
            this.maxCount.Name = "maxCount";
            this.maxCount.Size = new System.Drawing.Size(48, 20);
            this.maxCount.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "μέχρι";
            // 
            // minCount
            // 
            this.minCount.Location = new System.Drawing.Point(324, 19);
            this.minCount.Name = "minCount";
            this.minCount.Size = new System.Drawing.Size(48, 20);
            this.minCount.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Έργα από";
            // 
            // maxRating
            // 
            this.maxRating.Location = new System.Drawing.Point(166, 19);
            this.maxRating.Name = "maxRating";
            this.maxRating.Size = new System.Drawing.Size(48, 20);
            this.maxRating.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "μέχρι";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rating από";
            // 
            // dateBefore
            // 
            this.dateBefore.CustomFormat = "YYYY-MM-DD";
            this.dateBefore.Location = new System.Drawing.Point(86, 19);
            this.dateBefore.Name = "dateBefore";
            this.dateBefore.Size = new System.Drawing.Size(133, 20);
            this.dateBefore.TabIndex = 11;
            this.dateBefore.Value = new System.DateTime(2024, 4, 15, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Εγγραφή από";
            // 
            // advancedUserSearchCheckBox
            // 
            this.advancedUserSearchCheckBox.AutoSize = true;
            this.advancedUserSearchCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.advancedUserSearchCheckBox.Location = new System.Drawing.Point(483, 100);
            this.advancedUserSearchCheckBox.Name = "advancedUserSearchCheckBox";
            this.advancedUserSearchCheckBox.Size = new System.Drawing.Size(128, 17);
            this.advancedUserSearchCheckBox.TabIndex = 16;
            this.advancedUserSearchCheckBox.Text = "Σύνθετη Αναζήτηση";
            this.advancedUserSearchCheckBox.UseVisualStyleBackColor = true;
            this.advancedUserSearchCheckBox.CheckedChanged += new System.EventHandler(this.advancedSearchCheckBox_CheckedChanged);
            // 
            // dateAfter
            // 
            this.dateAfter.Location = new System.Drawing.Point(265, 19);
            this.dateAfter.Name = "dateAfter";
            this.dateAfter.Size = new System.Drawing.Size(133, 20);
            this.dateAfter.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "μέχρι";
            // 
            // advancedSearchGroup
            // 
            this.advancedSearchGroup.Controls.Add(this.label6);
            this.advancedSearchGroup.Controls.Add(this.label7);
            this.advancedSearchGroup.Controls.Add(this.dateBefore);
            this.advancedSearchGroup.Controls.Add(this.dateAfter);
            this.advancedSearchGroup.Location = new System.Drawing.Point(84, 123);
            this.advancedSearchGroup.Name = "advancedSearchGroup";
            this.advancedSearchGroup.Size = new System.Drawing.Size(520, 43);
            this.advancedSearchGroup.TabIndex = 19;
            this.advancedSearchGroup.TabStop = false;
            this.advancedSearchGroup.Visible = false;
            // 
            // categoryDropdown
            // 
            this.categoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.categoryDropdown.FormattingEnabled = true;
            this.categoryDropdown.Location = new System.Drawing.Point(6, 33);
            this.categoryDropdown.Name = "categoryDropdown";
            this.categoryDropdown.Size = new System.Drawing.Size(140, 26);
            this.categoryDropdown.TabIndex = 20;
            // 
            // subcategoryDropdown
            // 
            this.subcategoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subcategoryDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.subcategoryDropdown.FormattingEnabled = true;
            this.subcategoryDropdown.Location = new System.Drawing.Point(152, 32);
            this.subcategoryDropdown.Name = "subcategoryDropdown";
            this.subcategoryDropdown.Size = new System.Drawing.Size(140, 26);
            this.subcategoryDropdown.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Κατηγορία / Υποκατηγορία";
            // 
            // searchProjectButton
            // 
            this.searchProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchProjectButton.Location = new System.Drawing.Point(1060, 48);
            this.searchProjectButton.Name = "searchProjectButton";
            this.searchProjectButton.Size = new System.Drawing.Size(120, 31);
            this.searchProjectButton.TabIndex = 25;
            this.searchProjectButton.Text = "Αναζήτηση";
            this.searchProjectButton.UseVisualStyleBackColor = true;
            this.searchProjectButton.Click += new System.EventHandler(this.searchProjectButton_Click);
            // 
            // searchUserButton
            // 
            this.searchUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchUserButton.Location = new System.Drawing.Point(484, 48);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(120, 31);
            this.searchUserButton.TabIndex = 26;
            this.searchUserButton.Text = "Αναζήτηση";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // advancedProjectSearchBox
            // 
            this.advancedProjectSearchBox.AutoSize = true;
            this.advancedProjectSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.advancedProjectSearchBox.Location = new System.Drawing.Point(1059, 100);
            this.advancedProjectSearchBox.Name = "advancedProjectSearchBox";
            this.advancedProjectSearchBox.Size = new System.Drawing.Size(128, 17);
            this.advancedProjectSearchBox.TabIndex = 29;
            this.advancedProjectSearchBox.Text = "Σύνθετη Αναζήτηση";
            this.advancedProjectSearchBox.UseVisualStyleBackColor = true;
            this.advancedProjectSearchBox.CheckedChanged += new System.EventHandler(this.advancedProjectSearchBox_CheckedChanged);
            // 
            // searchProjectBox
            // 
            this.searchProjectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchProjectBox.Location = new System.Drawing.Point(660, 86);
            this.searchProjectBox.Name = "searchProjectBox";
            this.searchProjectBox.Size = new System.Drawing.Size(393, 31);
            this.searchProjectBox.TabIndex = 28;
            // 
            // advancedProjectSearchGroup
            // 
            this.advancedProjectSearchGroup.Controls.Add(this.projectDateAfter);
            this.advancedProjectSearchGroup.Controls.Add(this.label12);
            this.advancedProjectSearchGroup.Controls.Add(this.comboBox1);
            this.advancedProjectSearchGroup.Controls.Add(this.label11);
            this.advancedProjectSearchGroup.Controls.Add(this.projectDateBefore);
            this.advancedProjectSearchGroup.Controls.Add(this.categoryDropdown);
            this.advancedProjectSearchGroup.Controls.Add(this.label9);
            this.advancedProjectSearchGroup.Controls.Add(this.subcategoryDropdown);
            this.advancedProjectSearchGroup.Location = new System.Drawing.Point(660, 123);
            this.advancedProjectSearchGroup.Name = "advancedProjectSearchGroup";
            this.advancedProjectSearchGroup.Size = new System.Drawing.Size(520, 93);
            this.advancedProjectSearchGroup.TabIndex = 30;
            this.advancedProjectSearchGroup.TabStop = false;
            this.advancedProjectSearchGroup.Visible = false;
            // 
            // projectDateAfter
            // 
            this.projectDateAfter.Location = new System.Drawing.Point(225, 64);
            this.projectDateAfter.Name = "projectDateAfter";
            this.projectDateAfter.Size = new System.Drawing.Size(140, 20);
            this.projectDateAfter.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.Location = new System.Drawing.Point(301, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Τεχνολογίες";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(304, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 26);
            this.comboBox1.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Υποβολή";
            // 
            // projectDateBefore
            // 
            this.projectDateBefore.Location = new System.Drawing.Point(79, 65);
            this.projectDateBefore.Name = "projectDateBefore";
            this.projectDateBefore.Size = new System.Drawing.Size(140, 20);
            this.projectDateBefore.TabIndex = 19;
            // 
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AllowUserToResizeRows = false;
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.userTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userTable.Location = new System.Drawing.Point(84, 222);
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.RowHeadersWidth = 62;
            this.userTable.Size = new System.Drawing.Size(520, 357);
            this.userTable.TabIndex = 31;
            this.userTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userTable_CellClick);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // projectTable
            // 
            this.projectTable.AllowUserToAddRows = false;
            this.projectTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.projectTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.projectTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.projectTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.projectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.projectTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.projectTable.Location = new System.Drawing.Point(660, 222);
            this.projectTable.Name = "projectTable";
            this.projectTable.ReadOnly = true;
            this.projectTable.RowHeadersWidth = 62;
            this.projectTable.Size = new System.Drawing.Size(520, 357);
            this.projectTable.TabIndex = 32;
            this.projectTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectTable_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nextUserPage
            // 
            this.nextUserPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextUserPage.Location = new System.Drawing.Point(529, 595);
            this.nextUserPage.Name = "nextUserPage";
            this.nextUserPage.Size = new System.Drawing.Size(75, 23);
            this.nextUserPage.TabIndex = 33;
            this.nextUserPage.Text = ">";
            this.nextUserPage.UseVisualStyleBackColor = true;
            this.nextUserPage.Click += new System.EventHandler(this.nextUserPage_Click);
            // 
            // previousUserPage
            // 
            this.previousUserPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.previousUserPage.Location = new System.Drawing.Point(448, 595);
            this.previousUserPage.Name = "previousUserPage";
            this.previousUserPage.Size = new System.Drawing.Size(75, 23);
            this.previousUserPage.TabIndex = 34;
            this.previousUserPage.Text = "<";
            this.previousUserPage.UseVisualStyleBackColor = true;
            this.previousUserPage.Click += new System.EventHandler(this.previousUserPage_Click);
            // 
            // previousProjectPage
            // 
            this.previousProjectPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.previousProjectPage.Location = new System.Drawing.Point(1031, 595);
            this.previousProjectPage.Name = "previousProjectPage";
            this.previousProjectPage.Size = new System.Drawing.Size(75, 23);
            this.previousProjectPage.TabIndex = 36;
            this.previousProjectPage.Text = "<";
            this.previousProjectPage.UseVisualStyleBackColor = true;
            // 
            // nextProjectPage
            // 
            this.nextProjectPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextProjectPage.Location = new System.Drawing.Point(1112, 595);
            this.nextProjectPage.Name = "nextProjectPage";
            this.nextProjectPage.Size = new System.Drawing.Size(75, 23);
            this.nextProjectPage.TabIndex = 35;
            this.nextProjectPage.Text = ">";
            this.nextProjectPage.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.previousProjectPage);
            this.Controls.Add(this.nextProjectPage);
            this.Controls.Add(this.previousUserPage);
            this.Controls.Add(this.nextUserPage);
            this.Controls.Add(this.projectTable);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.advancedProjectSearchGroup);
            this.Controls.Add(this.advancedProjectSearchBox);
            this.Controls.Add(this.searchProjectBox);
            this.Controls.Add(this.searchUserButton);
            this.Controls.Add(this.searchProjectButton);
            this.Controls.Add(this.advancedSearchGroup);
            this.Controls.Add(this.advancedUserSearchCheckBox);
            this.Controls.Add(this.userFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchUserBox);
            this.Controls.Add(this.devAdvancedSearchGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Κεντρική";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Controls.SetChildIndex(this.devAdvancedSearchGroup, 0);
            this.Controls.SetChildIndex(this.searchUserBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.userFilter, 0);
            this.Controls.SetChildIndex(this.advancedUserSearchCheckBox, 0);
            this.Controls.SetChildIndex(this.advancedSearchGroup, 0);
            this.Controls.SetChildIndex(this.searchProjectButton, 0);
            this.Controls.SetChildIndex(this.searchUserButton, 0);
            this.Controls.SetChildIndex(this.searchProjectBox, 0);
            this.Controls.SetChildIndex(this.advancedProjectSearchBox, 0);
            this.Controls.SetChildIndex(this.advancedProjectSearchGroup, 0);
            this.Controls.SetChildIndex(this.userTable, 0);
            this.Controls.SetChildIndex(this.projectTable, 0);
            this.Controls.SetChildIndex(this.nextUserPage, 0);
            this.Controls.SetChildIndex(this.previousUserPage, 0);
            this.Controls.SetChildIndex(this.nextProjectPage, 0);
            this.Controls.SetChildIndex(this.previousProjectPage, 0);
            this.devAdvancedSearchGroup.ResumeLayout(false);
            this.devAdvancedSearchGroup.PerformLayout();
            this.advancedSearchGroup.ResumeLayout(false);
            this.advancedSearchGroup.PerformLayout();
            this.advancedProjectSearchGroup.ResumeLayout(false);
            this.advancedProjectSearchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchUserBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox userFilter;
        private System.Windows.Forms.TextBox minRating;
        private System.Windows.Forms.GroupBox devAdvancedSearchGroup;
        private System.Windows.Forms.TextBox maxRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateBefore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox advancedUserSearchCheckBox;
        private System.Windows.Forms.DateTimePicker dateAfter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox advancedSearchGroup;
        private System.Windows.Forms.TextBox maxCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox categoryDropdown;
        private System.Windows.Forms.ComboBox subcategoryDropdown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button searchProjectButton;
        private System.Windows.Forms.Button searchUserButton;
        private System.Windows.Forms.CheckBox advancedProjectSearchBox;
        private System.Windows.Forms.TextBox searchProjectBox;
        private System.Windows.Forms.GroupBox advancedProjectSearchGroup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker projectDateBefore;
        private System.Windows.Forms.DateTimePicker projectDateAfter;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridView projectTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button nextUserPage;
        private System.Windows.Forms.Button previousUserPage;
        private System.Windows.Forms.Button previousProjectPage;
        private System.Windows.Forms.Button nextProjectPage;
    }
}