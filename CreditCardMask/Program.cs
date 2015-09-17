using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardMask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify("78987654567898765"));
            Console.ReadLine();
        }

        public static string Maskify(string cc)
        {
            if (cc.Length > 4)
            {
                string temp = cc.Substring(0, (cc.Length - 4));
                string mask = String.Empty;

                for (int i = 0; i < temp.Length; i++)
                {
                    mask += "#";
                }

                cc = cc.Remove(0, (temp.Length));
                cc = mask + cc;
            }
            
            return cc;
        }
    }
}
