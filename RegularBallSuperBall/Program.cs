using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularBallSuperBall
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball b = new Ball();
            Ball sB = new Ball("super");

            Console.WriteLine(b.balltype);
            Console.WriteLine(sB.balltype);
            Console.ReadLine();
        }
    }

    public class Ball
    {
        public string balltype { get; set; }

        public Ball()
        {
            balltype = "regular";
        }

        public Ball(string type = "super")
        {
            balltype = type;
        }
    }
}
