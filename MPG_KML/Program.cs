using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPG_KML
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static double Converter(int mpg)
        {
            const double conv = 0.425143707;
            return (mpg * conv).ToString("F2");
        }
    }
}
