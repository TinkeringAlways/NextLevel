using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
            Console.ReadLine();
        }

        public static string HighAndLow(string numbers)
        {
            string[] values = numbers.Split(' ').Select(sValue => sValue.Trim()).ToArray();

            int[] nums = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                nums[i] = Convert.ToInt32(values[i]);
            }

            return nums.Max() + " " + nums.Min() ;
        }
    }
}
