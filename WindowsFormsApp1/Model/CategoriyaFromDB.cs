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
    internal class CategoriyaFromDB
    {
        public List<Categoriya> LoadCategories()
        {
            List<Categoriya> categoriyas= new List<Categoriya>();
            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] SELECT [ShortName],[FullName] FROM [dbo].[Vid_Bluda]";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        categoriyas.Add(new Categoriya(int.Parse(reader[0].ToString()), reader[1].ToString()));
                    }
                }
                reader.Close();
                return categoriyas;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return categoriyas;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
