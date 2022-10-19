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
        public partial class EditForm : Form
        {
            /// <summary>
            /// Id студента
            /// </summary>
            private readonly int relation_id;
            /// <summary>
            /// true - если запись модифицируется, false - если создаётся новая
            /// </summary>
            readonly bool edit;
            /// <summary>
            /// конструктор формы, для создания новой записи
            /// </summary>
            public EditForm()
            {
                InitializeComponent();
                booksTableAdapter.Fill(libraryDataSet.Books);
                authorsTableAdapter.Fill(libraryDataSet.Authors);
                edit = false;
            }
        /// <summary>
        /// конструктор формы, для модификации уже существующей записи
        /// </summary>
        /// <param name="book_id">Тип льготы</param>
        /// <param name="author_id">Номер комнаты</param>
        /// <param name="relation_id">ID связи</param>
        public EditForm(int relation_id, 
           int book_id, int author_id)
            : this()
            {
                booksTableAdapter.Fill(libraryDataSet.Books);
                authorsTableAdapter.Fill(libraryDataSet.Authors);
                edit = true;
                this.relation_id = relation_id;
                comboBox_Book_id.SelectedValue = book_id;
                comboBox_Author_id.SelectedValue = author_id;
            }        
            private void button_OK_Click_1(object sender, EventArgs e)
            {

                if (edit)
                {
                    book_AuthorTableAdapter1.UpdateQuery( Convert.ToInt32(comboBox_Book_id.SelectedValue),
                   Convert.ToInt32(comboBox_Author_id.SelectedValue),relation_id);
                }
                else
                {
                    book_AuthorTableAdapter1.Insert(Convert.ToInt32(comboBox_Book_id.SelectedValue),
                   Convert.ToInt32(comboBox_Author_id.SelectedValue));
                }
                Close();
            }
            private void button_Cancel_Click_1(object sender, EventArgs e)
                    {
                        Close();
                    }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_Author_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

