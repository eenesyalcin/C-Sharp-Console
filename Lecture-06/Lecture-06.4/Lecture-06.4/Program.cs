using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_06._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF-ELSE YAPISI-1

            int number;
            Console.Write("Lütfen bir sayı giriniz = ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------");

            if(number < 0)
            {
                Console.Write("NEGATİF TAM SAYI GİRDİNİZ");
            }
            else
            {
                Console.Write("POZİTİF TAM SAYI GİRDİNİZ");
            }

            Console.Read(); 
        }
    }
}
