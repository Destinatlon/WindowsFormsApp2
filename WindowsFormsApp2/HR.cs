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
    public partial class HR : Form
    {
        public HR()
        {
            InitializeComponent();
        }
        private DataTable GetList(string table)
        {
            DataTable dt = new DataTable();
            string query="";
            switch (table)
            {
                case "Legal":
                    query = "select counter_party.id,title,tax_number,vat_number,phone,mail from counter_legal left join counter_party on counter_party.id=counter_legal.id";
                    break;
                case "Private":
                    query = "select counter_party.id,name,surname,second_name,reg_number,phone,mail from counter_private left join counter_party on counter_party.id=counter_private.id";
                    break;
                case "Employee":
                    query = "select * from employee";
                    break;
            }
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


        private void HR_Load(object sender, EventArgs e)
        {
            
        }

        private void Legal_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetList("Legal");
        }

        private void Private_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetList("Private");
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetList("Employee");
        }

        private void HR_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            HRAction upd = new HRAction();
            upd.Show();
        }
    }
}
