namespace WindowsFormsApp1
{
    partial class AddProd
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
            this.Addproduct = new System.Windows.Forms.Label();
            this.NameProd_lable = new System.Windows.Forms.Label();
            this.textBox_NameProd = new System.Windows.Forms.TextBox();
            this.textBox_belki = new System.Windows.Forms.TextBox();
            this.belki_lable = new System.Windows.Forms.Label();
            this.textBox_Jiri = new System.Windows.Forms.TextBox();
            this.Jiri_lable = new System.Windows.Forms.Label();
            this.textBox_Ugle = new System.Windows.Forms.TextBox();
            this.Ugle_lable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addproduct
            // 
            this.Addproduct.AutoSize = true;
            this.Addproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addproduct.Location = new System.Drawing.Point(269, 34);
            this.Addproduct.Name = "Addproduct";
            this.Addproduct.Size = new System.Drawing.Size(276, 35);
            this.Addproduct.TabIndex = 0;
            this.Addproduct.Text = "Добавить продукт";
            // 
            // NameProd_lable
            // 
            this.NameProd_lable.AutoSize = true;
            this.NameProd_lable.Location = new System.Drawing.Point(212, 128);
            this.NameProd_lable.Name = "NameProd_lable";
            this.NameProd_lable.Size = new System.Drawing.Size(57, 13);
            this.NameProd_lable.TabIndex = 1;
            this.NameProd_lable.Text = "Название";
            // 
            // textBox_NameProd
            // 
            this.textBox_NameProd.Location = new System.Drawing.Point(275, 125);
            this.textBox_NameProd.Name = "textBox_NameProd";
            this.textBox_NameProd.Size = new System.Drawing.Size(230, 20);
            this.textBox_NameProd.TabIndex = 2;
            // 
            // textBox_belki
            // 
            this.textBox_belki.Location = new System.Drawing.Point(275, 171);
            this.textBox_belki.Name = "textBox_belki";
            this.textBox_belki.Size = new System.Drawing.Size(230, 20);
            this.textBox_belki.TabIndex = 4;
            // 
            // belki_lable
            // 
            this.belki_lable.AutoSize = true;
            this.belki_lable.Location = new System.Drawing.Point(231, 174);
            this.belki_lable.Name = "belki_lable";
            this.belki_lable.Size = new System.Drawing.Size(38, 13);
            this.belki_lable.TabIndex = 3;
            this.belki_lable.Text = "Белки";
            // 
            // textBox_Jiri
            // 
            this.textBox_Jiri.Location = new System.Drawing.Point(275, 212);
            this.textBox_Jiri.Name = "textBox_Jiri";
            this.textBox_Jiri.Size = new System.Drawing.Size(230, 20);
            this.textBox_Jiri.TabIndex = 6;
            // 
            // Jiri_lable
            // 
            this.Jiri_lable.AutoSize = true;
            this.Jiri_lable.Location = new System.Drawing.Point(234, 212);
            this.Jiri_lable.Name = "Jiri_lable";
            this.Jiri_lable.Size = new System.Drawing.Size(38, 13);
            this.Jiri_lable.TabIndex = 5;
            this.Jiri_lable.Text = "Жиры";
            // 
            // textBox_Ugle
            // 
            this.textBox_Ugle.Location = new System.Drawing.Point(275, 253);
            this.textBox_Ugle.Name = "textBox_Ugle";
            this.textBox_Ugle.Size = new System.Drawing.Size(230, 20);
            this.textBox_Ugle.TabIndex = 8;
            // 
            // Ugle_lable
            // 
            this.Ugle_lable.AutoSize = true;
            this.Ugle_lable.Location = new System.Drawing.Point(214, 256);
            this.Ugle_lable.Name = "Ugle_lable";
            this.Ugle_lable.Size = new System.Drawing.Size(58, 13);
            this.Ugle_lable.TabIndex = 7;
            this.Ugle_lable.Text = "Углеводы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Ugle);
            this.Controls.Add(this.Ugle_lable);
            this.Controls.Add(this.textBox_Jiri);
            this.Controls.Add(this.Jiri_lable);
            this.Controls.Add(this.textBox_belki);
            this.Controls.Add(this.belki_lable);
            this.Controls.Add(this.textBox_NameProd);
            this.Controls.Add(this.NameProd_lable);
            this.Controls.Add(this.Addproduct);
            this.Name = "AddProd";
            this.Text = "AddProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Addproduct;
        private System.Windows.Forms.Label NameProd_lable;
        private System.Windows.Forms.TextBox textBox_NameProd;
        private System.Windows.Forms.TextBox textBox_belki;
        private System.Windows.Forms.Label belki_lable;
        private System.Windows.Forms.TextBox textBox_Jiri;
        private System.Windows.Forms.Label Jiri_lable;
        private System.Windows.Forms.TextBox textBox_Ugle;
        private System.Windows.Forms.Label Ugle_lable;
        private System.Windows.Forms.Button button1;
    }
}