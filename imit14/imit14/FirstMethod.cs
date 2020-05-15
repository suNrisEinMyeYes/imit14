using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit14
{
    class FirstMethod
    {
        decimal v, m;
        public FirstMethod(decimal mean, decimal var)
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
            return Math.Sqrt((double)v) * sum + (double)m;
        }
    }
}
