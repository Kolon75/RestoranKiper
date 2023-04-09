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
    public partial class AddProd : Form
    {
        ProducktFromDB producktFromDB = new ProducktFromDB();
        public AddProd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producktFromDB.SaveProduckt(textBox_NameProd.Text, int.Parse(textBox_belki.Text), int.Parse(textBox_Jiri.Text), int.Parse(textBox_Ugle.Text));
            Close();
        }
    }
}
