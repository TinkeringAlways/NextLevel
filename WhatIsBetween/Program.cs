using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsBetween
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Between(5, 11));
            Console.ReadLine();
        }

        public static int[] Between(int a, int b)
        {
            int[] temp = new int[(b - a) - 1];

            for (int i = 0, n = a + 1; n < b; i++, n++)
            {
                temp[i] = n;
            }

            return temp;
        }
    }
}
