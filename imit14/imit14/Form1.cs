using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imit14
{
    public partial class Form1 : Form
    {
        FirstMethod fm;

        SecondMethod sm;

        ThirdMethod tm;

        Density pl;

        int[] statistic = new int[8];

        double A, Sum, kvadraA, Chi, a;

        decimal[] Freq = new decimal[8];

        decimal MT, M, MErr, DT, D, DErr;

        int k = -4;

        public Form1()
        {
            InitializeComponent();
        }

        private void FirstMethodBtn_Click(object sender, EventArgs e)
        {
            M = 0; D = 0; Chi = 0; Sum = 0; kvadraA = 0; a = -3.5;

            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 8; i++)
            {
                statistic[i] = 0;
            }

            MT = Mean.Value;
            DT = Var.Value;

            fm = new FirstMethod(MT, DT);
            pl = new Density(MT, DT);

            for (int i = 0; i < NumExp.Value; i++)
            {
                A = fm.getNum();
                Sum = Sum + A;
                kvadraA = kvadraA + A * A;
                k = -4;
                for (int j = 0; j < 8; j++)
                {
                    if (A < k + 1 && A > k)
                    {
                        statistic[j]++;
                        break;
                    }
                    k++;
                }
            }

            for (int j = 0; j < 8; j++)
            {
                Freq[j] = statistic[j] / NumExp.Value;
                chart1.Series[0].Points.AddXY(j, Freq[j]);
            }

            M = (decimal)Sum / NumExp.Value;
            D = (decimal)kvadraA / NumExp.Value - M * M;

            ChiCounter();

            errorCounter();

            writer();
        }

        private void SecondMethodBtn_Click(object sender, EventArgs e)
        {
            M = 0; D = 0; Chi = 0; Sum = 0; kvadraA = 0; a = -3.5;

            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 8; i++)
            {
                statistic[i] = 0;
            }

            MT = Mean.Value;
            DT = Var.Value;

            sm = new SecondMethod(MT, DT);
            pl = new Density(MT, DT);
            for (int i = 0; i < NumExp.Value; i++)
            {
                A = sm.getNum();
                Sum = Sum + A;
                kvadraA = kvadraA + A * A;
                k = -4;
                for (int j = 0; j < 8; j++)
                {
                    if (A < k + 1 && A > k)
                    {
                        statistic[j]++;
                        break;
                    }
                    k++;
                }
            }
            for (int j = 0; j < 8; j++)
            {
                Freq[j] = statistic[j] / NumExp.Value;
                chart1.Series[0].Points.AddXY(j, Freq[j]);
            }

            M = (decimal)Sum / NumExp.Value;
            D = (decimal)kvadraA / NumExp.Value - M * M;

            ChiCounter();

            errorCounter();

            writer();
        }

        private void ThirdMethodBtn_Click(object sender, EventArgs e)
        {
            M = 0; D = 0; Chi = 0; Sum = 0; kvadraA = 0; a = -3.5;
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 8; i++)
            {
                statistic[i] = 0;
            }

            MT = Mean.Value;
            DT = Var.Value;

            tm = new ThirdMethod(MT, DT);
            pl = new Density(MT, DT);

            for (int i = 0; i < NumExp.Value; i++)
            {
                A = tm.getNum();
                Sum = Sum + A;
                kvadraA = kvadraA + A * A;
                k = -4;
                for (int j = 0; j < 8; j++)
                {
                    if (A < k + 1 && A > k)
                    {
                        statistic[j]++;
                        break;
                    }
                    k++;
                }
            }

            for (int j = 0; j < 8; j++)
            {
                Freq[j] = statistic[j] / NumExp.Value;
                chart1.Series[0].Points.AddXY(j, Freq[j]);
            }

            M = (decimal)Sum / NumExp.Value;

            D = (decimal)kvadraA / NumExp.Value - M * M;

            ChiCounter();
            errorCounter();

            writer();
            
        }

       

        void writer()
        {
            AverageLbl.Text = "Average: " + M + " (error = " + Math.Round(MErr * 100, 5) + "%)";
            VarianceLbl.Text = "Variance: " + D + " (error = " + Math.Round(DErr * 100, 5) + "%)";
            if (Chi > 15.507)
            {
                Chi1Lbl.Text = "Chi-squared: " + Chi + " > 15.507 is true";
            }
            else { Chi1Lbl.Text = "Chi-squared: " + Chi + " > 15.507 is false"; }
        }

        void errorCounter()
        {
            if (MT != 0)
            {
                MErr = Math.Abs(M - MT) / MT;
            }
            else { MErr = 0; }
            if (DT != 0)
            {
                DErr = Math.Abs(D - DT) / DT;
            }
            else { DErr = 0; }
        }

        void ChiCounter()
        {
            for (int j = 0; j < 8; j++)
            {

                Chi = Chi + ((statistic[j] * statistic[j]) / ((double)NumExp.Value * pl.getP(a)));
                a++;
            }
            Chi = Chi - (double)NumExp.Value;
        }
    }
}
