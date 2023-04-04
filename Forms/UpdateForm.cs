using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Today;
            SelectUser();
        }
        public static string Fio { get; set; }
        void SelectUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connString))
                {
                    connection.Open();
                    string sqlExp = "select * from[dbo].[USERS] where @userId = [User_id]";
                    SqlCommand cmd = new SqlCommand(sqlExp, connection);

                    cmd.Parameters.AddWithValue("@userId", Autorization.UserId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    textBox1.Text = reader[1].ToString();
                    textBox2.Text = reader[2].ToString();
                    textBox3.Text = reader[3].ToString();
                    textBox4.Text = reader[5].ToString();
                    textBox6.Text = reader[7].ToString();
                    textBox7.Text = reader[8].ToString();
                    dateTimePicker1.Value = DateTime.Parse(reader[4].ToString());
                    reader.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
        }
        void UpdateUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connString))
                {
                    connection.Open();
                    string sqlExp = "update [dbo].[USERS] set FirstName=@FirstName, LastName=@LastName, Patronym=@Patronym, DateOfBirth=@DateOfBirth, Logins=@Logins, Phone=@Phone, Adress=@Adress where [User_id]=@User_Id";
                    SqlCommand cmd = new SqlCommand(sqlExp, connection);

                    cmd.Parameters.AddWithValue("@User_Id", Autorization.UserId);
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Patronym", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Logins", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Phone", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Adress", textBox7.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", (DateTime)dateTimePicker1.Value);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1) MessageBox.Show("Данные изменены");
                    else MessageBox.Show("Ошибка обновления данных");

                    connection.Close();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateUser();
            Autorization regForm = new Autorization();
            regForm.Show();
            this.Hide();

        }
    }
}
