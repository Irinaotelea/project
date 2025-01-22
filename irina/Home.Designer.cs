namespace Interfaces
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.registrationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Interfaces.Properties.Resources.SIS;
            this.pictureBoxLogo.Location = new System.Drawing.Point(340, 220);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(780, 380);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenuStrip.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationMenuItem,
            this.deleteStudentMenuItem,
            this.updateDetailsMenuItem,
            this.exitMenuItem,
            this.generateReportMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(265, 140);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(870, 42);
            this.mainMenuStrip.TabIndex = 1;
            // 
            // registrationMenuItem
            // 
            this.registrationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerNewStudentMenuItem});
            this.registrationMenuItem.Name = "registrationMenuItem";
            this.registrationMenuItem.Size = new System.Drawing.Size(172, 38);
            this.registrationMenuItem.Text = "Registration";
            // 
            // registerNewStudentMenuItem
            // 
            this.registerNewStudentMenuItem.Name = "registerNewStudentMenuItem";
            this.registerNewStudentMenuItem.Size = new System.Drawing.Size(366, 38);
            this.registerNewStudentMenuItem.Text = "Register New Student";
            this.registerNewStudentMenuItem.Click += new System.EventHandler(this.RegisterNewStudentMenuItem_Click);
            // 
            // deleteStudentMenuItem
            // 
            this.deleteStudentMenuItem.Name = "deleteStudentMenuItem";
            this.deleteStudentMenuItem.Size = new System.Drawing.Size(208, 38);
            this.deleteStudentMenuItem.Text = "Delete Student";
            this.deleteStudentMenuItem.Click += new System.EventHandler(this.DeleteStudentMenuItem_Click);
            // 
            // updateDetailsMenuItem
            // 
            this.updateDetailsMenuItem.Name = "updateDetailsMenuItem";
            this.updateDetailsMenuItem.Size = new System.Drawing.Size(287, 38);
            this.updateDetailsMenuItem.Text = "Update / Edit Details";
            this.updateDetailsMenuItem.Click += new System.EventHandler(this.UpdateDetailsMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(66, 38);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // generateReportMenuItem
            // 
            this.generateReportMenuItem.Name = "generateReportMenuItem";
            this.generateReportMenuItem.Size = new System.Drawing.Size(181, 38);
            this.generateReportMenuItem.Text = "Get a Report";
            this.generateReportMenuItem.Click += new System.EventHandler(this.GenerateReportMenuItem_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::Interfaces.Properties.Resources.close;
            this.pictureBoxClose.Location = new System.Drawing.Point(1388, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(35, 38);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfaces.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(1423, 725);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem registrationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}
