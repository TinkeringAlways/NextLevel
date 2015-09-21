using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotCodeWars_RemoveAllDupesFromAnArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dupes = {7, 3, 4, 8, 9, 2, 5, 7, 9, 2, 8, 2, 5, 8, 9};

            //RemoveDupes(ref dupes);
            RemoveDupesWDistinct(ref dupes);

            foreach (int d in dupes)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }

        public static void RemoveDupes(ref int[] array)
        {
            List<int> remove = new List<int>();

            for (int i = 0; i < array.Length -1; i++)
            {
                if (remove.Contains(i))
                {
                    continue;
                }
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        remove.Add(j);
                    }
                }
            }

            int[] tempArray = new int[array.Length - remove.Count];

            for (int i = 0, n = 0; i < array.Length; i++)
            {
                if (remove.Contains(i))
                {
                    continue;
                }

                tempArray[n] = array[i];
                n++;
            }

            array = tempArray;
        }

        public static void RemoveDupesWDistinct(ref int[] a) => a.Distinct().ToArray();
    }
}
