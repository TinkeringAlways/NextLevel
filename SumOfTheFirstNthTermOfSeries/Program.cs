using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTheFirstNthTermOfSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(seriesSum(5));
            Console.ReadLine();
        }

        public static string seriesSum(int n)
        {
            double num;

            if (n == 1)
            {
                num = 1;
            }
            else if (n == 2)
            {
                num = 1 + (1/4d);
            }
            else if (n >= 3)
            {
                double denom;
                num = 1 + (1/4d);

                for (int i = 1; i <= n - 2; i++)
                {
                    denom = 4 + (i*3);
                    num = num +  (1/denom);
                }
            }
            else
            {
                num = 0;
            }

            string total = num.ToString("F2");

            return total;
        }
    }
}
