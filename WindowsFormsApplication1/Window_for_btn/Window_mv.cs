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
    public partial class Window_mv : Form
    {
        private Data data;
        public Window_mv(Data _data)
        {
            InitializeComponent();
            data = _data;

            DataTable dataTable = new DataTable();
            for (int ii = 0; ii < data.I; ii++)
                dataTable.Columns.Add();
            for (int jj = 0; jj < data.I; jj++)
                dataTable.Rows.Add();
            dataGrid_mv.DataSource = dataTable;

            for (int ii = 0; ii < data.I; ii++)
            {
                for (int jj = 0; jj < data.I; jj++)
                {
                    dataGrid_mv.Rows[jj].Cells[ii].Value = 0;
                }
            }
        }

        private void btn_save_mv_Click(object sender, EventArgs e)
        {
            data.Tmp_mv = new double[dataGrid_mv.RowCount, dataGrid_mv.ColumnCount];
            for (int n = 0; n < dataGrid_mv.RowCount; n++)
            {
                for (int m = 0; m < dataGrid_mv.ColumnCount; m++)
                {
                    string str = (dataGrid_mv.Rows[n].Cells[m].Value).ToString().Replace('.', ',');
                    data.Tmp_mv[n, m] = Convert.ToInt32(str);
                }
            }
        }

        private void btn_clear_mv_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid_mv.RowCount; i++)
            {
                for (int j = 0; j < dataGrid_mv.ColumnCount; j++)
                {
                    dataGrid_mv.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        private void btn_close_mv_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
