using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithCube3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube sq = new Cube(5);
            Console.WriteLine(sq.Side);
            Console.WriteLine(sq.Volume);
            Console.WriteLine(sq.Surface);
            Console.ReadLine();
        }
    }
}
