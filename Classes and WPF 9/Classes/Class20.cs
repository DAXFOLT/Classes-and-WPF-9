using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class20
    {
        private int N;
        public Class20(int n)
        {
            if (N < 10)
                N = n;
        }
        public int G1()
        {
            int lol = 0;
            for (int i = 10; i <= N; i++)
            {
                if (i % 5 == 0)
                    lol = i;

            }
            return lol;
        }

    }
}
