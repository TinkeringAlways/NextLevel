using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grasshopper_GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        /*
        public static char GetGrade(int s1, int s2, int s3)
        {
            int mean = (s1 + s2 + s3)/3;

            if (mean <= 100 && mean >= 90)
            {
                return 'A';
            }
            if (mean < 90 && mean >= 80)
            {
                return 'B';
            }
            if (mean < 80 && mean >= 70)
            {
                return 'C';
            }
            if (mean < 70 && mean >= 60)
            {
                return 'D';
            }
            if (mean < 60 && mean >= 0)
            {
                return 'F';
            }

            return ' ';
        }

    */

        // Best way to do this!! YAY
        public static char GetGrade(int s1, int s2, int s3)
        {
            int m = (s1 + s2 + s3)/3;
            if (60 > m) return 'F';
            if (70 > m) return 'D';
            if (80 > m) return 'C';
            if (90 > m) return 'B';
            return 'A';
        }
    }
}
