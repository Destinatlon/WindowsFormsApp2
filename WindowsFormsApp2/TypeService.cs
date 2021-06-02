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
    public partial class TypeService : Form
    {
        public TypeService()
        {
            InitializeComponent();
        }

        private void TypeService_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=GetService();
        }
        private DataTable GetService()
        {
            DataTable dtServ = new DataTable();

            using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select type_name as 'Услуга'  from type_service", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtServ.Load(reader);
                }
            }

            return dtServ;
        }
    }
}
