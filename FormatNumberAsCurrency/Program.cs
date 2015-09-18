using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumberAsCurrency
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((-1.23m).ToCurrency("#"));
            Console.ReadLine();
        }

        public static string ToCurrency(this decimal d, string c)
        {
            return (d < 0) ? '-' + c + (d.ToString("F2")).TrimStart('-') : c + d.ToString("F2");
        }
    }
}
