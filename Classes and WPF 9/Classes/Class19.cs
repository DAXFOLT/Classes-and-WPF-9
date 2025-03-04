using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class19
    {
        private double D;
        public Class19(double d)
        {
            if (d <= 0)
            {
                throw new ArgumentException("D должно быть больше 0.");
            }
            D = d;
        }
        public (int K, double AK_1, double AK) FindFirstK()
        {
            double A1 = 1;
            double A2 = 2;

            double AK = A2;
            double AK_1 = A1;

            int K = 2;

            while (true)
            {
                AK = (AK_1 + AK) / 2;

                K++;

                if (Math.Abs(AK - AK_1) < D)
                {
                    return (K, AK_1, AK);
                }
                AK_1 = A1;
            }
        }
    }
}
