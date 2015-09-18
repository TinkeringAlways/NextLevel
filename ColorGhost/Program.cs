using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorGhost
{
    class Program
    {
        static void Main(string[] args)
        {
            Ghost ghostOne = new Ghost();
            Ghost ghostTwo = new Ghost();
            Ghost ghostThree = new Ghost();
            Ghost ghostFour = new Ghost();

            Console.WriteLine($"Ghost one is: {ghostOne.GetColor()}\nGhost two is: {ghostTwo.GetColor()}\nGhost three is: {ghostThree.GetColor()}\nGhost four is: {ghostFour.GetColor()}");
            Console.ReadLine();
        }
    }

    class Ghost
    {
        public string GhostColor { get; private set; }

        public Ghost() 
        {
            Dictionary<int, string> colors = new Dictionary<int, string>
            {
                {0, "white"},
                {1, "yellow"},
                {2, "purple"},
                {3, "purple"}
            };

            int num = GetRandom();

            if (num < 1000)
            {
                GhostColor = colors[0];
            }
            else if (num >= 1000 && num < 2000)
            {
                GhostColor = colors[1];
            }
            else if (num >= 2000 && num < 3000)
            {
                GhostColor = colors[2];
            }
            else
            {
                GhostColor = colors[3];
            }


        }

        public string GetColor()
        {
            return GhostColor;
        }

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        private static int GetRandom()
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(0, 4000);
            }
        }
    }
}
