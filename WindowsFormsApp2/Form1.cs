using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetOrdersList();
        }
        private DataTable GetOrdersList()
        {
            DataTable dtOrders = new DataTable();
            //string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select * from orderview", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtOrders.Load(reader);
                }
            }

                return dtOrders;
        }
        public static class MyGlobal
        {
            public static string User = "";
            public static string Password = "";
            public static string connectionString = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TypeService ts = new TypeService();
            ts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectBuh sb = new SelectBuh();
            sb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal res = 0;
            using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("call PriceSum", con))
                {
                    con.Open();

                    res = (decimal)cmd.ExecuteScalar();
                    MessageBox.Show(Convert.ToString(res),"Прибыль");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateOrdersForm updForm = new UpdateOrdersForm();
            updForm.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            dataGridView1.DataSource = GetOrdersList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            statusForm sF = new statusForm();
            sF.Show();
        }
    }
    /*<connectionStrings>
    <add name = "dbx" connectionString="server=localhost;user id=root;database=forlab" providerName="MySql.Data.MySqlClient"/>
  </connectionStrings>*/
}
