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
    public partial class Window_d : Form
    {
        private Data data;
        public Window_d(Data _data)
        {
            InitializeComponent();
            data = _data;

            DataTable dataTable = new DataTable();
            for (int ii = 0; ii < data.I; ii++)
                dataTable.Columns.Add();
            for (int jj = 0; jj < data.I; jj++)
                dataTable.Rows.Add();
            dataGrid_d.DataSource = dataTable;

            for (int ii = 0; ii < data.I; ii++)
            {
                for (int jj = 0; jj < data.I; jj++)
                {
                    dataGrid_d.Rows[jj].Cells[ii].Value = 0;
                }
            }
            
        }

        // test new array
        public Array mass_save(Array tmp)
        {

            return tmp;
        }
        //

        public void btn_save_d_Click(object sender, EventArgs e)
        {
            data.Tmp_d = new double[dataGrid_d.RowCount, dataGrid_d.ColumnCount];
            for (int n = 0; n < dataGrid_d.RowCount; n++)
            {
                for (int m = 0; m < dataGrid_d.ColumnCount; m++)
                {
                    string str = (dataGrid_d.Rows[n].Cells[m].Value).ToString().Replace('.', ',');
                    data.Tmp_d[n, m] = Convert.ToDouble(str);
                }
            }
        }

        private void btn_clear_d_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid_d.RowCount; i++)
            {
                for (int j = 0; j < dataGrid_d.ColumnCount; j++)
                {
                    dataGrid_d.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        private void btn_close_d_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
