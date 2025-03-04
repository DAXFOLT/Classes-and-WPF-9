using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class25
    {
        private int N;
        public Class25(int n)
        {
            if (n < 10)
            {
                Console.WriteLine("Число должно быть больше 10");
            }
            else
            {
                N = n;
            }

        }
        public List<double> G1()
        {
            List<double> numbers = new List<double>();
            for (double i = 10; i <= N; i++)
            {
                numbers.Add(Math.Floor(i / 10));
            }
            return numbers;
        }

        public List<double> G2()
        {
            List<double> numbers = new List<double>();
            for (double i = 10; i <= N; i++)
            {
                numbers.Add(Math.Floor(i / 10) + (i % 10));
            }
            return numbers;
        }
    }
}
