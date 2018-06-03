using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryClient
{
    public partial class MainForm : Form
    {
        private bool UserIsAdmin = false;
        private string login;
        public MainForm(bool userIsAdmin, string login)
        {
            this.login = login;
            UserIsAdmin = userIsAdmin;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (UserIsAdmin)
            {
                adminMenuToolStripMenuItem.Visible = true;
            }
            //MessageBox.Show("Logged as: " + login);
            
        }

        Catalog catalog;
        private void katalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (catalog == null)
            {
                catalog = new Catalog(login);
                catalog.MdiParent = this;
                catalog.FormClosed += Catalog_FormClosed;
                catalog.Show();
            }
            else
                catalog.Activate();
        }
        private void Catalog_FormClosed(object sender, FormClosedEventArgs e)
        {
            catalog = null;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        RequestsForm requestsForm;
        private void yourRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (requestsForm == null)
            {
                requestsForm = new RequestsForm(login);
                requestsForm.MdiParent = this;
                requestsForm.FormClosed += requestsForm_FormClosed;
                requestsForm.Show();
            }
            else
                requestsForm.Activate();
        }
        private void requestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            requestsForm = null;
        }
        PersonalDataForm personalDataForm;
        private void yourPersonalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (personalDataForm == null)
            {
                personalDataForm = new PersonalDataForm(login);
                personalDataForm.MdiParent = this;
                personalDataForm.FormClosed += personalDataForm_FormClosed;
                personalDataForm.Show();
            }
            else
                personalDataForm.Activate();
        }
        private void personalDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            personalDataForm = null;
        }
    }
}
