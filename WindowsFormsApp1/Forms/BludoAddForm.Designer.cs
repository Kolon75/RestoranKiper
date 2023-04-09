namespace WindowsFormsApp1.Forms
{
    partial class BludoAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Select = new System.Windows.Forms.Button();
            this.button_Add_Prod = new System.Windows.Forms.Button();
            this.button_Del_Prod = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Osnova = new System.Windows.Forms.TextBox();
            this.textBox_Ves = new System.Windows.Forms.TextBox();
            this.textBox_Prod_Ves = new System.Windows.Forms.TextBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Prod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(396, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_Select
            // 
            this.button_Select.Location = new System.Drawing.Point(639, 9);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(107, 33);
            this.button_Select.TabIndex = 1;
            this.button_Select.Text = "Выбрать";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // button_Add_Prod
            // 
            this.button_Add_Prod.Location = new System.Drawing.Point(445, 211);
            this.button_Add_Prod.Name = "button_Add_Prod";
            this.button_Add_Prod.Size = new System.Drawing.Size(102, 23);
            this.button_Add_Prod.TabIndex = 2;
            this.button_Add_Prod.Text = "Добаить";
            this.button_Add_Prod.UseVisualStyleBackColor = true;
            this.button_Add_Prod.Click += new System.EventHandler(this.button_Add_Prod_Click);
            // 
            // button_Del_Prod
            // 
            this.button_Del_Prod.Location = new System.Drawing.Point(445, 241);
            this.button_Del_Prod.Name = "button_Del_Prod";
            this.button_Del_Prod.Size = new System.Drawing.Size(102, 23);
            this.button_Del_Prod.TabIndex = 3;
            this.button_Del_Prod.Text = "Удалить";
            this.button_Del_Prod.UseVisualStyleBackColor = true;
            this.button_Del_Prod.Click += new System.EventHandler(this.button_Del_Prod_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(639, 399);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(149, 39);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название Блюда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Основа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(265, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Добавить состав блюда";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(38, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Продукт";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(234, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Вес";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(41, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(390, 180);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Продукт";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Вес";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(137, 9);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(154, 20);
            this.textBox_Name.TabIndex = 13;
            // 
            // textBox_Osnova
            // 
            this.textBox_Osnova.Location = new System.Drawing.Point(137, 64);
            this.textBox_Osnova.Name = "textBox_Osnova";
            this.textBox_Osnova.Size = new System.Drawing.Size(154, 20);
            this.textBox_Osnova.TabIndex = 14;
            // 
            // textBox_Ves
            // 
            this.textBox_Ves.Location = new System.Drawing.Point(137, 90);
            this.textBox_Ves.Name = "textBox_Ves";
            this.textBox_Ves.Size = new System.Drawing.Size(154, 20);
            this.textBox_Ves.TabIndex = 15;
            // 
            // textBox_Prod_Ves
            // 
            this.textBox_Prod_Ves.Location = new System.Drawing.Point(268, 214);
            this.textBox_Prod_Ves.Name = "textBox_Prod_Ves";
            this.textBox_Prod_Ves.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prod_Ves.TabIndex = 16;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(137, 37);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(154, 21);
            this.comboBox_Category.TabIndex = 17;
            // 
            // comboBox_Prod
            // 
            this.comboBox_Prod.FormattingEnabled = true;
            this.comboBox_Prod.Location = new System.Drawing.Point(107, 214);
            this.comboBox_Prod.Name = "comboBox_Prod";
            this.comboBox_Prod.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Prod.TabIndex = 18;
            // 
            // BludoAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Prod);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.textBox_Prod_Ves);
            this.Controls.Add(this.textBox_Ves);
            this.Controls.Add(this.textBox_Osnova);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Del_Prod);
            this.Controls.Add(this.button_Add_Prod);
            this.Controls.Add(this.button_Select);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BludoAddForm";
            this.Text = "BludoAddForm";
            this.Load += new System.EventHandler(this.BludoAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Button button_Add_Prod;
        private System.Windows.Forms.Button button_Del_Prod;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Osnova;
        private System.Windows.Forms.TextBox textBox_Ves;
        private System.Windows.Forms.TextBox textBox_Prod_Ves;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Prod;
    }
}