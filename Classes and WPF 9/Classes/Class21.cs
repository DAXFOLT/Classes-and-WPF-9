using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class21
    {

        public Class21()
        {
        }
        public List<double> G1()
        {
            List<double> numbers = new List<double>();
            for (double i = 11; i <= 99; i++)
            {
                numbers.Add(Math.Pow(i, 2));
            }
            return numbers;
        }

    }
}
