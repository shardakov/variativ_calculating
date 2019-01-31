using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Data
    {
        //переменные из главной формы
        private int i;
        private int l;
        private int a;
        private int b;

        //переменные из класса Mathematic для вероятностей

        private double pz1;
        private double ppp1;
        private double pp1;
        private double p2zi;
        private double p2ppi;
        private double p2pi;
        private double p3zi;
        private double p3ppi;
        private double p3pi;

        //переменные из класса Mathematic для математических ожиданий

        private double MOz1;
        private double MOpp1;
        private double MOp1;
        private double MO2z;
        private double MO2pp;
        private double MO2p;
        private double MO3z;
        private double MO3pp;
        private double MO3p;

        //массивы из дополнительных окон
        private double[,] tmp_b;
        private double[,] tmp_d;
        private double[,] tmp_dd;
        private double[,] tmp_dv;
        private double[,] tmp_Matrix;
        private double[,] tmp_md;
        private double[,] tmp_mv;
        private double[] tmp_s;
        
        //
        private double[] pzi;
        private double[] ppi;
        private double[] fi;
        private double[] qi;

        //
        private double[] mzi;
        private double[] mpi;
        private double[] mppi;
        private double[] mfi;
        private double[] MMzi;
        private double[] MMpi;
        private double[] MMppi;
        private double[] MMz1i;
        private double[] MMp1i;
        private double[] MMpp1i;
        
        //
        public int I
        {
            get { return i; }
            set
            {
                if (i == value)
                    return;
                i = value;
                pzi = new double[i];
                ppi = new double[i];
                fi = new double[i];
                qi = new double[i];
                mzi = new double[i];
                mpi = new double[i];
                mppi = new double[i];
                mfi = new double[i];
                MMzi = new double[i];
                MMpi = new double[i];
                MMppi = new double[i];
                MMz1i = new double[i];
                MMp1i = new double[i];
                MMpp1i = new double[i];
            }
        }
        
        public int L
        {
            get { return l; }
            set
            {
                if (l == value)
                    return;
                l = value;
            }
        }

        public int A
        {
            get { return a; }
            set
            {
                if (a == value)
                    return;
                a = value;
            }
        }

        public int B
        {
            get { return b; }
            set
            {
                if (b == value)
                    return;
                b = value;
            }
        }
        //
        public double Pz1
        {
            get { return pz1; }
            set
            {
                if (pz1 == value)
                    return;
                pz1 = value;
            }
        }
        public double Ppp1
        {
            get { return ppp1; }
            set
            {
                if (ppp1 == value)
                    return;
                ppp1 = value;
            }
        }
        public double Pp1
        {
            get { return pp1; }
            set
            {
                if (pp1 == value)
                    return;
                pp1 = value;
            }
        }
        public double P2zi
        {
            get { return p2zi; }
            set
            {
                if (p2zi == value)
                    return;
                p2zi = value;
            }
        }
        public double P2ppi
        {
            get { return p2ppi; }
            set
            {
                if (p2ppi == value)
                    return;
                p2ppi = value;
            }
        }
        public double P2pi
        {
            get { return p2pi; }
            set
            {
                if (p2pi == value)
                    return;
                p2pi = value;
            }
        }
        public double P3zi
        {
            get { return p3zi; }
            set
            {
                if (p3zi == value)
                    return;
                p3zi = value;
            }
        }
        public double P3ppi
        {
            get { return p3ppi; }
            set
            {
                if (p3ppi == value)
                    return;
                p3ppi = value;
            }
        }
        public double P3pi
        {
            get { return p3pi; }
            set
            {
                if (p3pi == value)
                    return;
                p3pi = value;
            }
        }
        //
        public double mOz1
        {
            get { return MOz1; }
            set
            {
                if (MOz1 == value)
                    return;
                MOz1 = value;
            }
        }
        public double mOpp1
        {
            get { return MOpp1; }
            set
            {
                if (MOpp1 == value)
                    return;
                MOpp1 = value;
            }
        }
        public double mOp1
        {
            get { return MOp1; }
            set
            {
                if (MOp1 == value)
                    return;
                MOp1 = value;
            }
        }
        public double mO2z
        {
            get { return MO2z; }
            set
            {
                if (MO2z == value)
                    return;
                MO2z = value;
            }
        }
        public double mO2pp
        {
            get { return MO2pp; }
            set
            {
                if (MO2pp == value)
                    return;
                MO2pp = value;
            }
        }
        public double mO2p
        {
            get { return MO2p; }
            set
            {
                if (MO2p == value)
                    return;
                MO2p = value;
            }
        }
        public double mO3z
        {
            get { return MO3z; }
            set
            {
                if (MO3z == value)
                    return;
                MO3z = value;
            }
        }
        public double mO3pp
        {
            get { return MO3pp; }
            set
            {
                if (MO3pp == value)
                    return;
                MO3pp = value;
            }
        }
        public double mO3p
        {
            get { return MO3p; }
            set
            {
                if (MO3p == value)
                    return;
                MO3p = value;
            }
        }
        //
        public double[,] Tmp_b
        {
            get { return tmp_b; }
            set
            {
                if (tmp_b == value)
                    return;
                tmp_b = value;
            }
        }

        public double[,] Tmp_d
        {
            get { return tmp_d; }
            set
            {
                if (tmp_d == value)
                    return;
                tmp_d = value;
            }
        }

        public double[,] Tmp_dd
        {
            get { return tmp_dd; }
            set
            {
                if (tmp_dd == value)
                    return;
                tmp_dd = value;
            }
        }

        public double[,] Tmp_dv
        {
            get { return tmp_dv; }
            set
            {
                if (tmp_dv == value)
                    return;
                tmp_dv = value;
            }
        }

        public double[,] Tmp_Matrix
        {
            get { return tmp_Matrix; }
            set
            {
                if (tmp_Matrix == value)
                    return;
                tmp_Matrix = value;
            }
        }

        public double[,] Tmp_md
        {
            get { return tmp_md; }
            set
            {
                if (tmp_md == value)
                    return;
                tmp_md = value;
            }
        }

        public double[,] Tmp_mv
        {
            get { return tmp_mv; }
            set
            {
                if (tmp_mv == value)
                    return;
                tmp_mv = value;
            }
        }
        public double[] Tmp_s
        {
            get { return tmp_s; }
            set
            {
                if (tmp_s == value)
                    return;
                tmp_s = value;
            }
        }

        //
        public double[] Pzi
        {
            get { return pzi; }
            set
            {
                if (pzi == value)
                    return;
                pzi = value;
            }
        }
        public double[] Ppi
        {
            get { return ppi; }
            set
            {
                if (ppi == value)
                    return;
                ppi = value;
            }
        }
        public double[] Fi
        {
            get { return fi; }
            set
            {
                if (fi == value)
                    return;
                fi = value;
            }
        }
        public double[] Qi
        {
            get { return qi; }
            set
            {
                if (qi == value)
                    return;
                qi = value;
            }
        }

        //
        public double[] Mzi
        {
            get { return mzi; }
            set
            {
                if (mzi == value)
                    return;
                mzi = value;
            }
        }
        public double[] Mpi
        {
            get { return mpi; }
            set
            {
                if (mpi == value)
                    return;
                mpi = value;
            }
        }
        public double[] Mppi
        {
            get { return mppi; }
            set
            {
                if (mppi == value)
                    return;
                mppi = value;
            }
        }
        public double[] Mfi
        {
            get { return mfi; }
            set
            {
                if (mfi == value)
                    return;
                mfi = value;
            }
        }
        //
        public double[] mMzi
        {
            get { return MMzi; }
            set
            {
                if (MMzi == value)
                    return;
                MMzi = value;
            }
        }
        public double[] mMpi
        {
            get { return MMpi; }
            set
            {
                if (MMpi == value)
                    return;
                MMpi = value;
            }
        }
        public double[] mMppi
        {
            get { return MMppi; }
            set
            {
                if (MMppi == value)
                    return;
                MMppi = value;
            }
        }
        public double[] mMz1i
        {
            get { return MMz1i; }
            set
            {
                if (MMz1i == value)
                    return;
                MMz1i = value;
            }
        }
        public double[] mMp1i
        {
            get { return MMp1i; }
            set
            {
                if (MMp1i == value)
                    return;
                MMp1i = value;
            }
        }
        public double[] mMpp1i
        {
            get { return MMpp1i; }
            set
            {
                if (MMpp1i == value)
                    return;
                MMpp1i = value;
            }
        }

    }
}
