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
    public partial class Edit_Authors : Form
    {
        public Edit_Authors()
        {
            InitializeComponent();
        }

        private void authorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Book_Author' table. You can move, or remove it, as needed.
            this.book_AuthorTableAdapter.Fill(this.libraryDataSet.Book_Author);
            // TODO: This line of code loads data into the 'libraryDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.libraryDataSet.Authors);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save changes?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                authorsBindingSource.EndEdit();
                authorsTableAdapter.Update(libraryDataSet);
                book_AuthorTableAdapter.Update(libraryDataSet);
            }
        }
    }
}
