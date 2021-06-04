using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        

        public void writeCSV(DataGridView gridIn)
        {
            if (gridIn.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV UTF-8(разделитель - запятая)(*.csv)|*.csv";
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
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = gridIn.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[gridIn.Rows.Count + 2];
                            outputCsv[0] += "sep=,";
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += gridIn.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[1] += columnNames;

                            for (int i = 1; (i-1) < gridIn.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i+1] += gridIn.Rows[i-1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
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
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        /*private void writeCSV(DataGridView gridIn)
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
        }*/
        private void legalCSV_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetList("Legal");
            writeCSV(dataGridView1);
        }
        private void privateCSV_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetList("Private");
            writeCSV(dataGridView1);
        }

        private void employeeCSV_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetList("Employee");
            writeCSV(dataGridView1);
        }
    }
}
