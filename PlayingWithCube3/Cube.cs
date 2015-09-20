using System;

namespace PlayingWithCube3
{
    public class Cube
    {
        // Fields
        public int Side;
        public double Volume;
        public double Surface;

        // Constructors
        public Cube() { }

        public Cube(int s)
        {
            Side = Math.Abs(s);
            Volume = Math.Pow(s, 3);
            Surface = (s * 2) * 6;
        }

        //// Property Setters
        //public int Side => side;

        //public double Volume => volume;

        //public double Surface => surface;
    }
}