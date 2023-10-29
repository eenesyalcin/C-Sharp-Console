using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_04._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ARİTMETİK 4 İŞLEM UYGULAMASI

            int number1, number2, total, difference, multi, division;

            Console.WriteLine("*** ARİTMETİK 4 İŞLEM UYGULAMASI ***");
            Console.Write("Lütfen işlemler için 1. sayıyı giriniz = ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen işlemler için 2. sayıyı giriniz = ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            total = number1 + number2;
            difference = number1 - number2;
            multi = number1 * number2;
            division = number1 / number2;

            Console.WriteLine("\n*** TOPLAMA İŞLEMİ ***");
            Console.WriteLine("Toplama işleminin sonucu = " + number1 + " + " + number2 + " = " + total);
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("\n*** ÇIKARMA İŞLEMİ ***");
            Console.WriteLine("Çıkarma işleminin sonucu = " + number1 + " - " + number2 + " = " + difference);
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("\n*** ÇARPMA İŞLEMİ ***");
            Console.WriteLine("Çarpma işleminin sonucu = " + number1 + " * " + number2 + " = " + multi);
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("\n*** BÖLME İŞLEMİ ***");
            Console.WriteLine("Bölme işleminin sonucu = " + number1 + " / " + number2 + " = " + division);
            Console.WriteLine("--------------------------------------------------");

            Console.Read();
        }
    }
}
