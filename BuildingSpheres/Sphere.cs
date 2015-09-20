using System;

namespace BuildingSpheres
{
    class Sphere
    {
        public int Radius { get; set; }
        public int Mass { get; set; }

        public Sphere(int r, int m)
        {
            Radius = r;
            Mass = m;
        }

        public int GetRadius() => Radius;
        public int GetMass() => Mass;

        public double GetVolume() => Math.Round((4 / 3d) * Math.PI * Math.Pow(Radius, 3),5);

        public double GetSurfaceArea() => Math.Round(4 * Math.PI * Math.Pow(Radius, 2),5);

        public double GetDensity() => Math.Round(Mass / GetVolume(),5);
    }
}