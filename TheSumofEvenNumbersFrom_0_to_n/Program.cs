using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSumofEvenNumbersFrom_0_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("** Sıfırdan klavyeden girilen çift sayıya kadar olan çift sayıların toplamı **\n");
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" Çift bir n sayısını giriniz : ");
                n = int.Parse(Console.ReadLine()); 
            } while (n%2!=0);
            for (int i = 0; i <=n; i+=2)
            {
                sum += i;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n0 ile {0} arasındaki sayıların toplamı :  {1}",n,sum);
            Console.ReadKey();
        }
    }
}
