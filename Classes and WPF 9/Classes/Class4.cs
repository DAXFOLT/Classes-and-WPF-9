using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class4
    {
        private double A;
        private int N;

        public Class4(double a, int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("N должно быть больше 0.");
            }
            A = a;
            N = n;
        }

        public List<double> GetPowOfNumber()
        {
            List<double> pow = new List<double>();
            for (int i = 1; i <= N; i++)
            {
                if (Math.Pow(A, i) % 1 == 0)
                {
                    pow.Add(Math.Pow(A, i));
                }
            }
            return pow;
        }


        public string G2()
        {
            return (string.Join(" , ", GetPowOfNumber()));
        }
    }
}
