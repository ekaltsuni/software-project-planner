﻿namespace SoftwarePlanner
{
    partial class ProjectCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectCreationForm));
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.projectTypeDropdown = new System.Windows.Forms.ComboBox();
            this.projectCategoryDropdown = new System.Windows.Forms.ComboBox();
            this.projectSubcategoryDropdown = new System.Windows.Forms.ComboBox();
            this.projectPaymentDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxPriceBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.projectDurationDropdown = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.biddingDurationBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.technologyBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.titleBox.Location = new System.Drawing.Point(242, 69);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(671, 24);
            this.titleBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(86, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Τίτλος Έργου *";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.descriptionBox.Location = new System.Drawing.Point(89, 166);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(824, 116);
            this.descriptionBox.TabIndex = 3;
            this.descriptionBox.Text = "";
            // 
            // projectTypeDropdown
            // 
            this.projectTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectTypeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.projectTypeDropdown.FormattingEnabled = true;
            this.projectTypeDropdown.Location = new System.Drawing.Point(242, 323);
            this.projectTypeDropdown.Name = "projectTypeDropdown";
            this.projectTypeDropdown.Size = new System.Drawing.Size(200, 26);
            this.projectTypeDropdown.TabIndex = 8;
            // 
            // projectCategoryDropdown
            // 
            this.projectCategoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectCategoryDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.projectCategoryDropdown.FormattingEnabled = true;
            this.projectCategoryDropdown.Location = new System.Drawing.Point(242, 364);
            this.projectCategoryDropdown.Name = "projectCategoryDropdown";
            this.projectCategoryDropdown.Size = new System.Drawing.Size(200, 26);
            this.projectCategoryDropdown.TabIndex = 9;
            this.projectCategoryDropdown.SelectedIndexChanged += new System.EventHandler(this.projectCategoriesDropdown_SelectedIndexChanged);
            // 
            // projectSubcategoryDropdown
            // 
            this.projectSubcategoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectSubcategoryDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.projectSubcategoryDropdown.FormattingEnabled = true;
            this.projectSubcategoryDropdown.Location = new System.Drawing.Point(242, 419);
            this.projectSubcategoryDropdown.Name = "projectSubcategoryDropdown";
            this.projectSubcategoryDropdown.Size = new System.Drawing.Size(200, 26);
            this.projectSubcategoryDropdown.TabIndex = 10;
            // 
            // projectPaymentDropdown
            // 
            this.projectPaymentDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectPaymentDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.projectPaymentDropdown.FormattingEnabled = true;
            this.projectPaymentDropdown.Location = new System.Drawing.Point(242, 474);
            this.projectPaymentDropdown.Name = "projectPaymentDropdown";
            this.projectPaymentDropdown.Size = new System.Drawing.Size(200, 26);
            this.projectPaymentDropdown.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(86, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Περιγραφή *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(86, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Τύπος Έργου *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(86, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Κατηγορία *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(86, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Υποκατηγορία *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(86, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Μορφή Πληρωμής *";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(89, 518);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(200, 13);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "*Υποχρεωτικό Πεδίο";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(557, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Μέγιστη Τιμή";
            // 
            // maxPriceBox
            // 
            this.maxPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maxPriceBox.Location = new System.Drawing.Point(713, 321);
            this.maxPriceBox.Name = "maxPriceBox";
            this.maxPriceBox.Size = new System.Drawing.Size(200, 24);
            this.maxPriceBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(557, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Διάρκεια Έργου";
            // 
            // projectDurationDropdown
            // 
            this.projectDurationDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectDurationDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.projectDurationDropdown.FormattingEnabled = true;
            this.projectDurationDropdown.Location = new System.Drawing.Point(713, 364);
            this.projectDurationDropdown.Name = "projectDurationDropdown";
            this.projectDurationDropdown.Size = new System.Drawing.Size(200, 26);
            this.projectDurationDropdown.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(557, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Διάρκεια Προσφορών";
            // 
            // biddingDurationBox
            // 
            this.biddingDurationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.biddingDurationBox.Location = new System.Drawing.Point(713, 411);
            this.biddingDurationBox.Name = "biddingDurationBox";
            this.biddingDurationBox.Size = new System.Drawing.Size(200, 24);
            this.biddingDurationBox.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label11.Location = new System.Drawing.Point(557, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Προτεινόμενες Τεχνολογίες";
            // 
            // technologyBox
            // 
            this.technologyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.technologyBox.Location = new System.Drawing.Point(560, 507);
            this.technologyBox.Name = "technologyBox";
            this.technologyBox.Size = new System.Drawing.Size(353, 116);
            this.technologyBox.TabIndex = 26;
            this.technologyBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(206)))), ((int)(((byte)(246)))));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.saveButton.Location = new System.Drawing.Point(976, 570);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 53);
            this.saveButton.TabIndex = 36;
            this.saveButton.Text = "Αποθήκευση";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ProjectCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.technologyBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.biddingDurationBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.projectDurationDropdown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxPriceBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.projectPaymentDropdown);
            this.Controls.Add(this.projectSubcategoryDropdown);
            this.Controls.Add(this.projectCategoryDropdown);
            this.Controls.Add(this.projectTypeDropdown);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Δημιουργία Έργου";
            this.Controls.SetChildIndex(this.titleBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.descriptionBox, 0);
            this.Controls.SetChildIndex(this.projectTypeDropdown, 0);
            this.Controls.SetChildIndex(this.projectCategoryDropdown, 0);
            this.Controls.SetChildIndex(this.projectSubcategoryDropdown, 0);
            this.Controls.SetChildIndex(this.projectPaymentDropdown, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.maxPriceBox, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.projectDurationDropdown, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.biddingDurationBox, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.technologyBox, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.ComboBox projectTypeDropdown;
        private System.Windows.Forms.ComboBox projectCategoryDropdown;
        private System.Windows.Forms.ComboBox projectSubcategoryDropdown;
        private System.Windows.Forms.ComboBox projectPaymentDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxPriceBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox projectDurationDropdown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox biddingDurationBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox technologyBox;
        private System.Windows.Forms.Button saveButton;
    }
}