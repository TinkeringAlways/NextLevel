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
            Console.WriteLine(NumberOfSteps(25,3));
            Console.ReadLine();
        }

        public static int NumberOfSteps(int n, int m)
        {
            int howMany = 0;

            if (n < m)
            {
                howMany = -1;
            }
            else if (n % 2 == 0 && (n/2) % m == 0)
            {
                howMany = n / 2;
            }
            else
            {
                for (int i = n/2 + 1; ; i++)
                {
                    if (i % m == 0)
                    {
                        howMany = i;
                        break;
                    }
                }
            }

            return howMany;
        }
    }
}
