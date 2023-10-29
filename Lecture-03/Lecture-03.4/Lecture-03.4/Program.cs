using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INT DEĞİŞKENLER

            string name, surname, studentNumber;
            int exam1, exam2, exam3, project, average;

            name = "Enes";
            surname = "YALÇIN";
            studentNumber = "12345678901";

            exam1 = 60;
            exam2 = 80;
            exam3 = 100;
            project = 90;

            average = (exam1 + exam2 + exam3 + project) / 4;

            Console.WriteLine("*** ÖĞRENCİ BİLGİLERİ ***");
            Console.WriteLine("İsim = "+name);
            Console.WriteLine("Soyisim = " + surname);
            Console.WriteLine("Öğrenci numarası = " + studentNumber);
            Console.WriteLine("------------------------------");

            Console.WriteLine("\n*** SINAV BİLGİLERİ ***");
            Console.WriteLine("1. Sınav = " + exam1);
            Console.WriteLine("2. Sınav = " + exam2);
            Console.WriteLine("3. Sınav = " + exam3);
            Console.WriteLine("Proje = " + project);
            Console.WriteLine("------------------------------");

            Console.WriteLine("\n*** ORTALAMA BİLGİSİ ***");
            Console.WriteLine("Öğrenci ortalaması = " + average);
            Console.WriteLine("------------------------------");

            Console.Read();
        }
    }
}
