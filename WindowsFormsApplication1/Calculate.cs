using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculate : Form
    {
        private Data data;
        public Calculate(Data _data)
        {
            InitializeComponent();
            data = _data;

            //вероятности
            text_p2pi.Text = Convert.ToString(data.P2pi);
            text_p2ppi.Text = Convert.ToString(data.P2ppi);
            text_p2zi.Text = Convert.ToString(data.P2zi);
            text_p3pi.Text = Convert.ToString(data.P3pi);
            text_p3ppi.Text = Convert.ToString(data.P3ppi);
            text_p3zi.Text = Convert.ToString(data.P3zi);
            text_pp1.Text = Convert.ToString(data.Pp1);
            text_ppp1.Text = Convert.ToString(data.Ppp1);
            text_pz1.Text = Convert.ToString(data.Pz1);

            //мат ожидания
            text_MO2p.Text = Convert.ToString(data.mO2p);
            text_MO2pp.Text = Convert.ToString(data.mO2pp);
            text_MO2z.Text = Convert.ToString(data.mO2z);
            text_MO3p.Text = Convert.ToString(data.mO3p);
            text_MO3pp.Text = Convert.ToString(data.mO3pp);
            text_MO3z.Text = Convert.ToString(data.mO3z);
            text_MOp1.Text = Convert.ToString(data.mOp1);
            text_MOpp1.Text = Convert.ToString(data.mOpp1);
            text_MOz1.Text = Convert.ToString(data.mOz1);
        
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
