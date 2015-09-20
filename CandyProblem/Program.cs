using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 5, 8, 6, 4 };

            Console.WriteLine(GetMissingCandies(input));
            Console.ReadLine();
        }

        public static int GetMissingCandies(int[] candies)
        {
            int o = 0;

            if (candies.Length <= 1)
            {
                return -1;
            }

            int high = candies.Max();

            for (int i = 0; i < candies.Length; i++)
            {
                o += high - candies[i];
            }

            return o;

        }
    }
}
