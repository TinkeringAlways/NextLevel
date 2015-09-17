using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeBackronym
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static string MakeBackronym(string s)
        {
            string input = s.ToUpper();
            char[] c = input.ToCharArray();
            string acro = String.Empty;

            for (int i = 0; i < c.Length; i++)
            {
                acro += c[0] + " ";
            }

            string final = acro.Trim();

            return final; // "awesome"
        }
    }
}
