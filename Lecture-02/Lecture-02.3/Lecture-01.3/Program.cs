using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_01._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STRING DEĞİŞKENİ

            string name, surname, age, job, city;

            Console.WriteLine("---> Lütfen sırası ile adınızı, soyadınızı, yaşınızı, işinizi ve şehrinizi giriniz");
            name = Console.ReadLine();
            surname = Console.ReadLine();
            age = Console.ReadLine();
            job = Console.ReadLine();
            city = Console.ReadLine();

            Console.WriteLine("\n*** KULLANICI BİLGİLERİ ***");
            Console.WriteLine("İsim = " + name);
            Console.WriteLine("Soyisim = " + surname);
            Console.WriteLine("Yaş = " + age);
            Console.WriteLine("Meslek = " + job);
            Console.WriteLine("Şehir = " + city);

            Console.Read();
        }
    }
}
