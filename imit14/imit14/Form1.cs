using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace imit14
{
    public partial class Form1 : Form
    {

        Random rnd;
        Density pl;

        float o = 0;

        int[] statistic = new int[8];

        double  Chi, a;

        float[] Freq = new float[8];

        float M, MErr, D, DErr, k_param, Sum, A, powA;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        float k = 0;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            chart1.ChartAreas[0].AxisX.Maximum = 1;


        }

        private void FirstMethodBtn_Click(object sender, EventArgs e)
        {
            M = 0; D = 0; Chi = 0; Sum = 0; powA = 0; a = -3.5;
            pl = new Density(AVTvalue.Value, VarTvalue.Value);
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 8; i++)
            {
                statistic[i] = 0;
                Freq[i] = 0;
            }

            k_param = float.Parse(textBox1.Text, CultureInfo.InvariantCulture.NumberFormat);
            

            

            for (int i = 0; i < NumExp.Value; i++)
            {

                A = Gamma();
                Sum = Sum + A;
                powA += A * A;
                k = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (A < k + 0.2 && A > k)
                    {
                        statistic[j]++;
                        break;
                    }
                    k += 0.2f;
                }
            }
            o = 0;
            for (int i = 0; i < 8; i++)
            {
                
                Freq[i] = statistic[i] / ((float)NumExp.Value);
                chart1.Series[0].Points.AddXY(o, Freq[i]);
                o += 0.2f;
            }

            M = Sum / (float)NumExp.Value;
            D = powA / (float)NumExp.Value - M * M;

            ChiCounter();

            

            writer();
        }

        

       

        void writer()
        {
            AverageLbl.Text = "Average: " + M;
            VarianceLbl.Text = "Variance: " + D;
            
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

        float Gamma()
        {
            const double e = 2.718;
            double k = (float)rnd.NextDouble();
            double Density = e / (e + k), a = 1 / k, Alfa_1, Alfa_2, Beta, Teta;
            double d = Density / (1 - Density);
            do
            {
                Alfa_1 = (float)rnd.NextDouble();
                Alfa_2 = (float)rnd.NextDouble();
                Beta = Alfa_1 / Density;
                Teta = Beta < 1 ? Beta * a : (float)(-Math.Log(d * (Beta - 1)));
                
            } while (Teta <1 && Math.Exp(-Teta)<Alfa_2 || Teta>=1 && Teta * (k-1)<Alfa_2);
            Console.WriteLine(Teta);
            return (float)Teta;
        }
    }
}
