using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotCodeWars_FormatDecimalPlaces
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundDecimal();
            Console.ReadLine();
        }

        static void RoundDecimal()
        {
            decimal value = 3456787654.567851m;
            Console.WriteLine(value);

            Console.WriteLine(value.ToString("#.##"));
            Console.WriteLine(String.Format("{0:0.00}", value));
            Console.WriteLine($"{value:0.00}");
            Console.WriteLine(value.ToString("n2"));
            Console.WriteLine("{0:c}", value);
        }
    }
}
