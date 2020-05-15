using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit14
{
    class Density
    {
        decimal v, m;
        public Density(decimal mean, decimal var)
        {
            m = mean;
            v = var;
        }
        double num;
        public double getP(double x)
        {
            num = (1 / (Math.Sqrt((double)v) * Math.Sqrt(2 * Math.PI))) * Math.Exp(-1 * (((x - (double)m) * (x - (double)m)) / (2 * (double)v)));
            return num;
        }
    }
}
