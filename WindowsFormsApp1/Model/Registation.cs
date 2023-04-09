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
    internal class Registation
    {
        public bool CheckPassword(string password, string passRepeat)
        {
            if (password.Length < 6)
            {
                MessageBox.Show("Длинна пароля не может быть меньше 6 символов");
                return false;
            }
            else
            {
                bool f, f1, f2;
                f = f1 = f2 = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsDigit(password[i])) f1 = true;
                    if (Char.IsDigit(passRepeat[i])) f2 = true;
                    if (f1 && f2) break;

                }
                if (!(f1 && f2))
                {
                    MessageBox.Show("Пароль не должен содержать хотя бы одну цифру и одну заглавную букву!");
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
                    if (!f) MessageBox.Show("Пароль должен содержать один из символов !@#$%^");
                    if ((password == passRepeat) && f) return true; else { MessageBox.Show("Неверно подтвержден пароль"); return false; }
                }
            }
        }
        public bool UserChek(string login)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connection.connString))
                {
                    connect.Open();
                    string sqlExp = "SELECT login from [dbo].[Users$] where Login=@login";
                    SqlCommand cmd = new SqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@login", login);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Такой логин уже есть"); return false;

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
                    string sqlExp = "use [Кулинария_Рева] insert into [Users$]([Login],[Password],[Role_id],[FirsName],[LastName]) Values(@Loginn,@Passwordd, 3,@FirsNamee, @LastNamee)";
                    SqlCommand cmd1 = new SqlCommand(sqlExp, connect);
                    cmd1.Parameters.AddWithValue("@Loginn", login);
                    cmd1.Parameters.AddWithValue("@Passwordd", Verification.GetSHA512Hash(password));
                    cmd1.Parameters.AddWithValue("@FirsNamee", firstName);
                    cmd1.Parameters.AddWithValue("@LastNamee", lastName);
                    int i = cmd1.ExecuteNonQuery();
                    if (i == 1) { MessageBox.Show("Вы успешно зарегестрированы"); }
                    else MessageBox.Show("Ошибка записи");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return; }
        }



    }
}
