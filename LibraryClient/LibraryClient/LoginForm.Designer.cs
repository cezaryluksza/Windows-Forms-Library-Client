namespace LibraryClient
{
    partial class LoginForm
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
            this.LoginPanel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.Timer(this.components);
            this.LoginPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel1
            // 
            this.LoginPanel1.Controls.Add(this.button1);
            this.LoginPanel1.Controls.Add(this.PasswordTextBox1);
            this.LoginPanel1.Controls.Add(this.label2);
            this.LoginPanel1.Controls.Add(this.LoginTextBox1);
            this.LoginPanel1.Controls.Add(this.label1);
            this.LoginPanel1.Location = new System.Drawing.Point(484, 199);
            this.LoginPanel1.Name = "LoginPanel1";
            this.LoginPanel1.Size = new System.Drawing.Size(236, 180);
            this.LoginPanel1.TabIndex = 0;
            this.LoginPanel1.Tag = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.Location = new System.Drawing.Point(74, 67);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.PasswordChar = '*';
            this.PasswordTextBox1.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox1.TabIndex = 3;
            this.PasswordTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // LoginTextBox1
            // 
            this.LoginTextBox1.Location = new System.Drawing.Point(74, 32);
            this.LoginTextBox1.Name = "LoginTextBox1";
            this.LoginTextBox1.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LibraryClient.Properties.Resources.the_most_beautiful_library_in_every_us_state;
            this.ClientSize = new System.Drawing.Size(1174, 556);
            this.Controls.Add(this.LoginPanel1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Client";
            this.LoginPanel1.ResumeLayout(false);
            this.LoginPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Interval;
    }
}

