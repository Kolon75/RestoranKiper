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

namespace WindowsFormsApp1
{
    public partial class Productiki : Form
    {
        public List<Produckt> produckts = new List<Produckt>();

        ProducktFromDB producktFromDB = new ProducktFromDB();
        public Productiki()
        {
            InitializeComponent();
            dataGridView1.Columns[0].DataPropertyName = "Id";
            dataGridView1.Columns[1].DataPropertyName = "Produck";
            dataGridView1.Columns[2].DataPropertyName = "Belky";
            dataGridView1.Columns[3].DataPropertyName = "Jiri";
            dataGridView1.Columns[4].DataPropertyName = "Ugle";
            dataGridView1.Columns[0].Visible = false;
        }
        private void ViewAllProducts()
        {
            produckts = producktFromDB.LoadProduckt();
            dataGridView1.DataSource = produckts;
        }

        private void Productiki_Load(object sender, EventArgs e)
        {
            ViewAllProducts();
            switch (Autorization.Roleid)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    button_Add.Visible = false;
                    button_Del.Visible = false;
                    break;
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            producktFromDB.DelProduckt(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            ViewAllProducts();

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddProd addProd = new AddProd();
            addProd.ShowDialog();
            ViewAllProducts();

        }
    }
}
