using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Block b = new Block(new int[] {2,2,2});

            Console.WriteLine(b.GetHeight());
            Console.WriteLine(b.GetLength());
            Console.WriteLine(b.GetWidth());
            Console.WriteLine(b.GetVolume());
            Console.WriteLine(b.GetSurfaceArea());
            Console.ReadLine();
        }
    }

    class Block
    {
        private int Width { get; }
        private int Length { get; }
        private int Height { get; }

        public Block(int[] dim)
        {
            Width = dim[0];
            Length = dim[1];
            Height = dim[2];
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetLength()
        {
            return Length;
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetVolume()
        {
            return Width*Length*Height;
        }

        public int GetSurfaceArea()
        {
            int surface = ((Height*Width)*2);
            surface = surface + ((Length*Height)*2);
            surface = surface + ((Length*Width)*2);

            return surface;
        }
    }
}
