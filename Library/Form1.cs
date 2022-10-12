using Library.Електронна_бібліотекаDataSetTableAdapters;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "електронна_бібліотекаDataSet.Book_Publisher". При необходимости она может быть перемещена или удалена.
            this.book_PublisherTableAdapter.Fill(this.електронна_бібліотекаDataSet.Book_Publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "електронна_бібліотекаDataSet.Book_Author". При необходимости она может быть перемещена или удалена.
            this.book_AuthorTableAdapter.Fill(this.електронна_бібліотекаDataSet.Book_Author);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "електронна_бібліотекаDataSet.Publishers". При необходимости она может быть перемещена или удалена.
            this.publishersTableAdapter.Fill(this.електронна_бібліотекаDataSet.Publishers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "електронна_бібліотекаDataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.електронна_бібліотекаDataSet.Authors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "електронна_бібліотекаDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.електронна_бібліотекаDataSet.Books);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            book_PublisherTableAdapter.Update(електронна_бібліотекаDataSet);
            book_AuthorTableAdapter.Update(електронна_бібліотекаDataSet);
            publishersTableAdapter.Update(електронна_бібліотекаDataSet);
            authorsTableAdapter.Update(електронна_бібліотекаDataSet);
            booksTableAdapter.Update(електронна_бібліотекаDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                //roomsBindingSource.EndEdit();
                book_PublisherTableAdapter.Update(електронна_бібліотекаDataSet);
                book_AuthorTableAdapter.Update(електронна_бібліотекаDataSet);
                publishersTableAdapter.Update(електронна_бібліотекаDataSet);
                authorsTableAdapter.Update(електронна_бібліотекаDataSet);
                booksTableAdapter.Update(електронна_бібліотекаDataSet);
            }
            
        }
    }
}
