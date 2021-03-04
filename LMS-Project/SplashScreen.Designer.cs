
namespace LMS_Project
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.SplashLogo = new System.Windows.Forms.PictureBox();
            this.LoadingPanel1 = new System.Windows.Forms.Panel();
            this.LoadingPanel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SplashCommunity = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SplashTagLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplashLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashLogo
            // 
            this.SplashLogo.BackColor = System.Drawing.Color.Transparent;
            this.SplashLogo.BackgroundImage = global::LMS_Project.Properties.Resources.LMS_Small;
            this.SplashLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SplashLogo.Location = new System.Drawing.Point(33, 34);
            this.SplashLogo.Name = "SplashLogo";
            this.SplashLogo.Size = new System.Drawing.Size(244, 149);
            this.SplashLogo.TabIndex = 0;
            this.SplashLogo.TabStop = false;
            this.SplashLogo.UseWaitCursor = true;
            // 
            // LoadingPanel1
            // 
            this.LoadingPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoadingPanel1.Location = new System.Drawing.Point(0, 490);
            this.LoadingPanel1.Name = "LoadingPanel1";
            this.LoadingPanel1.Size = new System.Drawing.Size(904, 10);
            this.LoadingPanel1.TabIndex = 2;
            this.LoadingPanel1.UseWaitCursor = true;
            this.LoadingPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.LoadingPanel1_Paint);
            // 
            // LoadingPanel2
            // 
            this.LoadingPanel2.BackColor = System.Drawing.Color.White;
            this.LoadingPanel2.Location = new System.Drawing.Point(-1, 489);
            this.LoadingPanel2.Name = "LoadingPanel2";
            this.LoadingPanel2.Size = new System.Drawing.Size(33, 12);
            this.LoadingPanel2.TabIndex = 3;
            this.LoadingPanel2.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BackgroundImage = global::LMS_Project.Properties.Resources.QL_LMS_ICON;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(4, 367);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 116);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // SplashCommunity
            // 
            this.SplashCommunity.AutoSize = true;
            this.SplashCommunity.BackColor = System.Drawing.Color.Transparent;
            this.SplashCommunity.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashCommunity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SplashCommunity.Location = new System.Drawing.Point(808, 386);
            this.SplashCommunity.Name = "SplashCommunity";
            this.SplashCommunity.Size = new System.Drawing.Size(86, 22);
            this.SplashCommunity.TabIndex = 5;
            this.SplashCommunity.Text = "Secured with";
            this.SplashCommunity.UseWaitCursor = true;
            this.SplashCommunity.Click += new System.EventHandler(this.SplashCommunity_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashTagLine
            // 
            this.SplashTagLine.AutoSize = true;
            this.SplashTagLine.BackColor = System.Drawing.Color.Transparent;
            this.SplashTagLine.Font = new System.Drawing.Font("Fugaz One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashTagLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SplashTagLine.Location = new System.Drawing.Point(657, 141);
            this.SplashTagLine.Name = "SplashTagLine";
            this.SplashTagLine.Size = new System.Drawing.Size(223, 17);
            this.SplashTagLine.TabIndex = 6;
            this.SplashTagLine.Text = "Library Management System Software";
            this.SplashTagLine.UseWaitCursor = true;
            this.SplashTagLine.Click += new System.EventHandler(this.SplashTagLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Version 1.0";
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LMS_Project.Properties.Resources.QL;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(292, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 91);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::LMS_Project.Properties.Resources.Mcafee;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(806, 411);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 77);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Fugaz One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(767, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Community Feb , 2021";
            this.label2.UseWaitCursor = true;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS_Project.Properties.Resources.redbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadingPanel2);
            this.Controls.Add(this.SplashTagLine);
            this.Controls.Add(this.SplashCommunity);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoadingPanel1);
            this.Controls.Add(this.SplashLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashLogo;
        private System.Windows.Forms.Panel LoadingPanel1;
        private System.Windows.Forms.Panel LoadingPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label SplashCommunity;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label SplashTagLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}

