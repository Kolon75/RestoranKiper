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
    public partial class Autorization : Form
    {
        public static string Fio { get; set; }
        public static int UserId { get; set; }

        public static int Roleid = 0;

        Autoriz autoriz = new Autoriz();
        string pathString = "../../Captchas/";
        Random rnd = new Random();
        string[] cap = new string[] { "AfF0p", "Br2Zo5", "Jo0eZ", "Qwe12" };
        int c;
        public Autorization()
        {
            InitializeComponent();
            Fio = "";
            UserId = 0;
        }

        private void button_Log_In_Click(object sender, EventArgs e)
        {
            if (groupBox_Captcha.Visible)
            {
                Roleid = autoriz.CheckAutorize(textBox_Login.Text, textBox_Pass.Text);
                if (textBox_Captcha.Text == cap[c])
                {
                    if (Roleid > 0)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        textBox_Captcha.Clear();
                        textBox_Pass.Clear();
                        c = rnd.Next(4);
                        pictureBox_Captcha.Image = Image.FromFile(pathString + cap[c] + ".png");
                    }
                }
            }
            else
            {
                Roleid = autoriz.CheckAutorize(textBox_Login.Text, textBox_Pass.Text);
                if (Roleid > 0)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                if (Roleid < 0)
                {
                    textBox_Pass.Clear();
                    c = rnd.Next(4);
                    groupBox_Captcha.Visible = true;
                    pictureBox_Captcha.Image = Image.FromFile(pathString + cap[c]+".png");
                }
            }
        }

        private void button_Reg_Click(object sender, EventArgs e)
        {
            Regestr regestr = new Regestr();
            regestr.ShowDialog();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            groupBox_Captcha.Visible = false;
        }
    }
}
