namespace WindowsFormsApplication1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.itextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ltextBox = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.S_btn = new System.Windows.Forms.Button();
            this.d_btn = new System.Windows.Forms.Button();
            this.b_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.md_btn = new System.Windows.Forms.Button();
            this.mv_btn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.btextBox = new System.Windows.Forms.TextBox();
            this.atextBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(11, 19);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(690, 35);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Количество технических состояний в которых может находиться исследуемый объект (r" +
    ")";
            // 
            // itextBox
            // 
            this.itextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itextBox.Location = new System.Drawing.Point(707, 19);
            this.itextBox.Multiline = true;
            this.itextBox.Name = "itextBox";
            this.itextBox.Size = new System.Drawing.Size(33, 35);
            this.itextBox.TabIndex = 6;
            this.itextBox.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(11, 60);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(690, 30);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Ограничение на число возможных циклов (l) ";
            // 
            // ltextBox
            // 
            this.ltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltextBox.Location = new System.Drawing.Point(707, 60);
            this.ltextBox.Multiline = true;
            this.ltextBox.Name = "ltextBox";
            this.ltextBox.Size = new System.Drawing.Size(33, 30);
            this.ltextBox.TabIndex = 12;
            this.ltextBox.Text = "0";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox12.Location = new System.Drawing.Point(409, 178);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(266, 55);
            this.textBox12.TabIndex = 16;
            this.textBox12.Text = "Вероятностные характеристики безошибочности восстановления (B)\r\n";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox13.Location = new System.Drawing.Point(11, 178);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(266, 57);
            this.textBox13.TabIndex = 17;
            this.textBox13.Text = "Характеристики безопасности диагностирования (D)";
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox14.Location = new System.Drawing.Point(11, 241);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(266, 57);
            this.textBox14.TabIndex = 18;
            this.textBox14.Text = "Вероятность нахождения объекта в одном из начальных технических состояний вероятн" +
    "остей (S)\r\n\r\n";
            // 
            // S_btn
            // 
            this.S_btn.Location = new System.Drawing.Point(283, 241);
            this.S_btn.Name = "S_btn";
            this.S_btn.Size = new System.Drawing.Size(59, 23);
            this.S_btn.TabIndex = 19;
            this.S_btn.Text = "Задать";
            this.S_btn.UseVisualStyleBackColor = true;
            this.S_btn.Click += new System.EventHandler(this.S_btn_Click);
            // 
            // d_btn
            // 
            this.d_btn.Location = new System.Drawing.Point(283, 178);
            this.d_btn.Name = "d_btn";
            this.d_btn.Size = new System.Drawing.Size(59, 23);
            this.d_btn.TabIndex = 20;
            this.d_btn.Text = "Задать";
            this.d_btn.UseVisualStyleBackColor = true;
            this.d_btn.Click += new System.EventHandler(this.d_btn_Click);
            // 
            // b_btn
            // 
            this.b_btn.Location = new System.Drawing.Point(681, 178);
            this.b_btn.Name = "b_btn";
            this.b_btn.Size = new System.Drawing.Size(59, 23);
            this.b_btn.TabIndex = 21;
            this.b_btn.Text = "Задать";
            this.b_btn.UseVisualStyleBackColor = true;
            this.b_btn.Click += new System.EventHandler(this.b_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.close_btn.AutoSize = true;
            this.close_btn.Location = new System.Drawing.Point(56, 560);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 24;
            this.close_btn.Text = "Закрыть";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(45, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(518, 116);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Расчет вероятностных и моментных характеристик типового блока операций «Диагности" +
    "рование с восстановлением при организации на число циклов восстановления»";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.md_btn);
            this.groupBox1.Controls.Add(this.mv_btn);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.btextBox);
            this.groupBox1.Controls.Add(this.atextBox);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.S_btn);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.itextBox);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.b_btn);
            this.groupBox1.Controls.Add(this.ltextBox);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.d_btn);
            this.groupBox1.Location = new System.Drawing.Point(45, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 384);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // md_btn
            // 
            this.md_btn.Location = new System.Drawing.Point(682, 241);
            this.md_btn.Name = "md_btn";
            this.md_btn.Size = new System.Drawing.Size(58, 23);
            this.md_btn.TabIndex = 36;
            this.md_btn.Text = "Задать";
            this.md_btn.UseVisualStyleBackColor = true;
            this.md_btn.Click += new System.EventHandler(this.md_btn_Click);
            // 
            // mv_btn
            // 
            this.mv_btn.Location = new System.Drawing.Point(284, 304);
            this.mv_btn.Name = "mv_btn";
            this.mv_btn.Size = new System.Drawing.Size(58, 23);
            this.mv_btn.TabIndex = 35;
            this.mv_btn.Text = "Задать";
            this.mv_btn.UseVisualStyleBackColor = true;
            this.mv_btn.Click += new System.EventHandler(this.mv_btn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(409, 241);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(266, 57);
            this.textBox4.TabIndex = 34;
            this.textBox4.Text = "Условные математические ожидания затрат ресурсов на выполнение операций диагности" +
    "рования (md)";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(11, 304);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(266, 57);
            this.textBox11.TabIndex = 33;
            this.textBox11.Text = "Условные математические ожидания затрат ресурсов на выполнение операций восстанов" +
    "ления (mv)";
            // 
            // btextBox
            // 
            this.btextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btextBox.Location = new System.Drawing.Point(707, 133);
            this.btextBox.Multiline = true;
            this.btextBox.Name = "btextBox";
            this.btextBox.Size = new System.Drawing.Size(33, 32);
            this.btextBox.TabIndex = 32;
            this.btextBox.Text = "0";
            // 
            // atextBox
            // 
            this.atextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.atextBox.Location = new System.Drawing.Point(707, 96);
            this.atextBox.Multiline = true;
            this.atextBox.Name = "atextBox";
            this.atextBox.Size = new System.Drawing.Size(33, 31);
            this.atextBox.TabIndex = 31;
            this.atextBox.Text = "0";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(11, 133);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(690, 32);
            this.textBox9.TabIndex = 30;
            this.textBox9.Text = "Количество состояний, при которых процесс считается прерванным (b)";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(11, 96);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(690, 31);
            this.textBox7.TabIndex = 29;
            this.textBox7.Text = "Количество состояний, при которых процесс считается завершенным (a)";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(651, 560);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(140, 23);
            this.btn_calc.TabIndex = 27;
            this.btn_calc.Text = "Рассчитать";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Dwoc;
            this.pictureBox1.Location = new System.Drawing.Point(610, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(354, 560);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 28;
            this.btn_help.Text = "Справка";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(830, 595);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox itextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox ltextBox;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button S_btn;
        private System.Windows.Forms.Button d_btn;
        private System.Windows.Forms.Button b_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox btextBox;
        private System.Windows.Forms.TextBox atextBox;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button md_btn;
        private System.Windows.Forms.Button mv_btn;
        private System.Windows.Forms.Button btn_help;
    }
}

