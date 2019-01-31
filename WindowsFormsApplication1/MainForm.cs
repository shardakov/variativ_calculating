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
    public partial class MainForm : Form
    {
        private readonly Data data;
        private readonly Mathematic_probability math;
        private readonly Mathematic_expectation math_ex;

        public MainForm()
        {
            InitializeComponent();
            data = new Data();
            math = new Mathematic_probability(data);
            math_ex = new Mathematic_expectation(data);
        }


        private void set_cicle_btn_Click(object sender, EventArgs e)
        {
            data.L = Convert.ToInt32(ltextBox.Text);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
           DialogResult dt = MessageBox.Show("Вы уверены что хотите закрыть приложение?","Закрытие приложения", MessageBoxButtons.YesNo);
           if (dt == DialogResult.Yes)
               Close();
        }

        private void d_btn_Click(object sender, EventArgs e)
        {
            data.I = Convert.ToInt32(itextBox.Text);
            Window_for_btn.Window_d window = new Window_for_btn.Window_d(data);
            window.ShowDialog();
        }

        private void b_btn_Click(object sender, EventArgs e)
        {
            data.I = Convert.ToInt32(itextBox.Text);
            Window_for_btn.Window_b window = new Window_for_btn.Window_b(data);
            window.ShowDialog();
        }


        private void S_btn_Click(object sender, EventArgs e)
        {

            data.I = Convert.ToInt32(itextBox.Text);
            Window_for_btn.Window_s window = new Window_for_btn.Window_s(data);
            window.ShowDialog();
        }


        public Data Data
        {
            get { return data; }
            
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                data.A = Convert.ToInt32(atextBox.Text);
                data.B = Convert.ToInt32(btextBox.Text);
                data.L = Convert.ToInt32(ltextBox.Text);
                math.Calc_probability();
                math_ex.Calc_expectation();
                Calculate window = new Calculate(data);
                window.ShowDialog();
            }

            catch (System.NullReferenceException)
            {
                DialogResult dt = MessageBox.Show("Проверьте корректность ввода данных, а также ознакомьтесь со справкой", "Ошибка", MessageBoxButtons.OK);
            }
            

        }

        private void md_btn_Click(object sender, EventArgs e)
        {
            data.I = Convert.ToInt32(itextBox.Text);
            Window_for_btn.Window_md window = new Window_for_btn.Window_md(data);
            window.ShowDialog();
        }

        private void mv_btn_Click(object sender, EventArgs e)
        {
            data.I = Convert.ToInt32(itextBox.Text);
            Window_for_btn.Window_mv window = new Window_for_btn.Window_mv(data);
            window.ShowDialog();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            help window = new help();
            window.ShowDialog();
        }


      
        
    }
}
