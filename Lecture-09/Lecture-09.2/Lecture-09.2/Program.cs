using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_09._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SWITCH-CASE YAPISI

            string season;
            Console.Write("Lütfen baş harfi büyük olacak şekilde mevsim giriniz = ");
            season = Console.ReadLine();
            Console.WriteLine("\n--------------------------------------------------");

            switch (season)
            {
                case "Kış":
                    Console.WriteLine("*** KIŞ MEVSİMİNİN AYLARI ***");
                    Console.WriteLine("Aralık");
                    Console.WriteLine("Ocak");
                    Console.Write("Şubat");
                    break;
                case "İlkbahar":
                    Console.WriteLine("*** İLKBAHAR MEVSİMİNİN AYLARI ***");
                    Console.WriteLine("Mart");
                    Console.WriteLine("Nisan");
                    Console.Write("Mayıs");
                    break;
                case "Yaz":
                    Console.WriteLine("*** YAZ MEVSİMİNİN AYLARI ***");
                    Console.WriteLine("Haziran");
                    Console.WriteLine("Temmuz");
                    Console.Write("Ağustos");
                    break;
                case "Sonbahar":
                    Console.WriteLine("*** SONBAHAR MEVSİMİNİN AYLARI ***");
                    Console.WriteLine("Eylül");
                    Console.WriteLine("Ekim");
                    Console.Write("Kasım");
                    break;
                default:
                    Console.Write("HATALI MEVSİM GİRİŞİ YAPTINIZ");
                    break;
            }

            Console.Read();
        }
    }
}
