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
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class PassUpdate : Form
    {
        public PassUpdate()
        {
            InitializeComponent();
        }
        public void ChangePassword(string password)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connection.connString))
                {
                    connect.Open();
                    string sqlExp = "update USERS set Password = @password where [User_id] = @id";
                    SqlCommand cmd = new SqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@id", Autorization.UserId);
                    cmd.Parameters.AddWithValue("password", Verification.GetSHA512Hash(password));
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1) { MessageBox.Show("Пароль изменен"); }
                    else MessageBox.Show("Ошибка изменения записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationClass reg = new RegistrationClass();
            bool passwerd = reg.CheckPassword(textBox1.Text, textBox2.Text);
            if (passwerd)
            {
                ChangePassword(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
            }
            Autorization autForm = new Autorization();
            autForm.Show();
            this.Hide();
        }

        private void PassUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
