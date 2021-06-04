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
using System.IO;

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
                    MessageBox.Show(Convert.ToString(res+" грн"),"Прибыль");
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

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetOrdersList();
            writeCSV(dataGridView1);
        }
        private void writeCSV(DataGridView gridIn)
        {
            if (gridIn.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Невозможно записать данные." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = gridIn.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[gridIn.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += gridIn.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < gridIn.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += gridIn.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Данные записаны успешно !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет записей для записи !!!", "Info");
            }
        }
    }
    /*<connectionStrings>
    <add name = "dbx" connectionString="server=localhost;user id=root;database=forlab" providerName="MySql.Data.MySqlClient"/>
  </connectionStrings>*/
}
