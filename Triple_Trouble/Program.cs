using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Trouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TripleDouble(451999277, 41177722899));
            Console.WriteLine(TripleDouble(1222345, 12345));
            Console.WriteLine(TripleDouble(10560002, 100));
            Console.WriteLine(TripleDouble(666789, 12345667));
            Console.ReadLine();
        }

        public static int TripleDouble(long num1, long num2)
        {
            int countNum1 = 1;
            int countNum2 = 1;
            bool[] matches = new bool[4];

            int[] n1 = num1.ToString().Select(Convert.ToInt32).ToArray();
            int[] n2 = num2.ToString().Select(Convert.ToInt32).ToArray();

            for (int i = 0; i < n1.Length - 1; i++)
            {
                if (n1[i] == n1[i + 1])
                {
                    countNum1++;

                    if (countNum1 == 2)
                    {
                        matches[0] = true;
                    }

                    if (countNum1 == 3)
                    {
                        matches[1] = true;
                        break;
                    }
                }
            }

            for (int i = 0; i < n2.Length - 1; i++)
            {
                if (n2[i] == n2[i + 1])
                {
                    countNum2++;

                    if (countNum2 == 2)
                    {
                        matches[2] = true;
                    }

                    if (countNum2 == 3)
                    {
                        matches[3] = true;
                        break;
                    }
                }
            }

            if ((matches[0] && matches[3]) || (matches[1] && matches[2]))
            {
                return 1;
            }

            return 0;
        }
    }
}
