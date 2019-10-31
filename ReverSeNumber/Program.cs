using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverSeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredString;
            string reversedString = "";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nTers çevrilecek metni  sayı giriniz: ");
            enteredString = Console.ReadLine();
            //char karakter=char.Parse(enteredString);
            char[] karakter = enteredString.ToCharArray(); ;
            int boyut = enteredString.Length;
            for (int i = boyut - 1; i >= 0; i--)
            {

                reversedString += karakter[i];
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Girilen metin : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(enteredString);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ve ters çevrilmiş hali : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(reversedString);
            Console.ReadKey();
        }
    }
}
