using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestUnusedID
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] nums = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine(NextId(nums));
            Console.ReadLine();
        }

        public static int NextId(int[] ids)
        {
            int i;

            for (i = 0; i < ids.Length; i++)
            {
                if (i != ids[i])
                {
                    return i;
                }
            }

            return i;
        }
    }
}
