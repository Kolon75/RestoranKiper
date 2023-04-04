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
    internal class Autoriz
    {
        
        public int CheckAutorize(string login, string password)
        {


            try
            {
                using (SqlConnection connect = new SqlConnection(Connection.connString))
                {
                    connect.Open();
                    if (!(login != "" && password != ""))
                    {
                        MessageBox.Show("Введите данные"); return 0;
                    }
                    string sqlExp = "use [Kulynar] select * from [dbo].[Users] where [Login] = @login";
                    SqlCommand cmd = new SqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@login", login);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Autorization.Fio = reader["LastName"].ToString() + " " + reader["FirsName"].ToString() + " " + reader["Patronymic"].ToString();
                        Autorization.UserId = int.Parse(reader["User_Id"].ToString());
                        if (Verification.VerifySHA512Hash(password, reader["Password"].ToString()))
                        {
                            return int.Parse(reader["Role_Id"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль");
                            password = "";
                            return -1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нет такого пользователя");
                        login = "";
                        password = "";
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
