namespace WindowsFormsApp1.Forms
{
    partial class ReseptForm
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
            this.richTextBox_Resept = new System.Windows.Forms.RichTextBox();
            this.listBox_Sostav = new System.Windows.Forms.ListBox();
            this.button_Prev = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_BludoName = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_Resept
            // 
            this.richTextBox_Resept.Location = new System.Drawing.Point(407, 175);
            this.richTextBox_Resept.Name = "richTextBox_Resept";
            this.richTextBox_Resept.Size = new System.Drawing.Size(203, 187);
            this.richTextBox_Resept.TabIndex = 0;
            this.richTextBox_Resept.Text = "";
            // 
            // listBox_Sostav
            // 
            this.listBox_Sostav.FormattingEnabled = true;
            this.listBox_Sostav.Location = new System.Drawing.Point(41, 163);
            this.listBox_Sostav.Name = "listBox_Sostav";
            this.listBox_Sostav.Size = new System.Drawing.Size(139, 199);
            this.listBox_Sostav.TabIndex = 1;
            // 
            // button_Prev
            // 
            this.button_Prev.Location = new System.Drawing.Point(339, 217);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(38, 85);
            this.button_Prev.TabIndex = 2;
            this.button_Prev.Text = "<";
            this.button_Prev.UseVisualStyleBackColor = true;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(640, 213);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(37, 92);
            this.button_Next.TabIndex = 3;
            this.button_Next.Text = ">";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Рецепты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Блюдо:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ингредиенты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(336, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Способ приготовления";
            // 
            // label_BludoName
            // 
            this.label_BludoName.AutoSize = true;
            this.label_BludoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BludoName.Location = new System.Drawing.Point(99, 71);
            this.label_BludoName.Name = "label_BludoName";
            this.label_BludoName.Size = new System.Drawing.Size(81, 17);
            this.label_BludoName.TabIndex = 8;
            this.label_BludoName.Text = "BludoName";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(640, 9);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(43, 26);
            this.button_Add.TabIndex = 9;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(689, 9);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(45, 26);
            this.button_Edit.TabIndex = 10;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(740, 9);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(52, 26);
            this.button_Del.TabIndex = 11;
            this.button_Del.Text = "Del";
            this.button_Del.UseVisualStyleBackColor = true;
            // 
            // ReseptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_BludoName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Prev);
            this.Controls.Add(this.listBox_Sostav);
            this.Controls.Add(this.richTextBox_Resept);
            this.Name = "ReseptForm";
            this.Text = "ReseptForm";
            this.Load += new System.EventHandler(this.ReseptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Resept;
        private System.Windows.Forms.ListBox listBox_Sostav;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_BludoName;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Del;
    }
}