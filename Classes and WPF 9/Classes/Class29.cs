using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class29
    {
        double B = 0;
        private double A;
        private int N;
        public Class29(int n, double a)
        {
            N = n; A = a;
        }
        public List<double> G1()
        {
            List<double> numbers = new List<double>();
            for (int i = 1; i <= N; i++)
            {
                B = Math.Pow(A, 2) - Math.Pow(i, 2);
                numbers.Add(B);
            }

            return numbers;
        }

    }
}
