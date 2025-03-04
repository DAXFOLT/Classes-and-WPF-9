using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class9
    {
        private int N;

        public Class9(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("N должно быть больше 0");
            }

            N = n;
        }

        public string G1()
        {
            double product = 1.0;

            for (int i = 1; i <= N; i++)
            {
                product *= i;
            }

            return $"Произведение чисел от 1 до {N} равно: {product}";
        }
    }
}
