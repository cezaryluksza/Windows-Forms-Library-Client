namespace LibraryClient
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.katalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourPersonalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.katalogToolStripMenuItem,
            this.yourRequestsToolStripMenuItem,
            this.yourPersonalDataToolStripMenuItem,
            this.adminMenuToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.katalogToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // katalogToolStripMenuItem
            // 
            this.katalogToolStripMenuItem.Name = "katalogToolStripMenuItem";
            this.katalogToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.katalogToolStripMenuItem.Text = "Catalog";
            this.katalogToolStripMenuItem.Click += new System.EventHandler(this.katalogToolStripMenuItem_Click);
            // 
            // yourRequestsToolStripMenuItem
            // 
            this.yourRequestsToolStripMenuItem.Name = "yourRequestsToolStripMenuItem";
            this.yourRequestsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.yourRequestsToolStripMenuItem.Text = "Requests";
            this.yourRequestsToolStripMenuItem.Click += new System.EventHandler(this.yourRequestsToolStripMenuItem_Click);
            // 
            // yourPersonalDataToolStripMenuItem
            // 
            this.yourPersonalDataToolStripMenuItem.Name = "yourPersonalDataToolStripMenuItem";
            this.yourPersonalDataToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.yourPersonalDataToolStripMenuItem.Text = "Personal data";
            this.yourPersonalDataToolStripMenuItem.Click += new System.EventHandler(this.yourPersonalDataToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logOutToolStripMenuItem.Text = "Logout";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // adminMenuToolStripMenuItem
            // 
            this.adminMenuToolStripMenuItem.Name = "adminMenuToolStripMenuItem";
            this.adminMenuToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.adminMenuToolStripMenuItem.Text = "Admin panel";
            this.adminMenuToolStripMenuItem.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 556);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem katalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourPersonalDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuToolStripMenuItem;
    }
}