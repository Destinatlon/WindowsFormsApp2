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

    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyGlobal.User = log.Text;
            MyGlobal.Password = pass.Text;
            this.Hide();
            switch (MyGlobal.User)
            {
                case "buhalter":
                    MyGlobal.connectionString = $"server=localhost;user id={MyGlobal.User};password={MyGlobal.Password};database=forlab4";
                    Form1 orders = new Form1();
                    orders.Show();
                    break;
                case "hr":
                    MyGlobal.connectionString = $"server=localhost;user id={MyGlobal.User};password={MyGlobal.Password};database=forlab4";
                    HR hr = new HR();
                    hr.Show();
                    break;
                default:
                    MessageBox.Show("В системе нет такого пользователя");
                    this.Show();
                    break;
            }

        }
    }
    public static class Validation
    {
        public static bool IsCurillic(string stringToCheck)
        {
            if (!Regex.IsMatch(stringToCheck, @"\P{IsCyrillic}"))
            {
                return true;
            }
            else
                return false;
        }
        public static bool IsPhoneNumber(string phone)
        {
            return Regex.Match(phone, @"^(\+[0-9]{12})$").Success;
        }
        public static bool IsValidMail(string mail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(mail);
                return addr.Address == mail;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsTaxRegNumber(string str, int len)
        {
            if (str.Length != len)
            {
                return false;
            }
            else
            {
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;

            }
        }
        public static bool IsVatNumber(string vat)
        {
            if (vat.Length != 12)
            {
                return false;
            }
            else
            {
                string a = vat.Substring(0, 2);
                a=a.ToUpper();
                string b = vat.Substring(2, 10);
                if(a.All(char.IsLetter)!=true || b.All(char.IsDigit)!=true)
                {
                    return false;
                }
                return true;
            }
        }
        public static bool IsStreetNumber(string numb)
        {
            string a;
            for(int i = 0; i < numb.Length; i++)
            {
                a = numb.Substring(i, 1);
                if (a.All(char.IsLetterOrDigit) != true && a != "/" && a != "-")
                    return false;
            }
            if (numb.All(char.IsLetter) == true)
            {
                return false;
            }
            return true;
        }
    }
}
