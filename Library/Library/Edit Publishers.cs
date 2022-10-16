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
    public partial class Edit_Publishers : Form
    {
        public Edit_Publishers()
        {
            InitializeComponent();
        }

        private void publishersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.publishersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Edit_Publishers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Book_Publisher' table. You can move, or remove it, as needed.
            this.book_PublisherTableAdapter.Fill(this.libraryDataSet.Book_Publisher);
            // TODO: This line of code loads data into the 'libraryDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.libraryDataSet.Publishers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save changes?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                publishersBindingSource.EndEdit();
                publishersTableAdapter.Update(libraryDataSet);
                book_PublisherTableAdapter.Update(libraryDataSet);
            }
        } 
    }
}
