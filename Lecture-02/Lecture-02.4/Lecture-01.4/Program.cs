using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_01._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STRING DEĞİŞKENİ

            string name, surname;

            Console.Write("Lütfen isminizi giriniz = ");
            name = Console.ReadLine();
            Console.Write("Lütfen soyisminizi giriniz = ");
            surname = Console.ReadLine();

            Console.Write("\nKullanıcı = {0} {1}", name, surname);

            Console.Read();
        }
    }
}
