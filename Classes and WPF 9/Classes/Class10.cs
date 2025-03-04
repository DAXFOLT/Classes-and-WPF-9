using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class10
    {
        private int N;

        public Class10(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("N должно быть больше 0");
            }
            N = n;
        }

        public string G1()
        {
            double product = 2.0;

            for (int i = 2; i <= N; i++)
            {
                product *= 1.0 / i;
            }

            return $"Произведение 2 * 1/2 * 1/3 * ... * 1/{N} равно: {product}";
        }
    }
}
