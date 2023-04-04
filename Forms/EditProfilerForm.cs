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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class EditProfilerForm : Form
    {
        public EditProfilerForm()
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
                    string sqlExp = "select * from[dbo].[Users$] where @userId = [User_id]";
                    SqlCommand cmd = new SqlCommand(sqlExp, connection);

                    cmd.Parameters.AddWithValue("@userId", Autorization.UserId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    textBox1.Text = reader[1].ToString();
                    textBox2.Text = reader[2].ToString();
                    textBox3.Text = reader[3].ToString();
                    textBox4.Text = reader[5].ToString();
                    textBox7.Text = reader[7].ToString();
                    textBox6.Text = reader[8].ToString();
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
                    string sqlExp = "update [dbo].[Users$] set FirsName=@FirstName, LastName=@LastName, [Patronymic]=@Patronymic, [DateOfBirthday]=@DateOfB, [Login]=@Login, [Phone]=@Tel, [Adress]=@Adress where [User_id]=@userId";
                    SqlCommand cmd = new SqlCommand(sqlExp, connection);

                    cmd.Parameters.AddWithValue("@userId", Autorization.UserId);
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Patronymic", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Login", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Tel", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Adress", textBox6.Text);
                    cmd.Parameters.AddWithValue("@DateOfB", dateTimePicker1.Value);

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
        }

        private void EditProfilerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
