using System;
using System.Collections.Generic;
using System.Linq;

namespace TheOldSwitcheroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "ABCD";

            Console.WriteLine(Encode(test));
            Console.ReadLine();
        }

        public static string Encode(string str)
        {
            char[] aTOz = new char[26];
            char[] AtoZ = new char[26];
            List<int> ints = new List<int>();

            for (int i = 0; i < 26; i++)
            {
                char c = new char();
                AtoZ[i] = (char) ((c + 65) + i);
                aTOz[i] = (char) ((c + 97) + i);
            }

            char[] chars = str.ToCharArray();

            for(int n = 0; n < chars.Length; n++)
            {
                if (aTOz.Contains(chars[n]) || AtoZ.Contains(chars[n]))
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (chars[n] == aTOz[i] || chars[n] == AtoZ[i])
                        {
                            ints.Add(i + 1);
                            break;
                        }
                    }
                }
            }

            string r = String.Empty;

            foreach (int i in ints)
            {
                r += i.ToString();
            }

            return r;

        }
    }
}
