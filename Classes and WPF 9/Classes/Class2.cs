using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class2
    {
        private int A;
        private int B;

        public Class2(int a, int b)
        {
            if (a >= b)
            {
                throw new ArgumentException("А должно быть меньше В.");
            }
            A = a;
            B = b;
        }

        public List<int> GetNumber()
        {
            List<int> number = new List<int>();
            for (int i = B - 1; i >= A + 1; i--)
            {
                number.Add(i);
            }
            return number;
        }
        public string G1()
        {
            return ($"Кол-во чисел N:\n" + (B - A - 1));
        }

        public string G2()
        {
            return (string.Join(" ", GetNumber()));
        }
    }
}
