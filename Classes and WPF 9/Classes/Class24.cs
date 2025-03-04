using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class24
    {
        private int N;
        public Class24(int n)
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
        public int G1()
        {
            int I = 10;
            List<double> numbers = new List<double>();
            for (int i = 10; i <= N; i++)
            {
                numbers.Add(i);
            }
            foreach (int B in numbers)
            {
                if (I < B)
                {
                    I = B;
                }
                else
                {
                    I = I;
                }
            }
            return I;
        }

    }
}
