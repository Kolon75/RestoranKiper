using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class BludoAddForm : Form
    {
        string picFileName = "picture.jpg";
        List<Categoriya> categoriyas = new List<Categoriya>();

        CategoriyaFromDB categoriyaFromDB = new CategoriyaFromDB();

        List<Produckt> productikas = new List<Produckt>();

        ProducktFromDB producktFromDB = new ProducktFromDB();

        BludaFromDB bludaFromDB = new BludaFromDB();
        public BludoAddForm()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"..\..\Images\picture.jpg");
        }
        private void comboBox_Category_Load()
        {
            categoriyas = categoriyaFromDB.LoadCategories();
            comboBox_Category.DataSource = categoriyas;
            comboBox_Category.DisplayMember = "CategoryName";
            comboBox_Category.ValueMember = "Id";
        }
        private void comboBox_Prod_Load()
        {
            productikas = producktFromDB.LoadProduckt();
            comboBox_Prod.DataSource = productikas;
            comboBox_Prod.DisplayMember = "Produck";
            comboBox_Prod.ValueMember = "Id";
        }

        private void button_Add_Prod_Click(object sender, EventArgs e)
        {
            if (!DulicateRows(comboBox_Prod.Text))
            {
                dataGridView1.Rows.Add(comboBox_Prod.Text, textBox_Prod_Ves.Text);
            }
        }
        private bool DulicateRows(string selectProd)
        {
            bool isDublicate = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == selectProd)
                {
                    isDublicate = true;
                    MessageBox.Show("Такой продукт уже есть!");
                    break;
                }
            }
            return isDublicate;
        }

        private void button_Del_Prod_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                picFileName = Path.GetFileName(openFileDialog.FileName);
                string distinPath = @"..\..\Images\" + picFileName;
                if (!File.Exists(distinPath))
                {
                    fileInfo.CopyTo(distinPath);
                }
                pictureBox1.Image = Image.FromFile(distinPath);
            }
        }

        private void BludoAddForm_Load(object sender, EventArgs e)
        {
            comboBox_Category_Load();
            comboBox_Prod_Load();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string picPath = @"..\..\Images\" + picFileName;
            Bludo newBludo = new Bludo(0, textBox_Name.Text, comboBox_Category.Text, textBox_Osnova.Text, Convert.ToInt32(textBox_Ves.Text), picPath);
            List<Resept> resept = new List<Resept>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                resept.Add(new Resept(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value)));
            }
            bludaFromDB.AddNewBludo(newBludo, resept, Convert.ToInt32(comboBox_Category.SelectedValue), picPath);
            Close();
        }
    }
}
