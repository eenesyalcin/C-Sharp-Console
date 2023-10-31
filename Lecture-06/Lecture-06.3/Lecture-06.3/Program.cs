using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_06._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF-ELSE YAPISI-1

            string city;
            Console.Write("Türkiye'nin başkenti neresidir? = ");
            city = Console.ReadLine();
            Console.WriteLine("\n--------------------------------------------------");

            if(city == "Ankara")
            {
                Console.Write("TEBRİKLER DOĞRU BİLDİNİZ");
            }
            else
            {
                Console.Write("HATALI CEVAP");
            }

            Console.Read();
        }
    }
}
