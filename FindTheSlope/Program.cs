using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSlope
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { 19, 3, 20, 3 };
            int[] test2 = { 7, 2, 7, 4 };
            int[] test3 = { 10, 50, 30, 150 };
            int[] test4 = { 15, 45, 12, 60 };
            int[] test5 = { 10, 20, 20, 80 };
            int[] test6 = { -10, 6, -10, 3 };

            Console.WriteLine(slope(test1));
            Console.WriteLine(slope(test2));
            Console.WriteLine(slope(test3));
            Console.WriteLine(slope(test4));
            Console.WriteLine(slope(test5));
            Console.WriteLine(slope(test6));
            Console.ReadLine();
        }

        public static string slope(int[] points)
        {
            /*
            double x1 = (double)points[0];
            double x2 = (double)points[2];
            double y1 = (double)points[1];
            double y2 = (double)points[3];
            double slope = (y2 - y1)/(x2 - x1);
            return (x2 - x1 == 0) ? "undefined" : slope.ToString();
            */

            // Better way to find the sum!
            return (points[2] - points[0]) == 0
                ? "undefined"
                : ((points[3] - points[1])/(points[2] - points[0])).ToString();

        }
    }
}
