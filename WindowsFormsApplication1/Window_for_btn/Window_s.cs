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
    public partial class Window_s : Form
    {
        private Data data;
        public Window_s(Data _data)
        {
            InitializeComponent();
            data = _data;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add();   
            for (int ii = 0; ii < data.I; ii++)
                dataTable.Rows.Add();
            dataGrid_s.DataSource = dataTable;

            for (int i = 0; i < data.I; i++)
            {
                dataGrid_s.Rows[i].Cells[0].Value = 0;
            }
           
        }

        private void btn_save_s_Click(object sender, EventArgs e)
        {
            data.Tmp_s = new double[dataGrid_s.RowCount];
            for (int n = 0; n < dataGrid_s.RowCount; n++)
            {
                string str = (dataGrid_s.Rows[n].Cells[0].Value).ToString().Replace('.', ',');
                data.Tmp_s[n] = Convert.ToInt32(str);
            }
        }

        private void btn_clear_s_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid_s.RowCount; i++)
            {
                
                    dataGrid_s.Rows[i].Cells[0].Value = 0;
                
            }
        }

        private void btn_close_s_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
