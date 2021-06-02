using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Form1;

namespace WindowsFormsApp2
{
    public partial class statusForm : Form
    {
        public statusForm()
        {
            InitializeComponent();
        }

        private void statusForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetStatus() ;
            GetCombo("orders","id_order",comboBox1);
        }
        private DataTable GetStatus()
        {
            DataTable dt = new DataTable();
            string query = "select id_order as 'Заказ',status as 'Статус',date as 'Дата' from status_date";
            using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);
                }
            }

            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DATE = GetDate();
            string query = $"insert into status_date(id_order,status,date) values({comboBox1.Text},'{comboBox2.Text}','{DATE}')";
            try
            {
                using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                    }
                }
                dataGridView1.DataSource = GetStatus();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private string GetDate()
        {
            string m = "0";
            string dat;
            if (dateTimePicker1.Value.Month < 10)
            {
                m += dateTimePicker1.Value.Month.ToString();
                dat = Convert.ToString(dateTimePicker1.Value.Year) + "-" + m + "-" + Convert.ToString(dateTimePicker1.Value.Day);
            }
            else
            {
                dat = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
            }
            return dat;
        }
        private void GetCombo(string table,string col, ComboBox a)
        {
            string query = $"select * from {table}";
            DataTable tb = new DataTable();
            using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    tb.Load(reader);
                }
            }
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                a.Items.Add(tb.Rows[i][$"{col}"]);
            }
        }
        private void statusForm_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetStatus();
        }
    }
}
