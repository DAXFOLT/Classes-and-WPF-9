using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class22
    {
        private double r, x;
        public Class22(double X)
        {
            x = X;
        }
        public double G1()
        {
            if (x > 0 && x < 3.14)
            {
                r = Math.Sin(x);
                return r;
            }
            else if (x >= -3.14 && x < 0)
            {
                r = Math.Pow(x, 3);
                return r;
            }
            else if (x < -2 * 3.14 || x > 2 * 3.14)
            {
                r = Math.Pow(x, 2);
                return r;
            }
            else
            {
                r = 0;
                return r;
            }
        }

    }
}
