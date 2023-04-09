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
    internal class ReseptFromDB
    {
        public List<Resept> LoadSostav(int idBlud)
        {
            List<Resept> resepts = new List<Resept>();
            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] SELECT [produckt],[Ves] from [dbo].[Bluda] b join [dbo].[Sostqav_Bluda] sb on b.id_bluda = sb.id_bluda join [dbo].[PrOduckt] p on sb.id_produckt = p.id where b.id_bluda = @idBluda";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@idBluda", idBlud);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        resepts.Add(new Resept(reader[0].ToString(), int.Parse(reader[1].ToString())));
                    }
                }

                reader.Close();
                return resepts;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return resepts;
            }
            finally
            {
                connection.Close();
            }
        }
        public List<ReseptDB> LoadResept()
        {
            List<ReseptDB> reseptDB = new List<ReseptDB>();
            SqlConnection connection = new SqlConnection(Connection.connString);
            //try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] select r.[id_bluda],[Bluda], [Resept]  from [dbo].[Bluda]b join [dbo].[Resepticky]r on b.id_bluda =r.id_bluda";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reseptDB.Add(new ReseptDB(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString()));
                    }
                }

                reader.Close();
                return reseptDB;
            }
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return reseptDB;
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }
        public int BludoCount()
        {
            int MaxC = 0;
            List<ReseptDB> reseptDB = new List<ReseptDB>();
            SqlConnection connection = new SqlConnection(Connection.connString);
            //try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] select count([id_bluda]) from [dbo].[Resepticky]";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                MaxC = Convert.ToInt32(reader[0]);

                reader.Close();
                return MaxC;
            }
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return MaxC;
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }
    }
}
