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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Book_Publisher' table. You can move, or remove it, as needed.
            this.book_PublisherTableAdapter.Fill(this.libraryDataSet.Book_Publisher);
            // TODO: This line of code loads data into the 'libraryDataSet.Book_Author' table. You can move, or remove it, as needed.
            this.book_AuthorTableAdapter.Fill(this.libraryDataSet.Book_Author);
            // TODO: This line of code loads data into the 'libraryDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.libraryDataSet.Publishers);
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
            // TODO: This line of code loads data into the 'libraryDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.libraryDataSet.Authors);
            dataGridView1.AutoGenerateColumns = true;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool edit;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            authorsTableAdapter.Update(libraryDataSet);
            booksTableAdapter.Update(libraryDataSet);
            publishersTableAdapter.Update(libraryDataSet);
            book_AuthorTableAdapter.Update(libraryDataSet);
            book_PublisherTableAdapter.Update(libraryDataSet);
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = authorsBindingSource;
            dataGridView1.DataSource = authorsBindingSource;
            label1.Text = "Authors";

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = booksBindingSource;
            dataGridView1.DataSource = booksBindingSource;
            label1.Text = "Books";
        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = publishersBindingSource;
            dataGridView1.DataSource = publishersBindingSource;
            label1.Text = "Publishers";
        }

        private void bookAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = bookAuthorBindingSource;
            dataGridView1.DataSource = bookAuthorBindingSource;
            label1.Text = "Book-Author";
        }

        private void bookPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = bookPublisherBindingSource;
            dataGridView1.DataSource = bookPublisherBindingSource;
            label1.Text = "Book-Publisher";
        }

        private void editBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Edit_Books();
            rs.ShowDialog();
            booksTableAdapter.Fill(libraryDataSet.Books);
            authorsTableAdapter.Fill(libraryDataSet.Authors);
            publishersTableAdapter.Fill(libraryDataSet.Publishers);
            book_AuthorTableAdapter.Fill(libraryDataSet.Book_Author);
            book_PublisherTableAdapter.Fill(libraryDataSet.Book_Publisher);
        }

        private void editAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Edit_Authors();
            rs.ShowDialog();
            booksTableAdapter.Fill(libraryDataSet.Books);
            authorsTableAdapter.Fill(libraryDataSet.Authors);
            publishersTableAdapter.Fill(libraryDataSet.Publishers);
            book_AuthorTableAdapter.Fill(libraryDataSet.Book_Author);
            book_PublisherTableAdapter.Fill(libraryDataSet.Book_Publisher);
        }

        private void editPublishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Edit_Publishers();
            rs.ShowDialog();
            booksTableAdapter.Fill(libraryDataSet.Books);
            authorsTableAdapter.Fill(libraryDataSet.Authors);
            publishersTableAdapter.Fill(libraryDataSet.Publishers);
            book_AuthorTableAdapter.Fill(libraryDataSet.Book_Author);
            book_PublisherTableAdapter.Fill(libraryDataSet.Book_Publisher);
        }

        private void editBookAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Edit_Book_Author();
            rs.ShowDialog();
            booksTableAdapter.Fill(libraryDataSet.Books);
            authorsTableAdapter.Fill(libraryDataSet.Authors);
            publishersTableAdapter.Fill(libraryDataSet.Publishers);
            book_AuthorTableAdapter.Fill(libraryDataSet.Book_Author);
            book_PublisherTableAdapter.Fill(libraryDataSet.Book_Publisher);
        }

        private void editBookPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Edit_Book_Publisher();
            rs.ShowDialog();
            booksTableAdapter.Fill(libraryDataSet.Books);
            authorsTableAdapter.Fill(libraryDataSet.Authors);
            publishersTableAdapter.Fill(libraryDataSet.Publishers);
            book_AuthorTableAdapter.Fill(libraryDataSet.Book_Author);
            book_PublisherTableAdapter.Fill(libraryDataSet.Book_Publisher);
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edit) return;
            var st = new LibraryDataSet.Book_AuthorDataTable();
            var m = dataGridView1.SelectedCells[0].Value;
            book_AuthorTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new EditForm(
            Convert.ToInt32(row[0]),
            Convert.ToInt32(row[1]),
            Convert.ToInt32(row[2]));
            edt.ShowDialog();
            //add if else statement cause when u r adding a new record, u have -1 relation_id and no other
            book_AuthorTableAdapter.Fill(libraryDataSet.Book_Author);
            libraryDataSet.AcceptChanges();

        }

    }
}
