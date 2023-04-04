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
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Model;


namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        

        public List<Bludo> bludos = new List<Bludo>();

        BludaFromDB bludaFromDB = new BludaFromDB();

        public List<Categoriya> categoriyas = new List<Categoriya>();

        CategoriyaFromDB categoriyaFromDB = new CategoriyaFromDB();

        public List<Resept> reseptiki = new List<Resept>();

        ReseptFromDB reseptFromDB = new ReseptFromDB();
        


        public MainForm()
        {
            InitializeComponent();
            dataGridView1.Columns[0].DataPropertyName = "Id";
            dataGridView1.Columns[1].DataPropertyName = "Image";
            dataGridView1.Columns[2].DataPropertyName = "BludoName";
            dataGridView1.Columns[3].DataPropertyName = "Categoriya";
            dataGridView1.Columns[4].DataPropertyName = "Osnova";
            dataGridView1.Columns[5].DataPropertyName = "Vyhod";
            dataGridView1.Columns[0].Visible = false;

        }
        private void ViewAllBludos()
        {
            bludos = bludaFromDB.LoadBludos();
            dataGridView1.DataSource = bludos;
            label_KolvoZap.Text = Zapisi();
            BackColor();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            пользовательToolStripMenuItem.Text = Autorization.Fio;
            ViewAllBludos();
            categoriyas = categoriyaFromDB.LoadCategories();
            categoriyas.Insert(0, new Categoriya(0, "All"));
            comboBox_cat.DataSource = categoriyas;
            comboBox_cat.DisplayMember = "CategoryName";
            comboBox_cat.ValueMember = "CategoryName";
            switch (Autorization.Roleid)
            {
                case 1:
                    break;
                case 2:
                    добавитьБлюдоToolStripMenuItem.Visible = false;
                    удолитьБлюдоToolStripMenuItem.Visible=false;
                    break;
                case 3:
                    break;
            }
            
        }

        private void редактироватьПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Redakt redakt = new Redakt();
            redakt.ShowDialog();
        }
        
        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization autorization = new Autorization();
            autorization.ShowDialog();
        }

        private void сменитьпарольToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Passwordik passwordik = new Passwordik();
            passwordik.ShowDialog();
        }

        private void comboBox_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxClear();
            if (comboBox_cat.SelectedIndex == 0)
            {
                ViewAllBludos();
            }
            else
            {
                bludos = bludaFromDB.FiltrByCategory(comboBox_cat.SelectedValue.ToString());
                dataGridView1.DataSource = bludos;
            }
            label_KolvoZap.Text = Zapisi();
            BackColor();
        }

        private List<Bludo> SearchBludos(string txbSearch)
        {
            List<Bludo> bludoSearch = new List<Bludo>();
            foreach (Bludo item in bludos)
            {
                if (item.BludoName.StartsWith(txbSearch) || item.Osnova.StartsWith(txbSearch))
                {
                    bludoSearch.Add(item);
                }
            }
            return bludoSearch;
        }

        private void poisckBluda__TextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SearchBludos(poisckBluda__TextBox.Text);
            label_KolvoZap.Text = Zapisi();
            BackColor();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBoxClear();
            reseptiki = reseptFromDB.LoadSostav(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            IdNameOfBluda_lable.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ListBoxValue(reseptiki);
        }

        private void ListBoxValue(List<Resept> reseptiki)
        {
            foreach (Resept resept in reseptiki)
            {
                SostavBluda_ListBox.Items.Add(resept.NameProd.ToString() + " " + resept.Ves.ToString());

            }
        }

        private void ListBoxClear()
        {
            SostavBluda_ListBox.Items.Clear();
            IdNameOfBluda_lable.Text = " ";
        }

        private void продукиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productiki productiki = new Productiki();
            productiki.ShowDialog();
        }

        private void удолитьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bludaFromDB.DelBludo(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            ViewAllBludos();
        }

        private void button_ClLb_Click(object sender, EventArgs e)
        {
            ListBoxClear();
        }

        private void добавитьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BludoAddForm bludoAddForm = new BludoAddForm(); 
            //bludoAddForm.ShowDialog();
            if (bludoAddForm.ShowDialog() == DialogResult.Cancel)
            {
                ViewAllBludos();
            }
        }

        private void рецептToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReseptForm reseptForm = new ReseptForm();
            reseptForm.ShowDialog();

        }
        private string Zapisi()
        {
            int kolll = bludaFromDB.BludoC();
            int vivod = dataGridView1.Rows.Count;
            return $"{vivod} из {kolll}.";
        }
        private void BackColor()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) > 200)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
