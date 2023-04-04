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
    internal class UserFromDB
    {
        public User LoadUser()
        {
            User users = new User();
            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] SELECT u.[User_id],[FirsName],[LastName],[Patronymic],[DateOfBirthday],[Login],[Password],[Phone],[Adress],[Role_id],[Email],[SeriaPas],[NumPas],[Vidan],[DataVidachi] FROM [Kulynar].[dbo].[Users] as u join [Kulynar].[dbo].[DataUser] as d on u.[User_id] = d.[User_id] where u.[User_id] = @user";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@user", Autorization.UserId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        users = new User((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), float.Parse(reader[7].ToString()), reader[8].ToString(), float.Parse(reader[9].ToString()), reader[10].ToString(), int.Parse(reader[11].ToString()), int.Parse(reader[12].ToString()), reader[13].ToString(), reader[14].ToString());
                    }
                }
                reader.Close();
                return users;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return users;
            }
            finally
            {
                connection.Close();
            }
        }
        public void IzmenUser1(string FN, string LN, string Patr, string Date, string Login, float Tel, string Add, string email, int spas, int npas, string vid, string DV)
        {
            string sqlExp = "upus";
            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ui", Autorization.UserId);
                command.Parameters.AddWithValue("@FN", FN);
                command.Parameters.AddWithValue("@LN", LN);
                command.Parameters.AddWithValue("@Pat", Patr);
                command.Parameters.AddWithValue("@DOB", Convert.ToDateTime(Date));
                command.Parameters.AddWithValue("@log", Login);
                command.Parameters.AddWithValue("@ph", Tel);
                command.Parameters.AddWithValue("@add", Add);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@spas", spas);
                command.Parameters.AddWithValue("@npas", npas);
                command.Parameters.AddWithValue("@vid", vid);
                command.Parameters.AddWithValue("@DV", Convert.ToDateTime(DV));
                var result = command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void IzmenUser2(string FN, string LN, string Patr, string Date, string Login, float Tel, string Add)
        {
            string sqlExp = "upus2";
            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ui", Autorization.UserId);
                command.Parameters.AddWithValue("@FN", FN);
                command.Parameters.AddWithValue("@LN", LN);
                command.Parameters.AddWithValue("@Pat", Patr);
                command.Parameters.AddWithValue("@DOB", Convert.ToDateTime(Date));
                command.Parameters.AddWithValue("@log", Login);
                command.Parameters.AddWithValue("@ph", Tel);
                command.Parameters.AddWithValue("@add", Add);
                var result = command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
