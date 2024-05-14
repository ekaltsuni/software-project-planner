namespace SoftwarePlanner
{
    partial class ratingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ratingForm));
            this.devLabel = new System.Windows.Forms.Label();
            this.devBox = new System.Windows.Forms.TextBox();
            this.projectBox = new System.Windows.Forms.TextBox();
            this.projectLabel = new System.Windows.Forms.Label();
            this.completionButton = new System.Windows.Forms.Button();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            this.SuspendLayout();
            // 
            // devLabel
            // 
            this.devLabel.AutoSize = true;
            this.devLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.devLabel.Location = new System.Drawing.Point(62, 91);
            this.devLabel.Name = "devLabel";
            this.devLabel.Size = new System.Drawing.Size(126, 25);
            this.devLabel.TabIndex = 0;
            this.devLabel.Text = "Developer:";
            // 
            // devBox
            // 
            this.devBox.Enabled = false;
            this.devBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.devBox.Location = new System.Drawing.Point(203, 88);
            this.devBox.Name = "devBox";
            this.devBox.ReadOnly = true;
            this.devBox.Size = new System.Drawing.Size(499, 31);
            this.devBox.TabIndex = 1;
            // 
            // projectBox
            // 
            this.projectBox.Enabled = false;
            this.projectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.projectBox.Location = new System.Drawing.Point(203, 18);
            this.projectBox.Name = "projectBox";
            this.projectBox.ReadOnly = true;
            this.projectBox.Size = new System.Drawing.Size(499, 31);
            this.projectBox.TabIndex = 3;
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.projectLabel.Location = new System.Drawing.Point(62, 21);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(93, 25);
            this.projectLabel.TabIndex = 2;
            this.projectLabel.Text = "Project:";
            // 
            // completionButton
            // 
            this.completionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.completionButton.Location = new System.Drawing.Point(494, 377);
            this.completionButton.Name = "completionButton";
            this.completionButton.Size = new System.Drawing.Size(208, 38);
            this.completionButton.TabIndex = 4;
            this.completionButton.Text = "Ολοκλήρωση Έργου";
            this.completionButton.UseVisualStyleBackColor = true;
            this.completionButton.Click += new System.EventHandler(this.completionButton_Click);
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(67, 198);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(635, 68);
            this.commentBox.TabIndex = 5;
            this.commentBox.Text = "";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.commentLabel.Location = new System.Drawing.Point(66, 154);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(89, 25);
            this.commentLabel.TabIndex = 6;
            this.commentLabel.Text = "Κριτική";
            // 
            // star1
            // 
            this.star1.Image = ((System.Drawing.Image)(resources.GetObject("star1.Image")));
            this.star1.Location = new System.Drawing.Point(67, 285);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(65, 59);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star1.TabIndex = 7;
            this.star1.TabStop = false;
            this.star1.Click += new System.EventHandler(this.star1_Click);
            // 
            // star5
            // 
            this.star5.Image = ((System.Drawing.Image)(resources.GetObject("star5.Image")));
            this.star5.Location = new System.Drawing.Point(351, 285);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(65, 59);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star5.TabIndex = 8;
            this.star5.TabStop = false;
            this.star5.Click += new System.EventHandler(this.star5_Click);
            // 
            // star4
            // 
            this.star4.Image = ((System.Drawing.Image)(resources.GetObject("star4.Image")));
            this.star4.Location = new System.Drawing.Point(280, 285);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(65, 59);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star4.TabIndex = 9;
            this.star4.TabStop = false;
            this.star4.Click += new System.EventHandler(this.star4_Click);
            // 
            // star3
            // 
            this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
            this.star3.Location = new System.Drawing.Point(209, 285);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(65, 59);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star3.TabIndex = 10;
            this.star3.TabStop = false;
            this.star3.Click += new System.EventHandler(this.star3_Click);
            // 
            // star2
            // 
            this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
            this.star2.Location = new System.Drawing.Point(138, 285);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(65, 59);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star2.TabIndex = 11;
            this.star2.TabStop = false;
            this.star2.Click += new System.EventHandler(this.star2_Click);
            // 
            // ratingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.completionButton);
            this.Controls.Add(this.projectBox);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.devBox);
            this.Controls.Add(this.devLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ratingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Κριτική";
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label devLabel;
        private System.Windows.Forms.TextBox devBox;
        private System.Windows.Forms.TextBox projectBox;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Button completionButton;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star2;
    }
}