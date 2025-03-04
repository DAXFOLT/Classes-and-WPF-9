using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class6
    {
        private int N;
        private int K;

        public Class6(int n, int k)
        {
            if (n < 1)
            {
                throw new ArgumentException("N должно быть больше  1.");
            }
            if (k <= 1)
            {
                throw new ArgumentException("M должно быть больше 1.");
            }

            N = n;
            K = k;
        }

        public int G1()
        {
            for (int k = 1; k <= N; k++)
            {
                if (3 * k > N)
                {
                    return k;
                }
            }
            throw new InvalidOperationException("K должно быть больше N.");
        }
    }
}
