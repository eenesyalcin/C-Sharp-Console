using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_04._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ARİTMETİK 4 İŞLEM UYGULAMASI

            int number1, number2, total;

            Console.WriteLine("*** TOPLAMA İŞLEMİ ***");
            Console.Write("Lütfen toplama işlemi için 1. sayıyı giriniz = ");
            number1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Lütfen toplama işlemi için 2. sayıyı giriniz = ");
            number2 = Convert.ToInt16(Console.ReadLine());

            total = number1 + number2;

            Console.Write("Toplama işleminin sonucu = " + number1 + " + " + number2 + " = " + total);

            Console.Read();
        }
    }
}
