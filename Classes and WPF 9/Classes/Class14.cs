using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class14
    {
        private double X;
        private double N;

        public Class14(double x, double n)
        {
            if (X * Math.Abs(X) < 1)
            {
                throw new ArgumentException("X должо быть больше 1.");
            }
            if (N < 0)
            {
                throw new ArgumentException("N должно быть больше 0.");
            }
            X = x;
            N = n;
        }

        public double G1()
        {
            double lol = 1;
            for (int i = 0; i <= N; i++)
            {
                if (i % 4 == 0)
                    lol += X * i / i;
            }
            return lol;
        }
    }
}
