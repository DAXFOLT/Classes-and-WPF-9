using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class16
    {
        private int N;
        private double A;
        private double B;
        private double H;

        public Class16(int n, double a, double b)
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
        public double[] GetPoints()
        {
            double[] points = new double[N];

            for (int i = 0; i < N; i++)
            {
                points[i] = A + i * H;
            }

            return points;
        }
        public List<string> G1()
        {
            List<string> strings = new List<string>();
            for (int i = 0; i < GetPoints().Length; i++)
            {
                strings.Add($"[{i}] = {GetPoints()[i]:F4}");
            }
            return strings;
        }
    }
}
