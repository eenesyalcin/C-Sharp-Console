using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_06._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF-ELSE YAPISI-1

            int exam1, exam2, average;

            Console.Write("Lütfen 1. sınav notunu giriniz = ");
            exam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 1. sınav notunu giriniz = ");
            exam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------");

            average = (exam1 + exam2) / 2;

            Console.WriteLine("Öğrencinin ders ortalaması = " + average);

            if(average >= 50)
            {
                Console.Write("ÖĞRENCİ DERSİ GEÇTİ");
            }
            else
            {
                Console.Write("ÖĞRENCİ DERSTEN KALDI");
            }

            Console.Read();
        }
    }
}
