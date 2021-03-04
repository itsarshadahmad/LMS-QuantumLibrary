
namespace LMS_Project
{
    partial class Returnabook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Returnabook));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IssueDate = new System.Windows.Forms.DateTimePicker();
            this.BookCombo = new System.Windows.Forms.TextBox();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ReturnNum = new System.Windows.Forms.TextBox();
            this.StdId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Phonetxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudDept = new System.Windows.Forms.TextBox();
            this.StudName = new System.Windows.Forms.TextBox();
            this.ReturnDGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LMS_Project.Properties.Resources.QL_LMS_ICON;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Cancelbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancelbtn.BackgroundImage")));
            this.Cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelbtn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancelbtn.Image = ((System.Drawing.Image)(resources.GetObject("Cancelbtn.Image")));
            this.Cancelbtn.Location = new System.Drawing.Point(341, 90);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(184, 46);
            this.Cancelbtn.TabIndex = 11;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Returnbtn
            // 
            this.Returnbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Returnbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Returnbtn.BackgroundImage")));
            this.Returnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Returnbtn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returnbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Returnbtn.Image = ((System.Drawing.Image)(resources.GetObject("Returnbtn.Image")));
            this.Returnbtn.Location = new System.Drawing.Point(174, 22);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(184, 46);
            this.Returnbtn.TabIndex = 9;
            this.Returnbtn.Text = "Return";
            this.Returnbtn.UseVisualStyleBackColor = false;
            this.Returnbtn.Click += new System.EventHandler(this.Returnbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Clearbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clearbtn.BackgroundImage")));
            this.Clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clearbtn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Clearbtn.Image = ((System.Drawing.Image)(resources.GetObject("Clearbtn.Image")));
            this.Clearbtn.Location = new System.Drawing.Point(21, 90);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(184, 46);
            this.Clearbtn.TabIndex = 10;
            this.Clearbtn.Text = "Refresh";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 35F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(258, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 57);
            this.label6.TabIndex = 24;
            this.label6.Text = "RETURN A BOOK";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.Cancelbtn);
            this.panel2.Controls.Add(this.Returnbtn);
            this.panel2.Controls.Add(this.Clearbtn);
            this.panel2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(26, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 151);
            this.panel2.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.IssueDate);
            this.panel1.Controls.Add(this.BookCombo);
            this.panel1.Controls.Add(this.ReturnDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ReturnNum);
            this.panel1.Controls.Add(this.StdId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Phonetxtbox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StudDept);
            this.panel1.Controls.Add(this.StudName);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 356);
            this.panel1.TabIndex = 25;
            // 
            // IssueDate
            // 
            this.IssueDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDate.Location = new System.Drawing.Point(185, 265);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(332, 33);
            this.IssueDate.TabIndex = 7;
            // 
            // BookCombo
            // 
            this.BookCombo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCombo.Location = new System.Drawing.Point(184, 223);
            this.BookCombo.Name = "BookCombo";
            this.BookCombo.Size = new System.Drawing.Size(332, 33);
            this.BookCombo.TabIndex = 6;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.Location = new System.Drawing.Point(187, 310);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(332, 33);
            this.ReturnDate.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(19, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "Return Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Issue Num";
            // 
            // ReturnNum
            // 
            this.ReturnNum.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnNum.Location = new System.Drawing.Point(184, 15);
            this.ReturnNum.Name = "ReturnNum";
            this.ReturnNum.Size = new System.Drawing.Size(332, 33);
            this.ReturnNum.TabIndex = 1;
            // 
            // StdId
            // 
            this.StdId.FormattingEnabled = true;
            this.StdId.Location = new System.Drawing.Point(185, 57);
            this.StdId.Name = "StdId";
            this.StdId.Size = new System.Drawing.Size(331, 33);
            this.StdId.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Phone";
            // 
            // Phonetxtbox
            // 
            this.Phonetxtbox.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonetxtbox.Location = new System.Drawing.Point(184, 180);
            this.Phonetxtbox.Name = "Phonetxtbox";
            this.Phonetxtbox.Size = new System.Drawing.Size(332, 33);
            this.Phonetxtbox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(16, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Book Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Issue Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student ID";
            // 
            // StudDept
            // 
            this.StudDept.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudDept.Location = new System.Drawing.Point(185, 139);
            this.StudDept.Name = "StudDept";
            this.StudDept.Size = new System.Drawing.Size(332, 33);
            this.StudDept.TabIndex = 4;
            // 
            // StudName
            // 
            this.StudName.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudName.Location = new System.Drawing.Point(185, 96);
            this.StudName.Name = "StudName";
            this.StudName.Size = new System.Drawing.Size(332, 33);
            this.StudName.TabIndex = 3;
            // 
            // ReturnDGV
            // 
            this.ReturnDGV.BackgroundColor = System.Drawing.Color.White;
            this.ReturnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnDGV.GridColor = System.Drawing.Color.Black;
            this.ReturnDGV.Location = new System.Drawing.Point(589, 95);
            this.ReturnDGV.Name = "ReturnDGV";
            this.ReturnDGV.Size = new System.Drawing.Size(753, 642);
            this.ReturnDGV.TabIndex = 0;
            this.ReturnDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssuedDGV_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 32F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(786, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(403, 52);
            this.label10.TabIndex = 27;
            this.label10.Text = "LIST OF ISSUED BOOKS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::LMS_Project.Properties.Resources.QL;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(227, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(337, 69);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.UseWaitCursor = true;
            // 
            // Returnabook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS_Project.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 749);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ReturnDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Returnabook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantum Library 1.0- Return a Book";
            this.Load += new System.EventHandler(this.Returnabook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Returnbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ReturnNum;
        private System.Windows.Forms.ComboBox StdId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Phonetxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudDept;
        private System.Windows.Forms.TextBox StudName;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ReturnDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BookCombo;
        private System.Windows.Forms.DateTimePicker IssueDate;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}