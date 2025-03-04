using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class7
    {
        private int N;
        private int K;

        public Class7(int n, int k)
        {
            N = n;
            K = k;

            if (n <= 1)
            {
                throw new ArgumentException("N должно быть больше  1.");
            }
            if (k <= 1)
            {
                throw new ArgumentException("M должно быть больше 1.");
            }
        }

        public int G1()
        {

            while (3 * K < N && K <= N)
            {
                K++;
            }

            if (3 * (K - 1) < N)
            {
                return K - 1;
            }
            else
            {
                return K - 1;
            }
        }
    }
}
