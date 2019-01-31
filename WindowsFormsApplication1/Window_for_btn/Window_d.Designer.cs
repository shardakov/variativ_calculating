namespace WindowsFormsApplication1.Window_for_btn
{
    partial class Window_d
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
            this.label_d = new System.Windows.Forms.Label();
            this.dataGrid_d = new System.Windows.Forms.DataGridView();
            this.btn_save_d = new System.Windows.Forms.Button();
            this.btn_close_d = new System.Windows.Forms.Button();
            this.btn_clear_d = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_d)).BeginInit();
            this.SuspendLayout();
            // 
            // label_d
            // 
            this.label_d.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_d.AutoSize = true;
            this.label_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_d.Location = new System.Drawing.Point(163, 24);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(188, 24);
            this.label_d.TabIndex = 1;
            this.label_d.Text = "Заполните матрицу";
            // 
            // dataGrid_d
            // 
            this.dataGrid_d.AllowUserToAddRows = false;
            this.dataGrid_d.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGrid_d.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_d.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid_d.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_d.ColumnHeadersVisible = false;
            this.dataGrid_d.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_d.Location = new System.Drawing.Point(108, 73);
            this.dataGrid_d.Name = "dataGrid_d";
            this.dataGrid_d.RowHeadersVisible = false;
            this.dataGrid_d.Size = new System.Drawing.Size(278, 224);
            this.dataGrid_d.TabIndex = 2;
            // 
            // btn_save_d
            // 
            this.btn_save_d.Location = new System.Drawing.Point(108, 328);
            this.btn_save_d.Name = "btn_save_d";
            this.btn_save_d.Size = new System.Drawing.Size(75, 23);
            this.btn_save_d.TabIndex = 3;
            this.btn_save_d.Text = "Сохранить";
            this.btn_save_d.UseVisualStyleBackColor = true;
            this.btn_save_d.Click += new System.EventHandler(this.btn_save_d_Click);
            // 
            // btn_close_d
            // 
            this.btn_close_d.Location = new System.Drawing.Point(311, 328);
            this.btn_close_d.Name = "btn_close_d";
            this.btn_close_d.Size = new System.Drawing.Size(75, 23);
            this.btn_close_d.TabIndex = 4;
            this.btn_close_d.Text = "Закрыть";
            this.btn_close_d.UseVisualStyleBackColor = true;
            this.btn_close_d.Click += new System.EventHandler(this.btn_close_d_Click);
            // 
            // btn_clear_d
            // 
            this.btn_clear_d.Location = new System.Drawing.Point(212, 328);
            this.btn_clear_d.Name = "btn_clear_d";
            this.btn_clear_d.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_d.TabIndex = 5;
            this.btn_clear_d.Text = "Очистить";
            this.btn_clear_d.UseVisualStyleBackColor = true;
            this.btn_clear_d.Click += new System.EventHandler(this.btn_clear_d_Click);
            // 
            // Window_d
            // 
            this.ClientSize = new System.Drawing.Size(529, 402);
            this.Controls.Add(this.btn_clear_d);
            this.Controls.Add(this.btn_close_d);
            this.Controls.Add(this.btn_save_d);
            this.Controls.Add(this.dataGrid_d);
            this.Controls.Add(this.label_d);
            this.Name = "Window_d";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_d)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.DataGridView dataGrid_d;
        private System.Windows.Forms.Button btn_save_d;
        private System.Windows.Forms.Button btn_close_d;
        private System.Windows.Forms.Button btn_clear_d;
    }
}