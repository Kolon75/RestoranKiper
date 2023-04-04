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
    internal class Autorize
    {
        public int ChekAutorize(string login, string password)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connection.connString))
                {
                    connect.Open();
                    if (!(login != "" && password != ""))
                    {
                        MessageBox.Show("Введлите данные"); return 0;
                    }
                    string sqlExp = "use [Kulinaria_Arshinowww] SELECT * FROM USERS$ where Login=@login";
                    SqlCommand cmd = new SqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@login", login);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Autorization.Fio = reader["LastName"].ToString() + " " + reader["FirsName"].ToString() + " " + reader["Patronymic"].ToString();
                        Autorization.UserId = (Convert.ToInt32(reader["User_id"]));
                        if (Verification.VerifySHA512Hash(password, (string)reader["Password"]))
                        {
                            return (Convert.ToInt32(reader["Role_Id"]));
                        }

                        else
                        {
                            MessageBox.Show("Неверный пароль");
                            password = "";
                            return 0;
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
            { MessageBox.Show(ex.Message); return 0; }
        }
    }
}