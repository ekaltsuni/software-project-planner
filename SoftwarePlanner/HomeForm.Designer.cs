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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.searchUserBox = new System.Windows.Forms.TextBox();
            this.userTable = new System.Windows.Forms.TableLayoutPanel();
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
            this.projectTable = new System.Windows.Forms.TableLayoutPanel();
            this.advancedProjectSearchBox = new System.Windows.Forms.CheckBox();
            this.searchProjectBox = new System.Windows.Forms.TextBox();
            this.advancedProjectSearchGroup = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.projectDateBefore = new System.Windows.Forms.DateTimePicker();
            this.projectDateAfter = new System.Windows.Forms.DateTimePicker();
            this.devAdvancedSearchGroup.SuspendLayout();
            this.advancedSearchGroup.SuspendLayout();
            this.advancedProjectSearchGroup.SuspendLayout();
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
            // userTable
            // 
            this.userTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.userTable.ColumnCount = 2;
            this.userTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userTable.Location = new System.Drawing.Point(84, 222);
            this.userTable.Name = "userTable";
            this.userTable.RowCount = 10;
            this.userTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.userTable.Size = new System.Drawing.Size(520, 433);
            this.userTable.TabIndex = 2;
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
            // projectTable
            // 
            this.projectTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.projectTable.ColumnCount = 2;
            this.projectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.projectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.projectTable.Location = new System.Drawing.Point(660, 222);
            this.projectTable.Name = "projectTable";
            this.projectTable.RowCount = 10;
            this.projectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.projectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.projectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.projectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.projectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.projectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.projectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.projectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.projectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.projectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.projectTable.Size = new System.Drawing.Size(520, 433);
            this.projectTable.TabIndex = 27;
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
            // projectDateAfter
            // 
            this.projectDateAfter.Location = new System.Drawing.Point(225, 64);
            this.projectDateAfter.Name = "projectDateAfter";
            this.projectDateAfter.Size = new System.Drawing.Size(140, 20);
            this.projectDateAfter.TabIndex = 27;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.advancedProjectSearchGroup);
            this.Controls.Add(this.advancedProjectSearchBox);
            this.Controls.Add(this.searchProjectBox);
            this.Controls.Add(this.projectTable);
            this.Controls.Add(this.searchUserButton);
            this.Controls.Add(this.searchProjectButton);
            this.Controls.Add(this.advancedSearchGroup);
            this.Controls.Add(this.advancedUserSearchCheckBox);
            this.Controls.Add(this.userFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.searchUserBox);
            this.Controls.Add(this.devAdvancedSearchGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Κεντρική";
            this.Controls.SetChildIndex(this.devAdvancedSearchGroup, 0);
            this.Controls.SetChildIndex(this.searchUserBox, 0);
            this.Controls.SetChildIndex(this.userTable, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.userFilter, 0);
            this.Controls.SetChildIndex(this.advancedUserSearchCheckBox, 0);
            this.Controls.SetChildIndex(this.advancedSearchGroup, 0);
            this.Controls.SetChildIndex(this.searchProjectButton, 0);
            this.Controls.SetChildIndex(this.searchUserButton, 0);
            this.Controls.SetChildIndex(this.projectTable, 0);
            this.Controls.SetChildIndex(this.searchProjectBox, 0);
            this.Controls.SetChildIndex(this.advancedProjectSearchBox, 0);
            this.Controls.SetChildIndex(this.advancedProjectSearchGroup, 0);
            this.devAdvancedSearchGroup.ResumeLayout(false);
            this.devAdvancedSearchGroup.PerformLayout();
            this.advancedSearchGroup.ResumeLayout(false);
            this.advancedSearchGroup.PerformLayout();
            this.advancedProjectSearchGroup.ResumeLayout(false);
            this.advancedProjectSearchGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchUserBox;
        private System.Windows.Forms.TableLayoutPanel userTable;
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
        private System.Windows.Forms.TableLayoutPanel projectTable;
        private System.Windows.Forms.CheckBox advancedProjectSearchBox;
        private System.Windows.Forms.TextBox searchProjectBox;
        private System.Windows.Forms.GroupBox advancedProjectSearchGroup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker projectDateBefore;
        private System.Windows.Forms.DateTimePicker projectDateAfter;
    }
}