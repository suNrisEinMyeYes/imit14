using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit14
{
    class BG
    {
        Random rnd = new Random();
        public double next()
        {
            return rnd.NextDouble();
        }
    }
}
