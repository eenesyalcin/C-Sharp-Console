using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_06._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF-ELSE YAPISI-1

            string name;
            Console.Write("Lütfen isminizi giriniz = ");
            name = Console.ReadLine();
            Console.WriteLine("\n--------------------------------------------------");

            if (name == "Enes")
            {
                Console.Write("DOĞRU İSİM GİRİŞİ");
            }
            else
            {
                Console.Write("HATALI İSİM GİRİŞİ");
            }

            Console.Read();
        }
    }
}
