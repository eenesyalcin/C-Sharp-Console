using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INT DEĞİŞKENLER

            int number1, number2, division, average;
            number1 = 32;
            number2 = 12;
            division = number1 / number2;
            average = (number1 + number2) / 2;
            Console.WriteLine("Bölme işleminin sonucu = " + number1 + " / " + number2 + " = " + division);
            Console.Write("İki sayının ortalaması = (" + number1 + " + " + number2 + ") / 2 = " + average);
            Console.Read();
        }
    }
}
