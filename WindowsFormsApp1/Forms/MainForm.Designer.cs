namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.блюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрБлюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удолитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продукиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьпарольToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.Label();
            this.Kategoria_Lable = new System.Windows.Forms.Label();
            this.PoisckBluda__Lable = new System.Windows.Forms.Label();
            this.poisckBluda__TextBox = new System.Windows.Forms.TextBox();
            this.comboBox_cat = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SostavBluda_ListBox = new System.Windows.Forms.ListBox();
            this.SostavBluda_Lable = new System.Windows.Forms.Label();
            this.IdNameOfBluda_lable = new System.Windows.Forms.Label();
            this.button_ClLb = new System.Windows.Forms.Button();
            this.label_KolvoZap = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.блюдаToolStripMenuItem,
            this.продукиToolStripMenuItem,
            this.рецептToolStripMenuItem,
            this.пользовательToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(846, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // блюдаToolStripMenuItem
            // 
            this.блюдаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрБлюдаToolStripMenuItem,
            this.добавитьБлюдоToolStripMenuItem,
            this.удолитьБлюдоToolStripMenuItem});
            this.блюдаToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.dish;
            this.блюдаToolStripMenuItem.Name = "блюдаToolStripMenuItem";
            this.блюдаToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.блюдаToolStripMenuItem.Text = "Блюда";
            // 
            // просмотрБлюдаToolStripMenuItem
            // 
            this.просмотрБлюдаToolStripMenuItem.Name = "просмотрБлюдаToolStripMenuItem";
            this.просмотрБлюдаToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.просмотрБлюдаToolStripMenuItem.Text = "Просмотр блюд";
            // 
            // добавитьБлюдоToolStripMenuItem
            // 
            this.добавитьБлюдоToolStripMenuItem.Name = "добавитьБлюдоToolStripMenuItem";
            this.добавитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.добавитьБлюдоToolStripMenuItem.Text = "Добавить блюдо";
            this.добавитьБлюдоToolStripMenuItem.Click += new System.EventHandler(this.добавитьБлюдоToolStripMenuItem_Click);
            // 
            // удолитьБлюдоToolStripMenuItem
            // 
            this.удолитьБлюдоToolStripMenuItem.Name = "удолитьБлюдоToolStripMenuItem";
            this.удолитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.удолитьБлюдоToolStripMenuItem.Text = "Удолить блюдо";
            this.удолитьБлюдоToolStripMenuItem.Click += new System.EventHandler(this.удолитьБлюдоToolStripMenuItem_Click);
            // 
            // продукиToolStripMenuItem
            // 
            this.продукиToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.diet;
            this.продукиToolStripMenuItem.Name = "продукиToolStripMenuItem";
            this.продукиToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.продукиToolStripMenuItem.Text = "Продукты";
            this.продукиToolStripMenuItem.Click += new System.EventHandler(this.продукиToolStripMenuItem_Click);
            // 
            // рецептToolStripMenuItem
            // 
            this.рецептToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.recipe;
            this.рецептToolStripMenuItem.Name = "рецептToolStripMenuItem";
            this.рецептToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
            this.рецептToolStripMenuItem.Text = "Рецепт";
            this.рецептToolStripMenuItem.Click += new System.EventHandler(this.рецептToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьПрофильToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem,
            this.сменитьпарольToolStripMenuItem1});
            this.пользовательToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.profil;
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(120, 28);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // редактироватьПрофильToolStripMenuItem
            // 
            this.редактироватьПрофильToolStripMenuItem.Name = "редактироватьПрофильToolStripMenuItem";
            this.редактироватьПрофильToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.редактироватьПрофильToolStripMenuItem.Text = "Редактировать профиль";
            this.редактироватьПрофильToolStripMenuItem.Click += new System.EventHandler(this.редактироватьПрофильToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // сменитьпарольToolStripMenuItem1
            // 
            this.сменитьпарольToolStripMenuItem1.Name = "сменитьпарольToolStripMenuItem1";
            this.сменитьпарольToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.сменитьпарольToolStripMenuItem1.Text = "Сменить пароль";
            this.сменитьпарольToolStripMenuItem1.Click += new System.EventHandler(this.сменитьпарольToolStripMenuItem1_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.ForeColor = System.Drawing.Color.Red;
            this.Menu.Location = new System.Drawing.Point(336, 24);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(125, 46);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Меню";
            // 
            // Kategoria_Lable
            // 
            this.Kategoria_Lable.AutoSize = true;
            this.Kategoria_Lable.Location = new System.Drawing.Point(355, 92);
            this.Kategoria_Lable.Name = "Kategoria_Lable";
            this.Kategoria_Lable.Size = new System.Drawing.Size(60, 13);
            this.Kategoria_Lable.TabIndex = 2;
            this.Kategoria_Lable.Text = "Категория";
            // 
            // PoisckBluda__Lable
            // 
            this.PoisckBluda__Lable.AutoSize = true;
            this.PoisckBluda__Lable.Location = new System.Drawing.Point(46, 92);
            this.PoisckBluda__Lable.Name = "PoisckBluda__Lable";
            this.PoisckBluda__Lable.Size = new System.Drawing.Size(75, 13);
            this.PoisckBluda__Lable.TabIndex = 2;
            this.PoisckBluda__Lable.Text = "Поиск Блюда";
            // 
            // poisckBluda__TextBox
            // 
            this.poisckBluda__TextBox.Location = new System.Drawing.Point(127, 89);
            this.poisckBluda__TextBox.Name = "poisckBluda__TextBox";
            this.poisckBluda__TextBox.Size = new System.Drawing.Size(194, 20);
            this.poisckBluda__TextBox.TabIndex = 3;
            this.poisckBluda__TextBox.TextChanged += new System.EventHandler(this.poisckBluda__TextBox_TextChanged);
            // 
            // comboBox_cat
            // 
            this.comboBox_cat.FormattingEnabled = true;
            this.comboBox_cat.Location = new System.Drawing.Point(421, 89);
            this.comboBox_cat.Name = "comboBox_cat";
            this.comboBox_cat.Size = new System.Drawing.Size(150, 21);
            this.comboBox_cat.TabIndex = 4;
            this.comboBox_cat.SelectedIndexChanged += new System.EventHandler(this.comboBox_cat_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 55;
            this.dataGridView1.Size = new System.Drawing.Size(594, 269);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Картинка";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Название";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Категория";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Основа";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Вес";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // SostavBluda_ListBox
            // 
            this.SostavBluda_ListBox.FormattingEnabled = true;
            this.SostavBluda_ListBox.Location = new System.Drawing.Point(612, 132);
            this.SostavBluda_ListBox.Name = "SostavBluda_ListBox";
            this.SostavBluda_ListBox.Size = new System.Drawing.Size(193, 238);
            this.SostavBluda_ListBox.TabIndex = 6;
            // 
            // SostavBluda_Lable
            // 
            this.SostavBluda_Lable.AutoSize = true;
            this.SostavBluda_Lable.Location = new System.Drawing.Point(612, 116);
            this.SostavBluda_Lable.Name = "SostavBluda_Lable";
            this.SostavBluda_Lable.Size = new System.Drawing.Size(78, 13);
            this.SostavBluda_Lable.TabIndex = 7;
            this.SostavBluda_Lable.Text = "Состав блюда";
            // 
            // IdNameOfBluda_lable
            // 
            this.IdNameOfBluda_lable.AutoSize = true;
            this.IdNameOfBluda_lable.Location = new System.Drawing.Point(697, 116);
            this.IdNameOfBluda_lable.Name = "IdNameOfBluda_lable";
            this.IdNameOfBluda_lable.Size = new System.Drawing.Size(35, 13);
            this.IdNameOfBluda_lable.TabIndex = 8;
            this.IdNameOfBluda_lable.Text = "label1";
            // 
            // button_ClLb
            // 
            this.button_ClLb.Location = new System.Drawing.Point(615, 377);
            this.button_ClLb.Name = "button_ClLb";
            this.button_ClLb.Size = new System.Drawing.Size(190, 23);
            this.button_ClLb.TabIndex = 9;
            this.button_ClLb.Text = "Очистить";
            this.button_ClLb.UseVisualStyleBackColor = true;
            this.button_ClLb.Click += new System.EventHandler(this.button_ClLb_Click);
            // 
            // label_KolvoZap
            // 
            this.label_KolvoZap.AutoSize = true;
            this.label_KolvoZap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_KolvoZap.Location = new System.Drawing.Point(12, 404);
            this.label_KolvoZap.Name = "label_KolvoZap";
            this.label_KolvoZap.Size = new System.Drawing.Size(117, 20);
            this.label_KolvoZap.TabIndex = 10;
            this.label_KolvoZap.Text = "label_KolvoZap";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.label_KolvoZap);
            this.Controls.Add(this.button_ClLb);
            this.Controls.Add(this.IdNameOfBluda_lable);
            this.Controls.Add(this.SostavBluda_Lable);
            this.Controls.Add(this.SostavBluda_ListBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_cat);
            this.Controls.Add(this.poisckBluda__TextBox);
            this.Controls.Add(this.PoisckBluda__Lable);
            this.Controls.Add(this.Kategoria_Lable);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ООО\"Кулинарное поле эксперементов\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem блюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продукиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрБлюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удолитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Label Kategoria_Lable;
        private System.Windows.Forms.Label PoisckBluda__Lable;
        private System.Windows.Forms.TextBox poisckBluda__TextBox;
        private System.Windows.Forms.ComboBox comboBox_cat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox SostavBluda_ListBox;
        private System.Windows.Forms.Label SostavBluda_Lable;
        private System.Windows.Forms.Label IdNameOfBluda_lable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьпарольToolStripMenuItem1;
        private System.Windows.Forms.Button button_ClLb;
        private System.Windows.Forms.Label label_KolvoZap;
    }
}

