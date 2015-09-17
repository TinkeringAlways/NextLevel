using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("abrecidbra"));
            Console.ReadLine();
        }

        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            char[] temp = str.ToCharArray();

            foreach (char c in temp)
            {
                if (new [] {'a','e','i','o','u'}.Contains(c))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
