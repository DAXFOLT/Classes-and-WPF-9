using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class8
    {
        private int A;
        private int N;

        public Class8(int a, int n)
        {
            if (a < 1)
            {
                throw new ArgumentException("A должно быть больше 1");
            }
            A = a;
            N = n;
        }

        public string G1()
        {
            double sum = 0.0;

            while (sum <= A)
            {
                N++;
                sum += 1.0 / N;
            }
            return $"Наименьшее {N}\nСумма: {sum}";
        }

    }
}
