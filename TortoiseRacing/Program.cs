using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Race(720, 850, 70));
            Console.WriteLine(Race(80, 91, 37));
            Console.WriteLine(Race(80, 100, 40));
            Console.ReadLine();
        }

        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2)
            {
                return null;
            }

            int[] results = {0,0,0};

            double a = Convert.ToDouble(v1);
            double b = Convert.ToDouble(v2);
            double lead = Convert.ToDouble(g);

            double time = (lead/(b - a)*60d);
            
            while (time >= 60)
            {
                time -= 60;
                results[0]++;
            }

            if (time > 0)
            {
                results[1] = Convert.ToInt32(Math.Truncate(time));

                time -= results[1];

                results[2] = Convert.ToInt32(time * 60); 
            }

            return results;
        }
    }
}
