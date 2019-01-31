namespace WindowsFormsApplication1.Window_for_btn
{
    partial class Window_mv
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
            this.btn_clear_mv = new System.Windows.Forms.Button();
            this.btn_close_mv = new System.Windows.Forms.Button();
            this.btn_save_mv = new System.Windows.Forms.Button();
            this.dataGrid_mv = new System.Windows.Forms.DataGridView();
            this.label_mv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_mv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear_mv
            // 
            this.btn_clear_mv.Location = new System.Drawing.Point(209, 336);
            this.btn_clear_mv.Name = "btn_clear_mv";
            this.btn_clear_mv.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_mv.TabIndex = 15;
            this.btn_clear_mv.Text = "Очистить";
            this.btn_clear_mv.UseVisualStyleBackColor = true;
            this.btn_clear_mv.Click += new System.EventHandler(this.btn_clear_mv_Click);
            // 
            // btn_close_mv
            // 
            this.btn_close_mv.Location = new System.Drawing.Point(308, 336);
            this.btn_close_mv.Name = "btn_close_mv";
            this.btn_close_mv.Size = new System.Drawing.Size(75, 23);
            this.btn_close_mv.TabIndex = 14;
            this.btn_close_mv.Text = "Закрыть";
            this.btn_close_mv.UseVisualStyleBackColor = true;
            this.btn_close_mv.Click += new System.EventHandler(this.btn_close_mv_Click);
            // 
            // btn_save_mv
            // 
            this.btn_save_mv.Location = new System.Drawing.Point(105, 336);
            this.btn_save_mv.Name = "btn_save_mv";
            this.btn_save_mv.Size = new System.Drawing.Size(75, 23);
            this.btn_save_mv.TabIndex = 13;
            this.btn_save_mv.Text = "Сохранить";
            this.btn_save_mv.UseVisualStyleBackColor = true;
            this.btn_save_mv.Click += new System.EventHandler(this.btn_save_mv_Click);
            // 
            // dataGrid_mv
            // 
            this.dataGrid_mv.AllowUserToAddRows = false;
            this.dataGrid_mv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGrid_mv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_mv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_mv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid_mv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_mv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_mv.ColumnHeadersVisible = false;
            this.dataGrid_mv.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_mv.Location = new System.Drawing.Point(105, 81);
            this.dataGrid_mv.Name = "dataGrid_mv";
            this.dataGrid_mv.RowHeadersVisible = false;
            this.dataGrid_mv.Size = new System.Drawing.Size(278, 224);
            this.dataGrid_mv.TabIndex = 12;
            // 
            // label_mv
            // 
            this.label_mv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_mv.AutoSize = true;
            this.label_mv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mv.Location = new System.Drawing.Point(160, 32);
            this.label_mv.Name = "label_mv";
            this.label_mv.Size = new System.Drawing.Size(188, 24);
            this.label_mv.TabIndex = 11;
            this.label_mv.Text = "Заполните матрицу";
            // 
            // Window_mv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 390);
            this.Controls.Add(this.btn_clear_mv);
            this.Controls.Add(this.btn_close_mv);
            this.Controls.Add(this.btn_save_mv);
            this.Controls.Add(this.dataGrid_mv);
            this.Controls.Add(this.label_mv);
            this.Name = "Window_mv";
            this.Text = "Window_mv";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_mv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear_mv;
        private System.Windows.Forms.Button btn_close_mv;
        private System.Windows.Forms.Button btn_save_mv;
        private System.Windows.Forms.DataGridView dataGrid_mv;
        private System.Windows.Forms.Label label_mv;

    }
}