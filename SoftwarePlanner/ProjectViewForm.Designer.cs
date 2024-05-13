namespace SoftwarePlanner
{
    partial class ProjectViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectViewForm));
            this.projectInfoGrid = new System.Windows.Forms.DataGridView();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerGrid = new System.Windows.Forms.DataGridView();
            this.Offer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Developer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.offerButton = new System.Windows.Forms.Button();
            this.commentGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.commentButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projectInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // projectInfoGrid
            // 
            this.projectInfoGrid.AllowUserToAddRows = false;
            this.projectInfoGrid.AllowUserToResizeRows = false;
            this.projectInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectInfoGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.projectInfoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectInfoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.projectInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Info,
            this.Value});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectInfoGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.projectInfoGrid.Location = new System.Drawing.Point(60, 109);
            this.projectInfoGrid.Name = "projectInfoGrid";
            this.projectInfoGrid.ShowEditingIcon = false;
            this.projectInfoGrid.Size = new System.Drawing.Size(429, 278);
            this.projectInfoGrid.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // offerGrid
            // 
            this.offerGrid.AllowUserToAddRows = false;
            this.offerGrid.AllowUserToDeleteRows = false;
            this.offerGrid.AllowUserToResizeRows = false;
            this.offerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.offerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Offer,
            this.Developer,
            this.Date});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.offerGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.offerGrid.Location = new System.Drawing.Point(50, 42);
            this.offerGrid.Name = "offerGrid";
            this.offerGrid.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.offerGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.offerGrid.ShowEditingIcon = false;
            this.offerGrid.Size = new System.Drawing.Size(655, 207);
            this.offerGrid.TabIndex = 1;
            this.offerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.offerGrid_CellClick);
            // 
            // Offer
            // 
            this.Offer.HeaderText = "Προσφορά";
            this.Offer.Name = "Offer";
            this.Offer.ReadOnly = true;
            // 
            // Developer
            // 
            this.Developer.HeaderText = "Developer";
            this.Developer.Name = "Developer";
            this.Developer.ReadOnly = true;
            // 
            // recommendationButton
            // 
            this.recommendationButton.Location = new System.Drawing.Point(60, 448);
            this.recommendationButton.Name = "recommendationButton";
            this.recommendationButton.Size = new System.Drawing.Size(429, 49);
            this.recommendationButton.TabIndex = 4;
            this.recommendationButton.Text = "Πρόταση Έργου";
            this.recommendationButton.UseVisualStyleBackColor = true;
            this.recommendationButton.Click += new System.EventHandler(this.recommendationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(523, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Προβολή Έργου";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.offerGrid);
            this.groupBox1.Location = new System.Drawing.Point(528, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 278);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Προσφορές";
            // 
            // offerButton
            // 
            this.offerButton.Location = new System.Drawing.Point(60, 393);
            this.offerButton.Name = "offerButton";
            this.offerButton.Size = new System.Drawing.Size(429, 49);
            this.offerButton.TabIndex = 8;
            this.offerButton.Text = "Προσφορά";
            this.offerButton.UseVisualStyleBackColor = true;
            this.offerButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // commentGrid
            // 
            this.commentGrid.AllowUserToAddRows = false;
            this.commentGrid.AllowUserToDeleteRows = false;
            this.commentGrid.AllowUserToResizeRows = false;
            this.commentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.commentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.user});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commentGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.commentGrid.Location = new System.Drawing.Point(528, 393);
            this.commentGrid.Name = "commentGrid";
            this.commentGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.commentGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.commentGrid.ShowEditingIcon = false;
            this.commentGrid.Size = new System.Drawing.Size(724, 175);
            this.commentGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Σχόλιο";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // user
            // 
            this.user.HeaderText = "Χρήστης";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(528, 578);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(542, 49);
            this.commentBox.TabIndex = 9;
            this.commentBox.Text = "";
            // 
            // commentButton
            // 
            this.commentButton.Location = new System.Drawing.Point(1076, 578);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(176, 49);
            this.commentButton.TabIndex = 10;
            this.commentButton.Text = "Υποβολή";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(60, 574);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 53);
            this.deleteButton.TabIndex = 53;
            this.deleteButton.Text = "Διαγραφή";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Date
            // 
            this.Date.HeaderText = "Ημερομηνία";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ProjectViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.commentGrid);
            this.Controls.Add(this.offerButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recommendationButton);
            this.Controls.Add(this.projectInfoGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Έργο";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectViewForm_FormClosing);
            this.Controls.SetChildIndex(this.projectInfoGrid, 0);
            this.Controls.SetChildIndex(this.recommendationButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.offerButton, 0);
            this.Controls.SetChildIndex(this.commentGrid, 0);
            this.Controls.SetChildIndex(this.commentBox, 0);
            this.Controls.SetChildIndex(this.commentButton, 0);
            this.Controls.SetChildIndex(this.deleteButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.projectInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView projectInfoGrid;
        private System.Windows.Forms.DataGridView offerGrid;
        private System.Windows.Forms.Button recommendationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button offerButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Developer;
        private System.Windows.Forms.DataGridView commentGrid;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}