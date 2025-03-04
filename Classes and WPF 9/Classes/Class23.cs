using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class23
    {
        double A = 1;
        double B = 1;
        private double N;
        public Class23(double n22)
        {
            N = n22;
        }
        public List<double> G1()
        {
            List<double> numbers = new List<double>();
            for (int i = 1; i <= N; i++)
            {
                A = A * i;
                B = Math.Pow(2, i);
            }
            numbers.Add(A);
            numbers.Add(B);
            return numbers;
        }

    }
}
