using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_07._3
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

            if (number % 2 == 0)
            {
                Console.Write("SAYI ÇİFTTİR");
            }
            else
            {
                Console.Write("SAYI TEKTİR");
            }

            Console.Read();
        }
    }
}
