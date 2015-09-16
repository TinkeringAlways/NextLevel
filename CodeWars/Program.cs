using System;
using NUnit.Framework;

namespace Deodorant_Evaporator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Evaporator.evaporator(10, 10, 10));
            Console.ReadLine();
        }
    }
}
