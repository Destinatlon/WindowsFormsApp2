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
using static WindowsFormsApp2.login;

namespace WindowsFormsApp2
{
    public partial class HRAction : Form
    {
        public HRAction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidPrivate() != true)
            {
                return;
            }
            string query = $"update counter_party set phone='{row2.Text}',mail='{row3.Text}' where id={row1.Text};update counter_private set name = '{row4.Text}', surname = '{row5.Text}', second_name = '{row6.Text}', reg_number = '{row7.Text}' where id = {row1.Text}; ";
            try
            {
                using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Вы сохранили данные про физ.лицо");
                    }
                }
                row1.Text = row2.Text = row3.Text = row4.Text = row5.Text = row6.Text = row7.Text = "";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Не удалось внести изменения");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValidLegal() != true)
            {
                return;
            }
            string query = $"update counter_party set phone='{row12.Text}',mail='{row13.Text}' where id={row11.Text};update counter_legal set title='{row14.Text}',tax_number='{row15.Text}',vat_number='{row16.Text}' where id={row11.Text}";
            try
            {
                using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Вы сохранили данные про Юр. лицо");
                    }
                }
                row11.Text = row12.Text = row13.Text = row14.Text = row15.Text = row16.Text = "";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Не удалось внести изменения");
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValidEmployee() != true)
            {
                return;
            }
            string query = $"update employee set name='{row22.Text}',surname='{row23.Text}',second_name='{row24.Text}',phone='{row25.Text}',mail='{row26.Text}',speciality='{row27.Text}' where id_employee={row21.Text}";
            try
            {
                using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Вы сохранили данные про работника");
                    }
                }
                row21.Text = row22.Text = row23.Text = row24.Text = row25.Text = row26.Text = row27.Text = "";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Не удалось внести изменения");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IsValidPrivate() != true)
            {
                return;
            }
            string query = $"insert into counter_party values({row1.Text},'{row2.Text}','{row3.Text}');insert into counter_private values({row1.Text},'{row4.Text}','{row5.Text}','{row6.Text}','{row7.Text}')";
            try
            {
                using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Вы добавили данные про физ.лицо");
                    }
                }
                row1.Text = row2.Text = row3.Text = row4.Text = row5.Text = row6.Text = row7.Text = "";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Не удалось внести изменения");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsValidLegal() != true)
            {
                return;
            }
            string query = $"insert into counter_party values({row11.Text},'{row12.Text}','{row13.Text}');insert into counter_legal values({row11.Text},'{row14.Text}','{row15.Text}','{row16.Text}')";
            try
            {
                using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Вы добавили данные про Юр. лицо");
                    }
                }
                row11.Text = row12.Text = row13.Text = row14.Text = row15.Text = row16.Text = "";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Не удалось внести изменения");
            }
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (IsValidEmployee() != true)
            {
                return;
            }
            string query = $"insert into employee values({row21.Text},'{row22.Text}','{row23.Text}','{row24.Text}','{row25.Text}','{row26.Text}','{row27.Text}')";
            try
            {
                using (MySqlConnection con = new MySqlConnection(MyGlobal.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Вы добавили данные про работника");
                    }
                }
                row21.Text = row22.Text = row23.Text = row24.Text = row25.Text = row26.Text = row27.Text = "";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Не удалось внести изменения");
            }
           
        }
        private bool IsValidPrivate()
        {
            bool result = true;
            string attention="Неверно введен(введенны) следующие поля:";
            if (Validation.IsValidMail(row3.Text) != true)
            {
                result = false;
                attention += "\nПочта";
            }
            if (Validation.IsPhoneNumber(row2.Text) != true)
            {
                result = false;
                attention += "\nТелефон";
            }
            if (Validation.IsTaxRegNumber(row7.Text, 12) != true)
            {
                result = false;
                attention += "\nРегистрационный номер";
            }
            if (Validation.IsCurillic(row4.Text)!=true || Validation.IsCurillic(row5.Text) != true || Validation.IsCurillic(row6.Text) != true)
            {
                result = false;
                attention += "\nодно(несколько) из полей ФИО";
            }
            if (result == false)
                MessageBox.Show(attention);
            return result;
        }
        private bool IsValidLegal()
        {
            bool result = true;
            string attention = "Неверно введен(введенны) следующие поля:";
            if (Validation.IsValidMail(row13.Text) != true)
            {
                result = false;
                attention += "\nПочта";
            }
            if (Validation.IsPhoneNumber(row12.Text) != true)
            {
                result = false;
                attention += "\nТелефон";
            }
            if (Validation.IsTaxRegNumber(row15.Text, 10) != true)
            {
                result = false;
                attention += "\nTAX";
            }
            if (Validation.IsVatNumber(row16.Text) != true)
            {
                result = false;
                attention += "\nTAX";
            }
            if (result == false)
                MessageBox.Show(attention);
            return result;
        }
        private bool IsValidEmployee()
        {
            bool result = true;
            string attention = "Неверно введен(введенны) следующие поля:";
            if (Validation.IsValidMail(row26.Text) != true)
            {
                result = false;
                attention += "\nПочта";
            }
            if (Validation.IsPhoneNumber(row25.Text) != true)
            {
                result = false;
                attention += "\nТелефон";
            }
            if (Validation.IsCurillic(row22.Text) != true || Validation.IsCurillic(row23.Text) != true || Validation.IsCurillic(row24.Text) != true || Validation.IsCurillic(row27.Text) != true)
            {
                result = false;
                attention += "\nодно(несколько) из полей ФИО или специализация";
            }
            if (result == false)
                MessageBox.Show(attention);
            return result;
        }
    }


}

