using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Form1;

namespace WindowsFormsApp2
{
    public partial class UpdateOrdersForm : Form
    {
        public UpdateOrdersForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (check()!=true)
            {
                return;
            }
            string DATE;
            if (checkBox1.Checked == false)
            {
                DATE = "'"+GetDate()+"'";
            }
            else
            {
                DATE = "CURRENT_DATE";
            }
            if (clientBox.Text == providerBox.Text)
            {
                MessageBox.Show("Ваш клиент не может быть еще и вашим поставщиком");
                return;
            }
            string address = $"{type_streetBox.Text} {textBox2.Text} {textBox3.Text}";
            string query = $"insert into orders values({textBox1.Text},{typeBox.SelectedValue},'{address}',{DATE},{employeeBox.SelectedValue},{clientBox.SelectedValue},{providerBox.SelectedValue},{Convert.ToDecimal(priceBox.Text)},'{etcBox.Text}')";//zamenit insert

            try
            {
                using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Вы добавили заказ");
                    }
                }
                ClearAll();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Не верно введенны данные");
            }
            UpdBox();
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

        private void UpdateOrdersForm_Load(object sender, EventArgs e)
        {
            UpdBox();
        }
        private void GetList(string table,string col,string col1,ComboBox a)
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
            Dictionary<int, string> dict = new Dictionary<int, string>();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                //a.Items.Add(tb.Rows[i][$"{col}"]);
                 dict.Add((int)tb.Rows[i][$"{col1}"], (string)tb.Rows[i][$"{col}"]);
            }
            a.DisplayMember = "Value";
            a.ValueMember = "Key";
            a.DataSource = dict.ToArray();
        }
        private void UpdBox()
        {
            GetList("type_service", "type_name","id_service", typeBox);
            GetList("legalview", "title","id", clientBox);
            GetList("privateview", "surname", "id", clientBox);
            GetList("legalview", "title", "id", providerBox);
            GetList("privateview", "surname", "id", providerBox);
            GetList("employee", "surname","id_employee", employeeBox);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (check()!=true)
            {
                return;
            }
            string DATE;
            if (checkBox1.Checked == false)
            {
                DATE = "'" + GetDate() + "'";
            }
            else
            {
                DATE = "CURRENT_DATE";
            }
            if (clientBox.Text == providerBox.Text)
            {
                MessageBox.Show("Ваш клиент не может быть еще и вашим поставщиком");
                return;
            }
            string address = $"{type_streetBox.Text} {textBox2.Text} {textBox3.Text}";
            string query = $"update orders set type_service={typeBox.SelectedValue},address='{address}',start_date={DATE},employee={employeeBox.SelectedValue},client={clientBox.SelectedValue},provider={providerBox.SelectedValue},price={priceBox.Text},etc='{etcBox.Text}' where id_order={textBox1.Text}";//zamenit update
            try
            {
                using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Вы обновили данные о заказе");
                        
                    }
                }
                ClearAll();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Данные обновить не удалось");
            }
            UpdBox();
        }
        private bool check()
        {
            bool result = true;
            string attention = "Неверно введен(введенны) следующие поля:";
            if (Validation.IsCurillic(textBox2.Text) != true)
            {
                result = false;
                attention += "\nНазвание улицы";
            }
            if (Validation.IsStreetNumber(textBox3.Text)!=true)
            {
                result = false;
                attention += "\nНомер улицы";
            }
            decimal a;
            if (Decimal.TryParse(priceBox.Text,out a)!=true)
            {
                result = false;
                attention += "\nЦена";
            }
            if (result == false)
                MessageBox.Show(attention);
            return result;

        }
        private void ClearAll()
        {
            textBox1.Text = textBox2.Text =textBox3.Text= priceBox.Text = "";
            typeBox.Text="";
            employeeBox.Text="";
            providerBox.Text="";
            clientBox.Text="";
            typeBox.Text="";
            employeeBox.Text="";
            providerBox.Text="";
            clientBox.Text="";
            type_streetBox.Text ="";
        }
    }
}
    
