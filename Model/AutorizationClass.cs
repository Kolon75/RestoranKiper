using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.Model
{
    internal class AutorizationClass
    {

        public int CheckAutorize(string login, string password)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connection.connString))
                {
                    connect.Open();
                    if (!(login != "" & password != ""))
                    {
                        MessageBox.Show("Введите данные"); return 0;
                    }
                    string sqlExp = "select*from USERS where Logins=@logins";
                    SqlCommand cmd = new SqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@logins", login);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Autorization.Fio = reader["LastName"].ToString() + " " + reader["FirstName"].ToString() + " " + reader["Patronym"].ToString();
                        Autorization.UserId = Convert.ToInt32(reader["User_Id"]);
                        if (Verification.VerifySHA512Hash(password, (string)reader["Password"]))
                        {
                            return Convert.ToInt32(reader["Role_Id"]);
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль");
                            return 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нет такого пользователя");
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); return 0; }
        }
    }

}
