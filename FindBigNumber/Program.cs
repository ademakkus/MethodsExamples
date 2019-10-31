using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(  "Birinci sayı : ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("İkinci sayı : ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nBüyük sayı {0}",BuyukSayiGetir(s1,s2));


            Console.ReadKey();
        }

        private static int BuyukSayiGetir(int s1,int s2)
        {
            if (s1>s2)
            {
                return s1;
            }
            return s2;
        }
    }
}
