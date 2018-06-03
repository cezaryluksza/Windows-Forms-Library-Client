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
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gameToolStripMenuItem,
            this.adminMenuToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.katalogToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1761, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // katalogToolStripMenuItem
            // 
            this.katalogToolStripMenuItem.Name = "katalogToolStripMenuItem";
            this.katalogToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.katalogToolStripMenuItem.Text = "Catalog";
            this.katalogToolStripMenuItem.Click += new System.EventHandler(this.katalogToolStripMenuItem_Click);
            // 
            // yourRequestsToolStripMenuItem
            // 
            this.yourRequestsToolStripMenuItem.Name = "yourRequestsToolStripMenuItem";
            this.yourRequestsToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.yourRequestsToolStripMenuItem.Text = "Requests";
            this.yourRequestsToolStripMenuItem.Click += new System.EventHandler(this.yourRequestsToolStripMenuItem_Click);
            // 
            // yourPersonalDataToolStripMenuItem
            // 
            this.yourPersonalDataToolStripMenuItem.Name = "yourPersonalDataToolStripMenuItem";
            this.yourPersonalDataToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.yourPersonalDataToolStripMenuItem.Text = "Personal data";
            this.yourPersonalDataToolStripMenuItem.Click += new System.EventHandler(this.yourPersonalDataToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // adminMenuToolStripMenuItem
            // 
            this.adminMenuToolStripMenuItem.Name = "adminMenuToolStripMenuItem";
            this.adminMenuToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.adminMenuToolStripMenuItem.Text = "Admin panel";
            this.adminMenuToolStripMenuItem.Visible = false;
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.logOutToolStripMenuItem.Text = "Logout";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 855);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ToolStripMenuItem adminMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
    }
}