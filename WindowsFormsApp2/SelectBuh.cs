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
    public partial class SelectBuh : Form
    {
        public SelectBuh()
        {
            InitializeComponent();
        }

        private void SelectBuh_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetInfo("legal");
            dataGridView2.DataSource = GetInfo("private");
        }
        private DataTable GetInfo(string table) 
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"Select * from {table}view", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);
                }
            }
            return dt;
        }
    }
}
