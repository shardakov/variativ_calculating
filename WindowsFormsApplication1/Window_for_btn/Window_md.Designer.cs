namespace WindowsFormsApplication1.Window_for_btn
{
    partial class Window_md
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
            this.btn_clear_md = new System.Windows.Forms.Button();
            this.btn_close_md = new System.Windows.Forms.Button();
            this.btn_save_md = new System.Windows.Forms.Button();
            this.dataGrid_md = new System.Windows.Forms.DataGridView();
            this.label_md = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_md)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear_md
            // 
            this.btn_clear_md.Location = new System.Drawing.Point(182, 324);
            this.btn_clear_md.Name = "btn_clear_md";
            this.btn_clear_md.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_md.TabIndex = 10;
            this.btn_clear_md.Text = "Очистить";
            this.btn_clear_md.UseVisualStyleBackColor = true;
            this.btn_clear_md.Click += new System.EventHandler(this.btn_clear_md_Click);
            // 
            // btn_close_md
            // 
            this.btn_close_md.Location = new System.Drawing.Point(281, 324);
            this.btn_close_md.Name = "btn_close_md";
            this.btn_close_md.Size = new System.Drawing.Size(75, 23);
            this.btn_close_md.TabIndex = 9;
            this.btn_close_md.Text = "Закрыть";
            this.btn_close_md.UseVisualStyleBackColor = true;
            this.btn_close_md.Click += new System.EventHandler(this.btn_close_md_Click);
            // 
            // btn_save_md
            // 
            this.btn_save_md.Location = new System.Drawing.Point(78, 324);
            this.btn_save_md.Name = "btn_save_md";
            this.btn_save_md.Size = new System.Drawing.Size(75, 23);
            this.btn_save_md.TabIndex = 8;
            this.btn_save_md.Text = "Сохранить";
            this.btn_save_md.UseVisualStyleBackColor = true;
            this.btn_save_md.Click += new System.EventHandler(this.btn_save_md_Click);
            // 
            // dataGrid_md
            // 
            this.dataGrid_md.AllowUserToAddRows = false;
            this.dataGrid_md.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGrid_md.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_md.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_md.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid_md.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_md.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_md.ColumnHeadersVisible = false;
            this.dataGrid_md.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_md.Location = new System.Drawing.Point(78, 69);
            this.dataGrid_md.Name = "dataGrid_md";
            this.dataGrid_md.RowHeadersVisible = false;
            this.dataGrid_md.Size = new System.Drawing.Size(278, 224);
            this.dataGrid_md.TabIndex = 7;
            // 
            // label_md
            // 
            this.label_md.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_md.AutoSize = true;
            this.label_md.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_md.Location = new System.Drawing.Point(133, 20);
            this.label_md.Name = "label_md";
            this.label_md.Size = new System.Drawing.Size(188, 24);
            this.label_md.TabIndex = 6;
            this.label_md.Text = "Заполните матрицу";
            // 
            // Window_md
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 379);
            this.Controls.Add(this.btn_clear_md);
            this.Controls.Add(this.btn_close_md);
            this.Controls.Add(this.btn_save_md);
            this.Controls.Add(this.dataGrid_md);
            this.Controls.Add(this.label_md);
            this.Name = "Window_md";
            this.Text = "Window_md";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_md)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear_md;
        private System.Windows.Forms.Button btn_close_md;
        private System.Windows.Forms.Button btn_save_md;
        private System.Windows.Forms.DataGridView dataGrid_md;
        private System.Windows.Forms.Label label_md;
    }
}