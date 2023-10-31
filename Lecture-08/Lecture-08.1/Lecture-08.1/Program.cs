using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_08._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF-ELSE YAPISI-3

            string season;
            Console.Write("Lütfen başharfi büyük olacak şekilde bir mevsim giriniz = ");
            season = Console.ReadLine();
            Console.WriteLine("\n--------------------------------------------------");

            if(season == "Kış")
            {
                Console.WriteLine("*** KIŞ MEVSİMİNİN AYLARI ***");
                Console.WriteLine("Aralık");
                Console.WriteLine("Ocak");
                Console.Write("Şubat");
            }
            else if(season == "İlkbahar")
            {
                Console.WriteLine("*** İLKBAHAR MEVSİMİNİN AYLARI ***");
                Console.WriteLine("Mart");
                Console.WriteLine("Nisan");
                Console.Write("Mayıs");
            }
            else if (season == "Yaz")
            {
                Console.WriteLine("*** YAZ MEVSİMİNİN AYLARI ***");
                Console.WriteLine("Haziran");
                Console.WriteLine("Temmuz");
                Console.Write("Ağustos");
            }
            else if (season == "Sonbahar")
            {
                Console.WriteLine("*** SONBAHAR MEVSİMİNİN AYLARI ***");
                Console.WriteLine("Eylül");
                Console.WriteLine("Ekim");
                Console.Write("Kasım");
            }
            else
            {
                Console.Write("HATALI MEVSİM GİRİŞİ YAPTINIZ");
            }

            Console.Read();
        }
    }
}
