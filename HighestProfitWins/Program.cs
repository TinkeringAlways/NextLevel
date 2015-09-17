using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace HighestProfitWins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {7, 3, 7, 2, 8, 1, 5, 9, 3};
            string lowNhigh = Join(",", new List<int>(minMax(nums)).ConvertAll(i => i.ToString()).ToArray());
            Console.WriteLine(lowNhigh);
            Console.ReadLine();
        }

        public static int[] minMax(int[] lst)
        {
            int[] lowHigh = {lst.Min(),lst.Max()};

            return lowHigh;
        }
    }
}
