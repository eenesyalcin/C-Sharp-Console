using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_09._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SWITCH-CASE YAPISI

            int number;
            Console.WriteLine("1 - Pazartesi");
            Console.WriteLine("2 - Salı");
            Console.WriteLine("3 - Çarşamba");
            Console.WriteLine("4 - Perşembe");
            Console.WriteLine("5 - Cuma");
            Console.WriteLine("6 - Cumartesi");
            Console.WriteLine("7 - Pazar");
            Console.Write("Lütfen hangi günü görüntülemek istediğinize güne göre 1-7 arasında bir sayı giriniz = ");
            number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------");

            switch (number)
            {
                case 1: Console.Write("Gün = PAZARTESİ");
                    break;
                case 2: Console.Write("Gün = SALI");
                    break;
                case 3: Console.Write("Gün = ÇARŞAMBA");
                    break;
                case 4: Console.Write("Gün = PERŞEMBE");
                    break;
                case 5: Console.Write("Gün = CUMA");
                    break;
                case 6: Console.Write("Gün = CUMARTESİ");
                    break;
                case 7: Console.Write("Gün = PAZAR");
                    break;
                default: Console.Write("HATALI SAYI GİRİŞİ YAPTINIZ");
                    break;
            }

            Console.Read();
        }
    }
}
