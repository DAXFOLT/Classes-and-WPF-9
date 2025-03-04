﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_WPF_9.Classes
{
    internal class Class12
    {
        private double X;
        private double N;

        public Class12(double x, double n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("N должно быть больше 0.");
            }
            X = x;
            N = n;
        }

        public double G1()
        {
            double lol = 1;
            for (int i = 1; i <= N; i++)
            {
                if (i % 1 == 0)
                    lol -= X * i / i;
            }

            return lol;
        }
    }
}
