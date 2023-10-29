using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DOUBLE DEĞİŞKENLER

            string name, surname, studentNumber;
            double exam1, exam2, exam3, project, average;

            Console.WriteLine("*** ÖĞRENCİ NOT HESAPLAMA SİSTEMİ ***");

            Console.Write("Lütfen öğrencinin ismini giriniz = ");
            name = Console.ReadLine();
            Console.Write("Lütfen öğrencinin soyismini giriniz = ");
            surname = Console.ReadLine();
            Console.Write("Lütfen öğrencinin numarasını giriniz = ");
            studentNumber = Console.ReadLine();

            Console.Write("\nLütfen öğrencinin 1. sınav notunu giriniz = ");
            exam1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen öğrencinin 2. sınav notunu giriniz = ");
            exam2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen öğrencinin 3. sınav notunu giriniz = ");
            exam3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen öğrencinin proje notunu giriniz = ");
            project = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------------------");

            average = (exam1 + exam2 + exam3 + project) / 4;

            Console.WriteLine("\n*** ÖĞRENCİ BİLGİLERİ ***");
            Console.WriteLine("İsim = " + name);
            Console.WriteLine("Soyisim = " + surname);
            Console.WriteLine("Numara = " + studentNumber);
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("\n*** ÖĞRENCİ NOT BİLGİLERİ ***");
            Console.WriteLine("1. Sınav  = " + exam1);
            Console.WriteLine("2. Sınav = " + exam2);
            Console.WriteLine("3. Sınav = " + exam3);
            Console.WriteLine("Proje = " + project);
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("\n*** ÖĞRENCİ ORTALAMA BİLGİSİ ***");
            Console.WriteLine("Ortalama  = " + average);
            Console.WriteLine("--------------------------------------------------");

            Console.Read();
        }
    }
}
