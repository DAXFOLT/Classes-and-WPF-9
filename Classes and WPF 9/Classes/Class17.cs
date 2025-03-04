using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class17
    {
        private int N;
        private double A;
        private double B;
        private double H;

        public Class17(int n, double a, double b)
        {
            if (n <= 2)
            {
                throw new ArgumentException("N должно быть больше 2");
            }
            if (a >= b)
            {
                throw new ArgumentException("A должно быть меньше B");
            }

            N = n;
            A = a;
            B = b;
            H = (B - A) / (N - 1);
        }




        public double[] CalculateFunctionValues()
        {
            double[] functionValues = new double[N];

            for (int i = 0; i < N; i++)
            {
                double x = A + i * H;
                functionValues[i] = 1 - Math.Sin(x);
            }

            return functionValues;
        }
        public List<string> G1()
        {
            List<string> strings = new List<string>();
            for (int i = 0; i < CalculateFunctionValues().Length; i++)
            {
                double x = A + i * H;
                strings.Add($"F({x:F4}) = {CalculateFunctionValues()[i]:F4}");
            }
            return strings;
        }
    }
}
