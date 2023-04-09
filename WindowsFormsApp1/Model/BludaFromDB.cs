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
    internal class BludaFromDB
    {
        public List<Bludo> LoadBludos()
        {
            List<Bludo> bludos = new List<Bludo>();

            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] SELECT b.[id_bluda],[Bluda],[FullName],[Osnova],sum([Ves]),[Image] FROM [dbo].[Bluda] b join [dbo].[Sostqav_Bluda] sb on b.[id_bluda] = sb.[id_bluda] join [dbo].[Vid_Bluda] vb on b.[ShortName] = vb.[ShortName] group by b.[id_bluda] ,[Bluda] ,[FullName] ,[Osnova] ,[Image]";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        bludos.Add(new Bludo((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), (int)reader[4], reader[5].ToString()));
                    }
                }
                reader.Close();
                return bludos;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return bludos;
            }
            finally
            {
                connection.Close();
            }

        }
        public List<Bludo> FiltrByCategory(string cat)
        {
            List<Bludo> bludos = new List<Bludo>();

            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] SELECT b.[id_bluda],[Bluda],[FullName],[Osnova],sum([Ves]),[Image] FROM [dbo].[Bluda] b join [dbo].[Sostqav_Bluda] sb on b.[id_bluda] = sb.[id_bluda] join [dbo].[Vid_Bluda] vb on b.[ShortName] = vb.[ShortName] group by b.[id_bluda] ,[Bluda] ,[FullName] ,[Osnova] ,[Image] having [FullName] = @cat";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@cat", cat);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bludos.Add(new Bludo((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), (int)reader[4], reader[5].ToString()));
                    }
                }
                reader.Close();
                return bludos;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return bludos;
            }
            finally
            {
                connection.Close();
            }
        }
        public void DelBludo(int id)
        {

            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] delete [dbo].[Bluda] where [id] = @id";
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
        public void AddNewBludo(Bludo newBludo, List<Resept> resepts, int idCat , string picPath)
        {
            SqlConnection connection = new SqlConnection(Connection.connString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand cmd = connection.CreateCommand();
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "use [Kulynar] insert into [dbo].[Bluda] values (@bludoName,@idCat,@osnova,@vyhod,@picPath)";
                cmd.Parameters.AddWithValue("@bludoName", newBludo.BludoName);
                cmd.Parameters.AddWithValue("@idCat", idCat);
                cmd.Parameters.AddWithValue("@osnova", newBludo.Osnova);
                cmd.Parameters.AddWithValue("@vyhod", newBludo.Vyhod);
                cmd.Parameters.AddWithValue("@picPath", picPath);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "use [Kulynar] select max([id_bluda]) from [dbo].[Bluda]";
                int idBluda = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = 0; i < resepts.Count; i++)
                {
                    cmd.CommandText = $"use [Kulynar] insert into [dbo].[Sostqav_Bluda] values ({idBluda},(select [id] from [dbo].[PrOduckt] where [produckt] = '{resepts[i].NameProd}'),{resepts[i].Ves})";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Блюдо добавлено!");
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
        }
        public int BludoC()
        {
            int MaxC = 0;
            List<ReseptDB> reseptDB = new List<ReseptDB>();
            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] select count([id_bluda]) from [dbo].[Bluda]";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                MaxC = Convert.ToInt32(reader[0]);

                reader.Close();
                return MaxC;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return MaxC;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
