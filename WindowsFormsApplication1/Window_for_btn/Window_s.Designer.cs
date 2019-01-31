namespace WindowsFormsApplication1.Window_for_btn
{
    partial class Window_s
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
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_s = new System.Windows.Forms.Label();
            this.dataGrid_s = new System.Windows.Forms.DataGridView();
            this.btn_save_s = new System.Windows.Forms.Button();
            this.btn_close_s = new System.Windows.Forms.Button();
            this.btn_clear_s = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_s)).BeginInit();
            this.SuspendLayout();
            // 
            // label_s
            // 
            this.label_s.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_s.AutoSize = true;
            this.label_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_s.Location = new System.Drawing.Point(163, 24);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(188, 24);
            this.label_s.TabIndex = 1;
            this.label_s.Text = "Заполните матрицу";
            // 
            // dataGrid_s
            // 
            this.dataGrid_s.AllowUserToAddRows = false;
            this.dataGrid_s.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGrid_s.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_s.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_s.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid_s.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_s.ColumnHeadersVisible = false;
            this.dataGrid_s.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_s.Location = new System.Drawing.Point(108, 73);
            this.dataGrid_s.Name = "dataGrid_s";
            this.dataGrid_s.RowHeadersVisible = false;
            this.dataGrid_s.Size = new System.Drawing.Size(278, 224);
            this.dataGrid_s.TabIndex = 2;
            // 
            // btn_save_s
            // 
            this.btn_save_s.Location = new System.Drawing.Point(108, 328);
            this.btn_save_s.Name = "btn_save_s";
            this.btn_save_s.Size = new System.Drawing.Size(75, 23);
            this.btn_save_s.TabIndex = 3;
            this.btn_save_s.Text = "Сохранить";
            this.btn_save_s.UseVisualStyleBackColor = true;
            this.btn_save_s.Click += new System.EventHandler(this.btn_save_s_Click);
            // 
            // btn_close_s
            // 
            this.btn_close_s.Location = new System.Drawing.Point(311, 328);
            this.btn_close_s.Name = "btn_close_s";
            this.btn_close_s.Size = new System.Drawing.Size(75, 23);
            this.btn_close_s.TabIndex = 4;
            this.btn_close_s.Text = "Закрыть";
            this.btn_close_s.UseVisualStyleBackColor = true;
            this.btn_close_s.Click += new System.EventHandler(this.btn_close_s_Click);
            // 
            // btn_clear_s
            // 
            this.btn_clear_s.Location = new System.Drawing.Point(212, 328);
            this.btn_clear_s.Name = "btn_clear_s";
            this.btn_clear_s.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_s.TabIndex = 5;
            this.btn_clear_s.Text = "Очистить";
            this.btn_clear_s.UseVisualStyleBackColor = true;
            this.btn_clear_s.Click += new System.EventHandler(this.btn_clear_s_Click);
            // 
            // Window_s
            // 
            this.ClientSize = new System.Drawing.Size(529, 402);
            this.Controls.Add(this.btn_clear_s);
            this.Controls.Add(this.btn_close_s);
            this.Controls.Add(this.btn_save_s);
            this.Controls.Add(this.dataGrid_s);
            this.Controls.Add(this.label_s);
            this.Name = "Window_s";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_s)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.DataGridView dataGrid_s;
        private System.Windows.Forms.Button btn_save_s;
        private System.Windows.Forms.Button btn_close_s;
        private System.Windows.Forms.Button btn_clear_s;
    }
}