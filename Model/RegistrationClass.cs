using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Model
{
    internal class RegistrationClass
    {
        public bool CheckPassword(string password, string passRepeat)
        {
            if (password.Length < 6)
            {
                MessageBox.Show("Длина пароля должна составлять не более 6-и символов");
                return false;
            }
            else
            {
                bool f, f1, f2;
                f = f1 = f2 = false;
                for(int i = 0; i < password.Length; i++)
                {
                    if (Char.IsDigit (password[i])) f1 = true;
                    if (Char.IsDigit (password[i])) f2 = true;
                }
                if (!(f1 && f2))
                {
                    MessageBox.Show("Пароль должен содержать одн цифру и одну заглавную букву!");
                    return f1 && f2;
                }
                else
                {
                    string simbol = "!@#$%^";
                    for (int i = 0; i < password.Length; i++)
                    {
                        for (int j = 0; j < simbol.Length; j++)
                            if (password[i] == simbol[j]) { f = true; break; }
                    }
                    if (!f) MessageBox.Show("Пароль должен содержать один из представленных символов !@#$%^");
                    if ((password == passRepeat) && f) return true; else { MessageBox.Show("Неверно подтвержден пароль"); return false; }
                }
            }
        }
        public bool UserCheck(string login)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connection.connString))
                {
                    connect.Open();
                    string sqlExp = "Select Logins from USERS where Logins=@logins";
                    SqlCommand cmd = new SqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@logins", login);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Такой логин уже существует"); return false;
                    }
                    else
                    {
                        reader.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return false; }
        }
        public void UserAdd(string login, string password, string firstName, string lastName)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connection.connString))
                {
                    connect.Open();
                    string sqlExp = "insert into USERS (Logins, Password, FirstName, LastName) values (@logins, @password, @FirstName, @LastName)";
                    SqlCommand cmd1 = new SqlCommand(sqlExp, connect);
                    cmd1.Parameters.AddWithValue("@logins", login);
                    cmd1.Parameters.AddWithValue("@password", Verification.GetSHA512Hash(password));
                    cmd1.Parameters.AddWithValue("FirstName", firstName);
                    cmd1.Parameters.AddWithValue("@LastName", lastName);
                    int i = cmd1.ExecuteNonQuery();
                    if (i == 1) { MessageBox.Show("Вы успешно зарегистрировались"); }
                    else MessageBox.Show("Ошибка записи");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message ); return; }
        }
    }
}
