using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // 15, 10, 13 and n: 38
            Console.WriteLine(Tribonacci(new double[] { 15, 10, 13 }, 38));
            Console.ReadLine();
        }

        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n <= 0) return signature;

            List<double> nums = signature.ToList();

            for (int i = 0; i < n - 3; i++)
            {
                nums.Add(nums[i] + nums[i + 1] + nums[i + 2]);
            }

            return nums.ToArray();
        }
    }
}
