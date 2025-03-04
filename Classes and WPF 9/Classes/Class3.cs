using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class3
    {
        private double A;
        private int N;

        public Class3(double a, int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("N должно быть больше 0.");
            }
            A = a;
            N = n;
        }

        public List<double> GetNumberOfNumbers()
        {
            List<double> pow = new List<double>();
            for (int i = 1; i <= N; i++)
            {
                pow.Add(A);
            }
            return pow;
        }
        public string G1()
        {
            return ($"A в степени N: \n{Math.Pow(A, N)}");
        }

        public string G2()
        {
            return (string.Join(" * ", GetNumberOfNumbers()));
        }
    }
}
