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
    public partial class RegistationForm : Form
    {
        public RegistationForm()
        {
            InitializeComponent();
        }

        private void RegistationForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registation registration = new Registation();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            { MessageBox.Show("Необходимо заполнить все поля!"); return; }
            bool rez = registration.CheckPassword(textBox4.Text, textBox5.Text);
            if (!rez) return;
            else
                if (registration.UserChek(textBox3.Text))
            {
                registration.UserAdd(textBox3.Text, textBox4.Text, textBox1.Text, textBox2.Text);
            }
            else return;
        }
    }
}
