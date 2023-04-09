using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class ReseptForm : Form
    {
        int i = 0;

        public List<ReseptDB> reseptDB = new List<ReseptDB>();

        ReseptFromDB reseptFromDB = new ReseptFromDB();

        public List<Resept> reseptiki = new List<Resept>();

        public ReseptForm()
        {
            InitializeComponent();
        }

        private void ReseptForm_Load(object sender, EventArgs e)
        {
            reseptDB = reseptFromDB.LoadResept();
            FormCange();
            button_Add.Visible = false;
            button_Edit.Visible = false;
            button_Del.Visible = false;
        }
        private void FormCange()
        {
            int MaxC = reseptFromDB.BludoCount();
            if (i == 0)
            {
                button_Prev.Visible = false;
            }
            else if (i == MaxC-1)
            {
                button_Next.Visible = false;
            }
            else
            {
                button_Prev.Visible = true;
                button_Next.Visible = true;
            }
            listBox_Sostav.Items.Clear();
            reseptiki = reseptFromDB.LoadSostav(reseptDB[i].Id_Bluda);
            ListBoxValue(reseptiki);
            label_BludoName.Text = reseptDB[i].Bluda;
            richTextBox_Resept.Text = reseptDB[i].Resept;
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            i--;
            FormCange();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            i++;
            FormCange();
        }
        private void ListBoxValue(List<Resept> reseptiki)
        {
            foreach (Resept resept in reseptiki)
            {
                listBox_Sostav.Items.Add(resept.NameProd.ToString() + " " + resept.Ves.ToString());

            }
        }
        
    }
}
