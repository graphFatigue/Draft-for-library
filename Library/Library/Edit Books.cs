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
    public partial class Edit_Books : Form
    {
        public Edit_Books()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Edit_Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Book_Publisher' table. You can move, or remove it, as needed.
            this.book_PublisherTableAdapter.Fill(this.libraryDataSet.Book_Publisher);
            // TODO: This line of code loads data into the 'libraryDataSet.Book_Author' table. You can move, or remove it, as needed.
            this.book_AuthorTableAdapter.Fill(this.libraryDataSet.Book_Author);
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save changes?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
 {
                booksBindingSource.EndEdit();
                booksTableAdapter.Update(libraryDataSet);
                book_AuthorTableAdapter.Update(libraryDataSet);
                book_PublisherTableAdapter.Update(libraryDataSet);
            }

        }
    }
}
