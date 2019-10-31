using System;
using static System.Convert;

namespace Multiply_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Birinci sayı : ");
            var s1 = ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("İkinci sayı : ");
            var s2 = ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nSonuç : {0}", Carp(s1, s2));


            Console.ReadKey();
        }

        private static int Carp(int s1, int s2)
        {
            var result = 0;
            for (var i = 1; i <= s2; i++) result += s1;

            return result;
        }
    }
}