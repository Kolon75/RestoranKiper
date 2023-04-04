using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Passwordik : Form
    {
        private void LoadPass()
        {
            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] SELECT [Login] from [dbo].[Users] where [User_id] = @user";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@user", Autorization.UserId);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                textBox_Login.Text = reader[0].ToString();
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
        private void IzmenPass()
        {


            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [Kulynar] update [dbo].[Users] set [Login] = @Log, [Password] = @Pass where [User_id] = @USER";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@user", Autorization.UserId);
                command.Parameters.AddWithValue("@Log", textBox_Login.Text);
                command.Parameters.AddWithValue("@Pass", Verification.GetSHA512Hash(textBox_Pass.Text));
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
        public Passwordik()
        {
            InitializeComponent();
        }

        private void Passwordik_Load(object sender, EventArgs e)
        {
            LoadPass();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text != "")
            {
                IzmenPass();
                Close();
            }
            else
            {
                return;
            }
        }
    }
}
