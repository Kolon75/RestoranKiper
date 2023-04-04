namespace WindowsFormsApp1
{
    partial class Autorization
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
            this.Welcome = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Reg = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.button_Log_In = new System.Windows.Forms.Button();
            this.button_Reg = new System.Windows.Forms.Button();
            this.groupBox_Captcha = new System.Windows.Forms.GroupBox();
            this.textBox_Captcha = new System.Windows.Forms.TextBox();
            this.pictureBox_Captcha = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Captcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome.Location = new System.Drawing.Point(12, 9);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(390, 31);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Добро пожаловать в систему!";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(14, 109);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(55, 20);
            this.Login.TabIndex = 1;
            this.Login.Text = "Логин";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(14, 151);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 20);
            this.Password.TabIndex = 2;
            this.Password.Text = "Пароль";
            // 
            // Reg
            // 
            this.Reg.AutoSize = true;
            this.Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg.Location = new System.Drawing.Point(85, 246);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(136, 13);
            this.Reg.TabIndex = 3;
            this.Reg.Text = "Ещё нет учётной записи?";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(87, 109);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(157, 23);
            this.textBox_Login.TabIndex = 4;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Pass.Location = new System.Drawing.Point(87, 151);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(157, 23);
            this.textBox_Pass.TabIndex = 5;
            // 
            // button_Log_In
            // 
            this.button_Log_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Log_In.Location = new System.Drawing.Point(87, 216);
            this.button_Log_In.Name = "button_Log_In";
            this.button_Log_In.Size = new System.Drawing.Size(134, 27);
            this.button_Log_In.TabIndex = 6;
            this.button_Log_In.Text = "Войти";
            this.button_Log_In.UseVisualStyleBackColor = true;
            this.button_Log_In.Click += new System.EventHandler(this.button_Log_In_Click);
            // 
            // button_Reg
            // 
            this.button_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Reg.Location = new System.Drawing.Point(87, 262);
            this.button_Reg.Name = "button_Reg";
            this.button_Reg.Size = new System.Drawing.Size(134, 28);
            this.button_Reg.TabIndex = 7;
            this.button_Reg.Text = "Зарегестрироваться";
            this.button_Reg.UseVisualStyleBackColor = true;
            this.button_Reg.Click += new System.EventHandler(this.button_Reg_Click);
            // 
            // groupBox_Captcha
            // 
            this.groupBox_Captcha.Controls.Add(this.textBox_Captcha);
            this.groupBox_Captcha.Controls.Add(this.pictureBox_Captcha);
            this.groupBox_Captcha.Controls.Add(this.label1);
            this.groupBox_Captcha.Location = new System.Drawing.Point(367, 109);
            this.groupBox_Captcha.Name = "groupBox_Captcha";
            this.groupBox_Captcha.Size = new System.Drawing.Size(357, 265);
            this.groupBox_Captcha.TabIndex = 8;
            this.groupBox_Captcha.TabStop = false;
            this.groupBox_Captcha.Text = "Captcha";
            // 
            // textBox_Captcha
            // 
            this.textBox_Captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Captcha.Location = new System.Drawing.Point(12, 224);
            this.textBox_Captcha.Name = "textBox_Captcha";
            this.textBox_Captcha.Size = new System.Drawing.Size(330, 30);
            this.textBox_Captcha.TabIndex = 5;
            // 
            // pictureBox_Captcha
            // 
            this.pictureBox_Captcha.Location = new System.Drawing.Point(12, 50);
            this.pictureBox_Captcha.Name = "pictureBox_Captcha";
            this.pictureBox_Captcha.Size = new System.Drawing.Size(330, 168);
            this.pictureBox_Captcha.TabIndex = 4;
            this.pictureBox_Captcha.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите текст с картинки";
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Captcha);
            this.Controls.Add(this.button_Reg);
            this.Controls.Add(this.button_Log_In);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Welcome);
            this.Name = "Autorization";
            this.Text = "Autorization";
            this.Load += new System.EventHandler(this.Autorization_Load);
            this.groupBox_Captcha.ResumeLayout(false);
            this.groupBox_Captcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Captcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Reg;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Button button_Log_In;
        private System.Windows.Forms.Button button_Reg;
        private System.Windows.Forms.GroupBox groupBox_Captcha;
        private System.Windows.Forms.TextBox textBox_Captcha;
        private System.Windows.Forms.PictureBox pictureBox_Captcha;
        private System.Windows.Forms.Label label1;
    }
}