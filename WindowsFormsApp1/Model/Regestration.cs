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
    internal class Regestration
    {
        public bool CheckPassword(string password, string password2)
        {
            if(password.Length < 6)
            {
                MessageBox.Show("Длина пароля должна быть больше 6 символов!");
                return false;
            }
            else
            {
                bool f, f1, f2;
                f = f1 = f2 = false;
                for(int i = 0; i < password.Length; i++)
                {
                    if (Char.IsDigit(password[i])) f1 = true;
                    if (Char.IsUpper(password[i])) f2 = true;
                    if (f1 && f2) break;
                }
                if (!(f1 && f2))
                {
                    MessageBox.Show("Пароль должен содержать хотя бы одну заглавную букву и одну цифру!");
                    return f1 && f2;
                }
                else
                {
                    string simbol = "!@#$%^";
                    for (int i = 0; i < password.Length; i++)
                    {
                        for (int j = 0; j < simbol.Length; j++)
                        {
                            if (password[i] == simbol[j])
                            {
                                f = true; break;
                            }
                        }
                    }
                    if (!f) MessageBox.Show("Пароль должен содержать один из символов !@#$%^");
                    if ((password == password2) && f) return true; else { MessageBox.Show("Неправильно подтверждён пароль!"); return false; }
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
                    string sqlExp = "use [Kulynar] select [Login] from [dbo].[Users] where [Login]=@login";
                    SqlCommand cmd = new SqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@login", login);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Такой логин уже есть!");
                        return false;
                    }
                    else
                    {
                        reader.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void UserAdd(string FN, string LN, string Pat, string DOB, string log, string pass, float Ph, string Add)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connection.connString))
                {
                    connect.Open();
                    string sqlExp = "use [Kulynar] INSERT INTO [dbo].[Users] VALUES (@FN, @LN, @Pat, @DOB, @log, @pass, @Ph, @Add, '4')";
                    SqlCommand cmd1 = new SqlCommand(sqlExp, connect);
                    cmd1.Parameters.AddWithValue("@FN",FN);
                    cmd1.Parameters.AddWithValue("@LN",LN);
                    cmd1.Parameters.AddWithValue("@Pat", Pat);
                    cmd1.Parameters.AddWithValue("@DOB", Convert.ToDateTime(DOB));
                    cmd1.Parameters.AddWithValue("@log",log);
                    cmd1.Parameters.AddWithValue("pass",Verification.GetSHA512Hash(pass));
                    cmd1.Parameters.AddWithValue("@Ph", Ph);
                    cmd1.Parameters.AddWithValue("@Add", Add);
                    int i = cmd1.ExecuteNonQuery();
                    if(i >= 1)
                    {
                        MessageBox.Show("Вы успешно зарегистрированы");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка регистрации");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
