using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit14
{
    class SecondMethod
    {
        decimal v, m;
        public SecondMethod(decimal mean, decimal var)
        {
            m = mean;
            v = var;
        }
        BG bg = new BG();
        double sum;
        public double getNum()
        {
            sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum = sum + bg.next();
            }
            sum = sum - 6;
            sum = sum + ((1 / 240) * ((sum * sum * sum) - (3 * sum)));
            return Math.Sqrt((double)v) * sum + (double)m;
        }
    }
}
