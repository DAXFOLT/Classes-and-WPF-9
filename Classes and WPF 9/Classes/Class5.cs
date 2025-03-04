using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class5
    {
        private double A;
        private int N;

        public Class5(double a, int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("N должно быть больше 0.");
            }
            A = a;
            N = n;
        }

        public List<string> Power()
        {
            List<string> pow = new List<string>();
            for (int i = 0; i <= N; i++)
            {
                pow.Add("+" + (Math.Pow(A, i)));
            }
            return pow;
        }

        public List<long> GetPowOfNumber()
        {
            List<long> pow = new List<long>();
            for (int i = 0; i <= N; i++)
            {
                pow.Add((long)Math.Pow(A, i));
                A = A * -1;
            }
            return pow;
        }

        public double G()
        {
            List<long> pow = GetPowOfNumber();

            return pow.Sum(x => Convert.ToInt32(x));
        }

        public string G2()
        {
            List<long> powers = GetPowOfNumber();

            return string.Join(" ", powers).TrimStart();
        }

        public string G3()
        {
            List<string> power = Power();

            return string.Join(" ", power).TrimStart();
        }
    }
}
