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
    public partial class Window_md : Form
    {
        private Data data;
        public Window_md(Data _data)
        {
            InitializeComponent();
            data = _data;

            DataTable dataTable = new DataTable();
            for (int ii = 0; ii < data.I; ii++)
                dataTable.Columns.Add();
            for (int jj = 0; jj < data.I; jj++)
                dataTable.Rows.Add();
            dataGrid_md.DataSource = dataTable;

            for (int ii = 0; ii < data.I; ii++)
            {
                for (int jj = 0; jj < data.I; jj++)
                {
                    dataGrid_md.Rows[jj].Cells[ii].Value = 0;
                }
            }
        }

        private void btn_save_md_Click(object sender, EventArgs e)
        {
            data.Tmp_md = new double[dataGrid_md.RowCount, dataGrid_md.ColumnCount];
            for (int n = 0; n < dataGrid_md.RowCount; n++)
            {
                for (int m = 0; m < dataGrid_md.ColumnCount; m++)
                {
                    string str = (dataGrid_md.Rows[n].Cells[m].Value).ToString().Replace('.', ',');
                    data.Tmp_md[n, m] = Convert.ToInt32(str);
                }
            }
        }

        private void btn_clear_md_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid_md.RowCount; i++)
            {
                for (int j = 0; j < dataGrid_md.ColumnCount; j++)
                {
                    dataGrid_md.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        private void btn_close_md_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}