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
    public partial class Redakt : Form
    {
        //private void LoadUser()
        //{
        //    SqlConnection connection = new SqlConnection(Connection.connString);
        //    try
        //    {
        //        connection.Open();
        //        string sqlExp = "use [Kulynar] SELECT [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Phone], [Adress] from [dbo].[Users] where [User_id] = @user";
        //        SqlCommand command = new SqlCommand(sqlExp, connection);
        //        command.Parameters.AddWithValue("@user",Autorization.UserId);
        //        SqlDataReader reader = command.ExecuteReader();
        //        reader.Read();
        //        textBox_FN.Text = reader[0].ToString();
        //        textBox_LN.Text = reader[1].ToString();
        //        textBox_Patr.Text = reader[2].ToString();
        //        dateTimePicker_Date.Text = reader[3].ToString();
        //        textBox_Login.Text = reader[4].ToString();
        //        textBox_Tel.Text = reader[5].ToString();
        //        textBox_Add.Text = reader[6].ToString();
        //        reader.Close();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
        //private void IzmenUser()
        //{


        //    SqlConnection connection = new SqlConnection(Connection.connString);
        //    try
        //    {
        //        connection.Open();
        //        string sqlExp = "use [Kulynar] update [dbo].[Users] set [FirsName] = @FN, [LastName] = @LN, [Patronymic] = @PATR, [DateOfBirthday] = @DOB, [Login] = @Log, [Phone] = @PH, [Adress] = @ADD where [User_id] = @USER";
        //        SqlCommand command = new SqlCommand(sqlExp, connection);
        //        command.Parameters.AddWithValue("@user", Autorization.UserId);
        //        command.Parameters.AddWithValue("@FN", textBox_FN.Text);
        //        command.Parameters.AddWithValue("@LN", textBox_LN.Text);
        //        command.Parameters.AddWithValue("@PATR", textBox_Patr.Text);
        //        command.Parameters.AddWithValue("@DOB", dateTimePicker_Date.Value);
        //        command.Parameters.AddWithValue("@Log", textBox_Login.Text);
        //        command.Parameters.AddWithValue("@PH", textBox_Tel.Text);
        //        command.Parameters.AddWithValue("@ADD", textBox_Add.Text);
        //        command.ExecuteNonQuery();

        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
        public User users = new User();
        UserFromDB userFromDB = new UserFromDB();
        public Redakt()
        {
            InitializeComponent();
        }
        private void ViewAllBludos()
        {
            users = userFromDB.LoadUser();
            textBox_FN.Text = users.FirsName;
            textBox_LN.Text = users.LastName;
            textBox_Patr.Text = users.Patronymic;
            dateTimePicker_Date.Text = users.DateOfBirthDay;
            textBox_Login.Text = users.Login;
            textBox_Tel.Text = users.Phone.ToString();
            textBox_Add.Text = users.Adress;
            textBox1.Text = users.Email;
            textBox2.Text = users.SeriaPas.ToString();
            textBox3.Text = users.NumPas.ToString();
            textBox4.Text = users.Vidan;
            dateTimePicker1.Text = users.DataVidachi;
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                userFromDB.IzmenUser1(textBox_FN.Text, textBox_LN.Text, textBox_Patr.Text, dateTimePicker_Date.Text, textBox_Login.Text, float.Parse(textBox_Tel.Text), textBox_Add.Text, textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, dateTimePicker1.Text);
            }
            else
            {
                userFromDB.IzmenUser2(textBox_FN.Text, textBox_LN.Text, textBox_Patr.Text, dateTimePicker_Date.Text, textBox_Login.Text, float.Parse(textBox_Tel.Text), textBox_Add.Text);
            }
            Close();
        }

        private void Redakt_Load(object sender, EventArgs e)
        {
            ViewAllBludos();
        }
    }
}
