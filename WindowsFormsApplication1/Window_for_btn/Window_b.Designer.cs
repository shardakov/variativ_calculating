namespace WindowsFormsApplication1.Window_for_btn
{
    partial class Window_b
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_clear_b = new System.Windows.Forms.Button();
            this.btn_close_b = new System.Windows.Forms.Button();
            this.btn_save_b = new System.Windows.Forms.Button();
            this.dataGrid_b = new System.Windows.Forms.DataGridView();
            this.label_b = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_b)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear_b
            // 
            this.btn_clear_b.Location = new System.Drawing.Point(223, 334);
            this.btn_clear_b.Name = "btn_clear_b";
            this.btn_clear_b.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_b.TabIndex = 10;
            this.btn_clear_b.Text = "Очистить";
            this.btn_clear_b.UseVisualStyleBackColor = true;
            this.btn_clear_b.Click += new System.EventHandler(this.btn_clear_b_Click);
            // 
            // btn_close_b
            // 
            this.btn_close_b.Location = new System.Drawing.Point(322, 334);
            this.btn_close_b.Name = "btn_close_b";
            this.btn_close_b.Size = new System.Drawing.Size(75, 23);
            this.btn_close_b.TabIndex = 9;
            this.btn_close_b.Text = "Закрыть";
            this.btn_close_b.UseVisualStyleBackColor = true;
            this.btn_close_b.Click += new System.EventHandler(this.btn_close_b_Click);
            // 
            // btn_save_b
            // 
            this.btn_save_b.Location = new System.Drawing.Point(119, 334);
            this.btn_save_b.Name = "btn_save_b";
            this.btn_save_b.Size = new System.Drawing.Size(75, 23);
            this.btn_save_b.TabIndex = 8;
            this.btn_save_b.Text = "Сохранить";
            this.btn_save_b.UseVisualStyleBackColor = true;
            this.btn_save_b.Click += new System.EventHandler(this.btn_save_b_Click);
            // 
            // dataGrid_b
            // 
            this.dataGrid_b.AllowUserToAddRows = false;
            this.dataGrid_b.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGrid_b.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_b.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_b.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid_b.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_b.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_b.ColumnHeadersVisible = false;
            this.dataGrid_b.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_b.Location = new System.Drawing.Point(119, 79);
            this.dataGrid_b.Name = "dataGrid_b";
            this.dataGrid_b.RowHeadersVisible = false;
            this.dataGrid_b.Size = new System.Drawing.Size(278, 224);
            this.dataGrid_b.TabIndex = 7;
            // 
            // label_b
            // 
            this.label_b.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_b.Location = new System.Drawing.Point(172, 30);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(188, 24);
            this.label_b.TabIndex = 6;
            this.label_b.Text = "Заполните матрицу";
            // 
            // Window_b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 402);
            this.Controls.Add(this.btn_clear_b);
            this.Controls.Add(this.btn_close_b);
            this.Controls.Add(this.btn_save_b);
            this.Controls.Add(this.dataGrid_b);
            this.Controls.Add(this.label_b);
            this.Name = "Window_b";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear_b;
        private System.Windows.Forms.Button btn_close_b;
        private System.Windows.Forms.Button btn_save_b;
        private System.Windows.Forms.DataGridView dataGrid_b;
        private System.Windows.Forms.Label label_b;
    }
}