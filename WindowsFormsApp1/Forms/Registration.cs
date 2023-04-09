using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationClass registration = new RegistrationClass();
            if (textBox1.Text == "" /*Имя*/|| textBox2.Text == "" /*Фамилия*/|| textBox3.Text == "" /*Логин*/|| textBox4.Text == "" /*Пароль*/|| textBox5.Text == ""/*Подтверждение пароля*/)
            { MessageBox.Show("Необходимо заполнить все поля!"); return; }
            bool rez = registration.CheckPassword(textBox4.Text, textBox5.Text);
            if (!rez) return;
            else
            if (registration.UserCheck(textBox3.Text))
            {
                registration.UserAdd(textBox3.Text, textBox4.Text, textBox1.Text, textBox2.Text);
            }
            else return;
            Autorization autForm = new Autorization();
            autForm.Show();
            this.Hide();
        }     
    }
}
