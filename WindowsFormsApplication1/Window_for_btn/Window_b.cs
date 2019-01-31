using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Window_for_btn
{
    public partial class Window_b : Form
    {
        private Data data;

        public Window_b(Data _data)
        {
            InitializeComponent();
            data = _data;

            DataTable dataTable = new DataTable();
            for (int ii = 0; ii < data.I; ii++)
                dataTable.Columns.Add();
            for (int jj = 0; jj < data.I; jj++)
                dataTable.Rows.Add();
            dataGrid_b.DataSource = dataTable;
            
            for (int ii = 0; ii < data.I; ii++)
            {
                for (int jj = 0; jj < data.I; jj++)
                {
                    dataGrid_b.Rows[jj].Cells[ii].Value = 0;
                }
            }
             
        }

        public void btn_save_b_Click(object sender, EventArgs e)
        {
            data.Tmp_b = new double[dataGrid_b.RowCount, dataGrid_b.ColumnCount];
            for (int n = 0; n < dataGrid_b.RowCount; n++)
            {
                for (int m = 0; m < dataGrid_b.ColumnCount; m++)
                {
                    string str = (dataGrid_b.Rows[n].Cells[m].Value).ToString().Replace('.', ',');
                    data.Tmp_b[n, m] = Convert.ToDouble(str);
                }
            }
        }

        private void btn_clear_b_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid_b.RowCount; i++)
            {
                for (int j = 0; j < dataGrid_b.ColumnCount; j++)
                {
                    dataGrid_b.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        private void btn_close_b_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        
    }
}
