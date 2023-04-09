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

namespace WindowsFormsApp1
{
    public partial class Regestr : Form
    {
        public Regestr()
        {
            InitializeComponent();
        }

        private void button_Reg_Click(object sender, EventArgs e)
        {
            Regestration regestration = new Regestration();
            if (textBox_FN.Text == "" || textBox_LN.Text == "" || textBox_Login.Text == "" || textBox_Pass.Text == "" || textBox_Pass2.Text == "")
            {
                MessageBox.Show("Обязательно заполните все поля!");
                return;
            }
            bool rez = regestration.CheckPassword(textBox_Pass.Text,textBox_Pass2.Text);
            if (!rez) return;
            else
            {
                if (regestration.UserCheck(textBox_Login.Text))
                {
                    regestration.UserAdd(textBox_FN.Text, textBox_LN.Text, textBox_Pat.Text, dateTimePicker_DOB.Text, textBox_Login.Text, textBox_Pass.Text, float.Parse(textBox_Tel.Text), textBox_Add.Text);
                    Close();
                }
                else return;
            }
        }

        private void Regestr_Load(object sender, EventArgs e)
        {
            textBox_Pat.Text = " ";
            textBox_Tel.Text = "0";
            textBox_Add.Text = " ";
            dateTimePicker_DOB.Value = DateTime.Now;
        }
    }
}
