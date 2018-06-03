using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryClient.LibraryServiceReference;

namespace LibraryClient
{
    public partial class LoginForm : Form
    {
        private bool UserIsAdmin = false;
        private int permission = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryServiceReference.LibraryServiceClient LSC = new LibraryServiceReference.LibraryServiceClient("NetTcpBinding_ILibraryService");
            permission = LSC.VerifyLogin(LoginTextBox1.Text, PasswordTextBox1.Text);
            if (permission >= 999)
            {
                UserIsAdmin = true;
                this.Hide();
                var mainForm = new MainForm(UserIsAdmin, LoginTextBox1.Text);
                mainForm.Closed += (s, args) => ClosedForm();
                mainForm.Text = "Library Client (Logged in as " + LoginTextBox1.Text+")";
                mainForm.Show();
            }
            else if (permission >= 1)
            {
                UserIsAdmin = false;
                this.Hide();
                var mainForm = new MainForm(UserIsAdmin, LoginTextBox1.Text);
                mainForm.Closed += (s, args) => ClosedForm();
                mainForm.Text = "Library Client (Logged in as " + LoginTextBox1.Text + ")";
                mainForm.Show();
            }
            else MessageBox.Show("Login or password incorrect!");
        }

        private void PasswordTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        private void ClosedForm()
        {
            LoginTextBox1.Text = "";
            PasswordTextBox1.Text = "";
            this.Show();

        }
    }
}
