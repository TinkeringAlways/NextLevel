using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere ball = new Sphere(2, 50);

            Console.WriteLine(ball.GetRadius());
            Console.WriteLine(ball.GetMass());
            Console.WriteLine(ball.GetVolume());
            Console.WriteLine(ball.GetSurfaceArea());
            Console.WriteLine(ball.GetDensity());
            Console.ReadLine();
        }
    }
}
