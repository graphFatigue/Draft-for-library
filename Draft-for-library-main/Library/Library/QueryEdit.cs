using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library
{
    public partial class QueryEdit : Form
    {
        public QueryEdit()
        {
            InitializeComponent();
        }

        const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mary\Music\Draft-for-library-main\Library\Library\Library.accdb";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoSQL_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection(ConnectionString);
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter(TestInput.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TestInput.Clear();
            TestInput.Text = "Select";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
