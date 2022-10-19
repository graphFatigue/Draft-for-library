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
    public partial class EditFormAuthors : Form
    {

        /// <summary>
        /// Id студента
        /// </summary>
        private readonly int author_id;
        /// <summary>
        /// true - если запись модифицируется, false - если создаётся новая
        /// </summary>
        readonly bool edit;
        /// <summary>
        /// конструктор формы, для создания новой записи
        /// </summary>
        public EditFormAuthors()
        {
            InitializeComponent();
            authorsTableAdapter1.Fill(libraryDataSet.Authors);
            // benefitsTableAdapter.Fill(hostelDataSet.Benefits);
            edit = false;
        }


        /// <summary>
        /// конструктор формы, для модификации уже существующей записи
        /// </summary>
        /// <param name="name">ФИО</param>
        /// <param name="surname">Дата заселения</param>
        /// <param name="patronymic">Пол</param>
        /// <param name="dateOfBirth">Адрес</param>
        /// <param name="dateOfDeath">Группа</param>
        /// <param name="nationality">Тип льготы</param>
        /// <param name="gender">Паспорт</param>
        /// <param name="author_id">ID студента</param>
        public EditFormAuthors(int author_id, String name, string surname, string patronymic, DateTime dateOfBirth, DateTime dateOfDeath,
       string nationality, string gender)
        : this()
        {
            authorsTableAdapter1.Fill(libraryDataSet.Authors);
           // benefitsTableAdapter.Fill(hostelDataSet.Benefits);
            edit = true;
            this.author_id = author_id;
            textBox_Name.Text = name;
            textBox_Surname.Text = surname;
            textBox_Patronymic.Text = patronymic;
            dateTimePicker_DateOfBirth.Value = dateOfBirth;
            dateTimePicker_DateOfDeath.Value = dateOfDeath;
            textBox_Nationality.Text = nationality;
            switch (gender.ToUpper())
            {
                case "Male":
                    comboBox_Gender.SelectedIndex = 0;
                    break;
                case "Female":
                    comboBox_Gender.SelectedIndex = 1;
                    break;
                default:
                    comboBox_Gender.SelectedIndex = 0;
                    break;
            }
        }



        private void EditFormAuthors_Load(object sender, EventArgs e)
        {

        }

        private void button_OK_Click_1(object sender, EventArgs e)
        {
            string gender = "";
            if (comboBox_Gender.SelectedIndex == 0)
            {
                gender = "Male";
            }
            else if (comboBox_Gender.SelectedIndex == 1)
            {
                gender = "Female";
            }
            if (edit)
            {
                authorsTableAdapter1.UpdateQuery(textBox_Name.Text, textBox_Surname.Text, textBox_Patronymic.Text, dateTimePicker_DateOfBirth.Value,
                    dateTimePicker_DateOfDeath.Value, textBox_Nationality.Text, gender, 
               author_id) ;
            }
            else
            {
                authorsTableAdapter1.Insert(textBox_Name.Text, textBox_Surname.Text, textBox_Patronymic.Text, dateTimePicker_DateOfBirth.Value,
                    dateTimePicker_DateOfDeath.Value, textBox_Nationality.Text, gender);
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
