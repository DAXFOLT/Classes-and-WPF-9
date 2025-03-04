using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class26
    {
        private int number;
        public Class26(int n)
        {
            number = n;
        }
        public string G1()
        {
            string strNumber = number.ToString();


            char[] charArray = strNumber.ToCharArray();
            Array.Reverse(charArray);
            string reversedNumber = new string(charArray);


            bool B = strNumber == reversedNumber;

            if (B == true)
            {
                return "Число симметричное";
            }
            else
            {
                return "Число не симметричное";
            }
        }
    }
}
