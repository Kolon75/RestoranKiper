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
        public void LoadUser(int idUser)
        {

            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "select [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], R.[RoleName] from[dbo].[Users$] U join[dbo].[Role] R on U.[Role_id] = R.[Role_id] where @id = [User_id]";
                SqlCommand cmd = new SqlCommand(sqlExp, connection);

                SqlParameter idC = new SqlParameter("@id", idUser);

                cmd.Parameters.Add(idUser);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    MessageBox.Show((new User((int)reader["UserId"], reader["FirsName"].ToString(), reader["LastName"].ToString(), reader["Patronymic"].ToString(), (DateTime)reader["DateOfBirth"], reader["Login"].ToString(), reader["Password"].ToString(), (float)reader["Phone"], reader["Adress"].ToString(), (int)reader["RoleId"])).ToString());
                }
                reader.Close();
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
