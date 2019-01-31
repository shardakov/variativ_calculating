using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    //вычисление вероятностей
    public class Mathematic_probability
    {
        public Data data;
        public Mathematic_probability(Data _data)
        {
            data = _data;
        }

        public void Calc_probability()
        {
            two_one();
            two_two();
            two_three();
            two_four();
            two_five();
            two_six();
            two_seven();
            two_eight();
            two_nine();
            two_ten();
            two_eleven();
            two_twelve();
            two_thirteen();
        }

        //2.4
        private void two_one ()
        {
           for (int i = 0; i < data.I; i++)
           {
               double tmp_pzi = 0;
               for (int j = 0; j < data.A; j++)
               {
                   tmp_pzi += data.Tmp_d[i, j];
               }
               data.Pzi[i] = tmp_pzi;
           } 
        }
        //2.5
        private void two_two()
        {
            for (int i = 0; i < data.I; i++)
            {
                double tmp_ppi = 0;
                for (int j = data.B; j < data.I; j++)
                {
                    tmp_ppi += data.Tmp_d[i, j];
                }
                data.Ppi[i] = tmp_ppi;
            }
        }
        //2.6
        private void two_three()
        {
            for (int i = 0; i < data.I; i++)
            {
                double tmp_qi = 0;
                for (int j = data.A; j < data.B; j++)
                {
                    tmp_qi += data.Tmp_d[i, j] * data.Tmp_b[i, i];
                }
                data.Qi[i] = tmp_qi;
            }
        }
        //2.7
        private void two_four()
         {
            for (int i = 0; i < data.I; i++)
            {
                double tmp_fi = 0;
                for (int j = data.A; j < data.B; j++)
                {
                    tmp_fi += (data.Tmp_d[i, j] * data.Tmp_b[i, 0]);
                }
                data.Fi[i] = tmp_fi;
            }
         }
            //2.8
        private void two_five()
        {
            double pz1;
            double summ1 = 0;
            double tmp;
            for (int i = data.A; i < data.B; i++)
            {
                summ1 = summ1 + (data.Tmp_s[i] * ((data.Fi[i] * data.Pzi[0]) / ((1 - data.Qi[0]) - (1 - data.Qi[i])))) * ((((1 - Math.Pow(data.Qi[i], data.L)) / (1 - data.Qi[i])) - ((1 - Math.Pow(data.Qi[0], data.L)) / (1 - data.Qi[0]))));
            }
            pz1 = data.Tmp_s[0] * data.Pzi[0] * ((1 - Math.Pow(data.Qi[0], data.L)) / (1 - data.Qi[0]));
            tmp = pz1 + summ1;
            data.Pz1 = tmp;
        }   
            //2.9
        private void two_six()
        {
            double ppp1;
            double tmp_ppp1;
            double summ2 = 0;
            tmp_ppp1 = data.Tmp_s[0] * Math.Pow(data.Qi[0], data.L);
            for (int i = data.A; i < data.B; i++)
            {
                summ2 = summ2 + data.Tmp_s[i] * data.Fi[i] * ((Math.Pow(data.Qi[i], data.L) - Math.Pow(data.Qi[0], data.L)) / (data.Qi[i] - data.Qi[0]));
            }
            ppp1 = tmp_ppp1 + summ2;
            data.Ppp1 = ppp1;
        }
            //2.10
        private void two_seven()
        {
            double pp1;
            double summ3 = 0;
            double tmp_Pp1;
            for (int i = data.A; i < data.B; i++)
            {
                summ3 = summ3 + (data.Tmp_s[i] * ((data.Fi[i] * data.Ppi[0]) / ((1 - data.Qi[0]) - (1 - data.Qi[i])))) * ((((1 - Math.Pow(data.Qi[i], data.L)) / (1 - data.Qi[i])) - ((1 - Math.Pow(data.Qi[0], data.L)) / (1 - data.Qi[0]))));
            }
            pp1 = data.Tmp_s[0] * data.Ppi[0] * ((1 - Math.Pow(data.Qi[0], data.L)) / (1 - data.Qi[0]));
            tmp_Pp1 = pp1 + summ3;
            data.Pp1 = tmp_Pp1;
        }
            //2.11
        private void two_eight()
        {
            double p2zi = 0;
            for (int i = data.A; i < data.B; i++)
            {
                p2zi = p2zi + data.Tmp_s[i] * data.Pzi[i] * ((1 - Math.Pow(data.Qi[i], data.L)) / (1 - data.Qi[i]));
            }
            data.P2zi = p2zi;
        }
            //2.12
        private void two_nine()
        {
            double p2ppi = 0;
            for (int i = data.A; i < data.B; i++)
            {
                p2ppi = p2ppi + data.Tmp_s[i] * Math.Pow(data.Qi[i], data.L);
            }
            data.P2ppi = p2ppi;
        }
            //2.13
        private void two_ten()
        {
            double p2pi = 0;
            for (int i = data.A; i < data.B; i++)
            {
                p2pi = p2pi + data.Tmp_s[i] * data.Ppi[i] * ((1 - Math.Pow(data.Qi[i], data.L)) / (1 - data.Qi[i]));
            }
            data.P2pi = p2pi;
        }
            //2.14
        private void two_eleven()
        {
            double p3zi = 0;
            for (int i = data.B; i < data.I; i++)
            {
                p3zi = p3zi + data.Tmp_s[i] * data.Pzi[i] * ((1 - Math.Pow(data.Qi[i], data.L)) / (1 - data.Qi[i]));
            }
            data.P3zi = p3zi;
        }
            //2.15
        private void two_twelve()
        {
            double p3ppi = 0;
            for (int i = data.B; i < data.I; i++)
            {
                p3ppi = p3ppi + data.Tmp_s[i] * Math.Pow(data.Qi[i], data.L);
            }
            data.P3ppi = p3ppi;
        }
            //2.16
        private void two_thirteen()
        {
            double p3pi = 0;
            for (int i = data.B; i < data.I; i++)
            {
                p3pi = p3pi + data.Tmp_s[i] * data.Ppi[i] * ((1 - Math.Pow(data.Qi[i], data.L)) / (1 - data.Qi[i]));
            }
            data.P3pi = p3pi;
        }
    }

    //вычисление мат. ожиданий
    public class Mathematic_expectation
    { 
        public Data data;
        public Mathematic_expectation(Data _data)
        {
            data = _data;
        }

        public void Calc_expectation()
        {
            meth_mzi();
            meth_mpi();
            meth_mppi();
            meth_mfi();
            meth_MMzi();
            meth_MMpi();
            meth_MMppi();
            meth_MMz1i();
            meth_MMp1i();
            meth_MMpp1i();
            meth_MOz1();
            meth_MOpp1();
            meth_MOp1();
            meth_MO2z();
            meth_MO2pp();
            meth_MO2p();
            meth_MO3z();
            meth_MO3pp();
            meth_MO3p();
        }

        //3.3
        private void meth_mzi()
        {
            for (int i = 0; i < data.I; i++)
            {
                double tmp_mzi = 0;
                for (int j = 0; j < data.A; j++)
                {
                    tmp_mzi += (data.Tmp_d[i, j] * data.Tmp_md[i, j]);
                }
                data.Mzi[i] = tmp_mzi * (Math.Pow(data.Pzi[i], -1));
            }
        }

            //3.4
        private void meth_mpi()
        {
            for (int i = 0; i < data.I; i++)
            {
                double tmp_mpi = 0;
                for (int j = data.B; j < data.I; j++)
                {
                    tmp_mpi += (data.Tmp_d[i, j] * data.Tmp_md[i, j]);
                }
                data.Mpi[i] = tmp_mpi * (Math.Pow(data.Ppi[i], -1));
            }
        }

            //3.5
        private void meth_mppi()
        {
            for (int i = 0; i < data.I; i++)
            {
                double tmp_mppi_ch = 0;
                double tmp_mppi_zn = 0;
                for (int j = data.A; j < data.B; j++)
                {
                    tmp_mppi_ch += (data.Tmp_d[i, j] * data.Tmp_md[i, j]);
                    tmp_mppi_zn += data.Tmp_d[i, j];
                }
                data.Mppi[i] = (tmp_mppi_ch / tmp_mppi_zn) + data.Tmp_mv[i, i];
            }
        }

            //3.6
        private void meth_mfi()
        {
            for (int i = 0; i < data.I; i++)
            {
                double tmp_mfi_ch = 0;
                double tmp_mfi_zn = 0;
                for (int j = data.A; j < data.B; j++)
                {
                    tmp_mfi_ch += (data.Tmp_d[i, j] * data.Tmp_md[i, j]);
                    tmp_mfi_zn += data.Tmp_d[i, j];
                }
                data.Mfi[i] = (tmp_mfi_ch / tmp_mfi_zn) + data.Tmp_mv[i, 0];
            }
        }

            //3.7
        private void meth_MMzi()
        {
            double[] MMzi = new double[data.I];
            for (int i = 0; i < data.I; i++)
            {
                double tmp_MMzi = 0; 
                for (int j = 1; j <= data.L; j++)
                {
                    tmp_MMzi += (data.Mzi[i] + ((j - 1) * data.Mppi[i])) * Math.Pow(data.Qi[i], (j - 1));
                }
                MMzi[i] = data.Pzi[i] * tmp_MMzi;
            }
            data.mMzi = MMzi;
        }

            //3.8
        private void meth_MMpi()
        {
            double[] MMpi = new double[data.I];
            for (int i = 0; i < data.I; i++)
            {
                double tmp_MMpi = 0;
                for (int j = 1; j <= data.L; j++)
                {
                    tmp_MMpi += (data.Mpi[i] + ((j - 1) * data.Mppi[i])) * Math.Pow(data.Qi[i], (j - 1));
                }
                MMpi[i] = data.Ppi[i] * tmp_MMpi;
            }
            data.mMpi = MMpi;
        }

            //3.9
        private void meth_MMppi()
        {
            double[] MMppi = new double[data.I];
            for (int i = 0; i < data.I; i++)
            {
                MMppi[i] = data.L * data.Mppi[i] * Math.Pow(data.Qi[i],data.L);
            }
            data.mMppi = MMppi;
        }

            //3.10 
        private void meth_MMz1i()
        {
            double[] MMz1i = new double[data.I];
            for (int i = 0; i < data.I; i++)
            {
                double tmp_MMz1i = 0;
                for (int L = 2; L <= data.L; L++)
                {
                    for (int k = 1; k <= L-1; k++)
                    {
                        tmp_MMz1i += ((L - 1 - k) * data.Mppi[i] + data.Mfi[i] + (k - 1) * data.Mppi[0] + data.Mzi[0]) * Math.Pow(data.Qi[i], (L - 1 - k)) * Math.Pow(data.Qi[0], (k - 1));
                    }
                }
                MMz1i[i] = data.Fi[i] * data.Pzi[0] * tmp_MMz1i;
            }
            data.mMz1i = MMz1i;
        }

            //3.11
        private void meth_MMp1i()
        {
            double[] MMp1i = new double[data.I];
            for (int i = 0; i < data.I; i++)
            {
                double tmp_MMp1i = 0;
                for (int L = 2; L <= data.L; L++)
                {
                    for (int k = 1; k <= L - 1; k++)
                    {
                        tmp_MMp1i += ((L - 1 - k) * data.Mppi[i] + data.Mfi[i] + (k - 1) * data.Mppi[0] + data.Mpi[0]) * Math.Pow(data.Qi[i], (L - 1 - k)) * Math.Pow(data.Qi[0], (k - 1));
                    }
                }
                MMp1i[i] = data.Fi[i] * data.Ppi[0] * tmp_MMp1i;
            }
            data.mMp1i = MMp1i;
        }

            //3.12
        private void meth_MMpp1i()
        {
            double[] MMpp1i = new double[data.I];
            for (int i = 0; i < data.I; i++)
            {
                double tmp_MMpp1i = 0;
                for (int L = 0; L <= data.L-1; L++)
                {
                    tmp_MMpp1i += ((data.L - L - 1) * data.Mppi[i] + data.Mfi[i] + L * data.Mppi[0]) * Math.Pow((data.Qi[0] / data.Qi[i]), L);
                }
                MMpp1i[i] = data.Fi[i] * Math.Pow(data.Qi[i], data.L - 1) * tmp_MMpp1i;
            }
            data.mMpp1i = MMpp1i;
        }

            //3.13
        private void meth_MOz1()
        {
            double MOz1 = 0;
            double tmp_MOz1 = 0;
            for (int i = 1; i < data.I; i++)
            {
                tmp_MOz1 += data.Tmp_s[i] * data.mMz1i[i];
            }
            MOz1 = data.Tmp_s[0] * data.mMzi[0] + tmp_MOz1;
            data.mOz1 = MOz1;
        }

            //3.14
        private void meth_MOpp1()
        {
            double MOpp1 = 0;
            double tmp_MOpp1 = 0;
            for (int i = 1; i < data.I; i++)
            {
                tmp_MOpp1 += data.Tmp_s[i] * data.mMpp1i[i];
            }
            MOpp1 = data.Tmp_s[0] * data.L * data.Mppi[0] * Math.Pow(data.Qi[0], data.L) + tmp_MOpp1;
            data.mOpp1 = MOpp1;
        }

            //3.15
        private void meth_MOp1()
        {
            double MOp1 = 0;
            double tmp_MOp1 = 0;
            for (int i = 1; i < data.I; i++)
            {
                tmp_MOp1 += data.Tmp_s[i] * data.mMp1i[i];
            }
            MOp1 = data.Tmp_s[0] * data.mMpi[0] + tmp_MOp1;
            data.mOp1 = MOp1;
        }

            //3.16
        private void meth_MO2z()
        {
            double MO2z = 0;
            for (int i = data.A; i < data.B; i++)
            {
                MO2z += data.Tmp_s[i] * data.mMzi[i];
            }
            data.mO2z = MO2z;
        }

            //3.17
        private void meth_MO2pp()
        {
            double MO2pp = 0;
            for (int i = data.A; i < data.B; i++)
            {
                MO2pp += data.Tmp_s[i] * data.L * data.Mppi[i] * Math.Pow(data.Qi[i], data.L);
            }
            data.mO2pp = MO2pp;
        }

            //3.18
        private void meth_MO2p()
        {
            double MO2p = 0;
            for (int i = data.A; i < data.B; i++)
            {
                MO2p += data.Tmp_s[i] * data.mMpi[i];
            }
            data.mO2p = MO2p;
        }

            //3.19
        private void meth_MO3z()
        {
            double MO3z = 0;
            for (int i = data.B; i < data.I; i++)
            {
                MO3z += data.Tmp_s[i] * data.mMzi[i];
            }
            data.mO3z = MO3z;
        }

            //3.20
        private void meth_MO3pp()
        {
            double MO3pp = 0;
            for (int i = data.B; i < data.I; i++)
            {
                MO3pp += data.Tmp_s[i] * data.L * data.Mppi[i] * Math.Pow(data.Qi[i], data.L);
            }
            data.mO3pp = MO3pp;
        }

            //3.21
        private void meth_MO3p()
        {
            double MO3p = 0;
            for (int i = data.B; i < data.I; i++)
            {
                MO3p += data.Tmp_s[i] * data.mMpi[i];
            }
            data.mO3p = MO3p;
        }
    }

    }
