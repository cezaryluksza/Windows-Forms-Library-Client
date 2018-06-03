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
    public partial class RequestsForm : Form
    {
        LibraryServiceReference.LibraryServiceClient LSC = new LibraryServiceReference.LibraryServiceClient("NetTcpBinding_ILibraryService");
        string login;
        public RequestsForm(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LSC.ShowRequests(login);
        }
    }
}
