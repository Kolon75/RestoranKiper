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
    internal class ProducktFromDB
    {
        public List<Produckt> LoadProduckt()
        {
            List<Produckt> produckts = new List<Produckt>();
            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] select [id],[produckt],[belky],[Jiri],[Ugle] from [dbo].[PrOduckt]";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        produckts.Add(new Produckt(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]), Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4])));
                    }
                }

                reader.Close();
                return produckts;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return produckts;
            }
            finally
            {
                connection.Close();
            }
        }
        public void DelProduckt(int id)
        {
            
            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] delete [dbo].[PrOduckt] where [id] = @id";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
               
                
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
        public void SaveProduckt(string name, int belki, int jiri, int ugle)
        {

            SqlConnection connection = new SqlConnection(Connection.connString);
            //try
            //{
                connection.Open();
                string sqlExp = "use [Kulynar] insert into [dbo].[PrOduckt] values (@Name, @Belki, @Jiri, @Ugle)";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Belki", belki);
                command.Parameters.AddWithValue("@Jiri", jiri);
                command.Parameters.AddWithValue("@Ugle", ugle);
                command.ExecuteNonQuery();

            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
            //finally
            //{
            //    connection.Close();
            //}
        }
    }
}
