using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyaAndStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSteps(100,7));
            Console.ReadLine();
        }

        public static int NumberOfSteps(int n, int m)
        {
            int howMany = 0;

            if (n < m)
            {
                howMany = -1;
            }
            else
            {
                int ones = 0;

                if ((n / 2) % m != 0)
                {
                    int rem = (n/m) % m;

                }
                else
                {
                    howMany = (n/m);
                }
            }

            return howMany;
        }
    }
}
