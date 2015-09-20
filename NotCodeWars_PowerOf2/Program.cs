using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotCodeWars_PowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerOfTwo(8));
            Console.WriteLine(PowerOfTwo(456789));
            Console.ReadLine();
        }

        public static bool PowerOfTwo(ulong p)
        {
            return (p != 0) && ((p & (p - 1)) == 0);
        }
    }
}
