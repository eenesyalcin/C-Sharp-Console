using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_07._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İF-ELSE YAPISI-2

            int exam1, exam2, project, average;

            Console.Write("Lütfen 1. sınav notunu giriniz = ");
            exam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 2. sınav notunu giriniz = ");
            exam2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen proje notunu giriniz = ");
            project = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------");

            average = (exam1 + exam2 + project) / 3;

            Console.WriteLine("Öğrencinin ders ortalaması = " + average);

            if(average >= 0 && average <= 100)
            {
                if (average >= 0 && average < 30)
                {
                    Console.Write("Durum = ÇOK KÖTÜ");
                }
                else if (average >= 30 && average < 50)
                {
                    Console.Write("Durum = KÖTÜ");
                }
                else if (average >= 50 && average < 75)
                {
                    Console.Write("Durum = ORTA");
                }
                else if (average >= 75 && average < 90)
                {
                    Console.Write("Durum = İYİ");
                }
                else
                {
                    Console.Write("Durum = ÇOK İYİ");
                }
            }
            else
            {
                Console.Write("HATALI NOT GİRİŞİ YAPTINIZ");
            }

            Console.Read();
        }
    }
}
