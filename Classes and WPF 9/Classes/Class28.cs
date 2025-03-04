using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class28
    {
        double A = 0;
        double B = 0;
        private double N;
        public Class28()
        {

        }
        public double G1()
        {
            List<double> numbers = new List<double>();
            for (int i = 22; i <= 88; i++)
            {
                B = Math.Pow(i, 2);
                numbers.Add(B);
            }
            numbers.Reverse();
            foreach (double x in numbers)
            {
                A = Math.Abs(A - x);
            }
            return A;
        }

    }
}
