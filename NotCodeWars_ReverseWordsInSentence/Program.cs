using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotCodeWars_ReverseWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWords("Please Reverse all of my words for me!!");
            Console.ReadLine();
        }

        public static void ReverseWords(string sent)
        {
            string[] words = sent.Split(' ');
            Stack<string> ss = new Stack<string>();
            string final = null;
            foreach (string s in words)
            {
                ss.Push(s);
            }

            foreach (string s in ss)
            {
                Console.Write(s + ' ');
            }
        }

        public static void ReverseLetters(string let)
        {
            
        }
    }
}
