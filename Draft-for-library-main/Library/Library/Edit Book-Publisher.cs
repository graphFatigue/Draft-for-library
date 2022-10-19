using Library.LibraryDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Edit_Book_Publisher : Form
    {
        public Edit_Book_Publisher()
        {
            InitializeComponent();
        }

        private void book_PublisherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.book_PublisherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Edit_Book_Publisher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.libraryDataSet.Publishers);
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
            // TODO: This line of code loads data into the 'libraryDataSet.Book_Publisher' table. You can move, or remove it, as needed.
            this.book_PublisherTableAdapter.Fill(this.libraryDataSet.Book_Publisher);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save changes?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                booksBindingSource.EndEdit();
                booksTableAdapter.Update(libraryDataSet);
                publishersTableAdapter.Update(libraryDataSet);
                book_PublisherTableAdapter.Update(libraryDataSet);
            }
        }
    }
}
