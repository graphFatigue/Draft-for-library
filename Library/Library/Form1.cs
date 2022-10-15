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
    }
}
