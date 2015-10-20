using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(918571647));
            Console.ReadLine();
        }

        public static int DescendingOrder(int num)
        {
            List<char> temp = num.ToString().ToCharArray().ToList();

            temp.Sort();
            temp.Reverse();

            string s;
            temp.Concat(s);

            return Convert.ToInt32(temp.Concat(temp).ToString());
        }
    }
}
