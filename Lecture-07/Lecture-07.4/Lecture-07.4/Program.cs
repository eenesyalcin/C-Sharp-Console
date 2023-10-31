using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_07._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF-ELSE YAPISI-2

            int number;
            Console.Write("Lütfen bir sayı giriniz = ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------");

            if (number % 5 == 0)
            {
                Console.Write("SAYI 5 SAYISINA TAM BÖLÜNÜR");
            }
            else
            {
                Console.Write("SAYI 5 SAYISINA TAM BÖLÜNMEZ");
            }

            Console.Read();
        }
    }
}
