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
    public partial class Catalog : Form
    {
        LibraryServiceReference.LibraryServiceClient LSC = new LibraryServiceReference.LibraryServiceClient("NetTcpBinding_ILibraryService");
        bool librariesView = false;
        string isbn;
        string login;
        int libraryId;
        public Catalog(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LSC.GetListOfBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (librariesView)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                    libraryId = int.Parse(row.Cells["LibraryId"].Value.ToString());
                    if (LSC.Request(login, isbn, libraryId))
                    {
                        MessageBox.Show("Successful.");
                        this.Close();
                    }
                }
                else
                    if (selectedRowCount > 1)
                    MessageBox.Show("Choose only one library.");
                else
                    MessageBox.Show("Select a library.");
            }
            else
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                    isbn = row.Cells["iSBNDataGridViewTextBoxColumn"].Value.ToString();
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = LSC.BooksInLibraries(isbn);
                    dataGridView1.Refresh();
                    MessageBox.Show("Please choose a library.");
                    librariesView = true;
                }
                else
                    if (selectedRowCount > 1)
                    MessageBox.Show("Too many books selected.");
                else
                    MessageBox.Show("Select a book.");
            }
        }
    }
}
