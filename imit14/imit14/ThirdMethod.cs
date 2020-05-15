using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit14
{
    class ThirdMethod
    {
        decimal v, m;
        double a1, a2;
        public ThirdMethod(decimal mean, decimal var)
        {
            m = mean;
            v = var;
        }
        BG bg = new BG();
        double sum;
        public double getNum()
        {
            a1 = bg.next();
            a2 = bg.next();
            sum = Math.Sqrt(-2 * Math.Log(a1)) * Math.Cos(2 * 3.14 * a2);
            return Math.Sqrt((double)v) * sum + (double)m;
        }
    }
}
