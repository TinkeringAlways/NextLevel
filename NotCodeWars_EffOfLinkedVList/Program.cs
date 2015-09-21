using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotCodeWars_EffOfLinkedVList
{
    class Program
    {
        const int _max = 100000;
        static void Main()
        {
            var list = new List<string>();
            var link = new LinkedList<string>();
            // ... Add elements.
            for (int i = 0; i < 1000; i++)
            {
                list.Add("OK");
                link.AddLast("OK");
            }

            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                foreach (string v in list)
                {
                    if (v.Length != 2)
                    {
                        throw new Exception();
                    }
                }
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                foreach (string v in link)
                {
                    if (v.Length != 2)
                    {
                        throw new Exception();
                    }
                }
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds) /
                _max).ToString());
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds) /
                _max).ToString());
            Console.Read();
        }
    }
}
