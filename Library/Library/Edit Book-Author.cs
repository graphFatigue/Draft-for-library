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
    public partial class Edit_Book_Author : Form
    {
        public Edit_Book_Author()
        {
            InitializeComponent();
        }

        private void book_AuthorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.book_AuthorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Edit_Book_Author_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.libraryDataSet.Authors);
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
            // TODO: This line of code loads data into the 'libraryDataSet.Book_Author' table. You can move, or remove it, as needed.
            this.book_AuthorTableAdapter.Fill(this.libraryDataSet.Book_Author);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save changes?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                book_AuthorBindingSource.EndEdit();
                booksTableAdapter.Update(libraryDataSet);
                authorsTableAdapter.Update(libraryDataSet);
                book_AuthorTableAdapter.Update(libraryDataSet);
            }
        }
    }
}
