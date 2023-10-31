using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_06._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF-ELSE YAPISI-1

            string name;
            name = "Enes";
            
            if(name == "Enes")
            {
                Console.Write("DOĞRU İSİM GİRİŞİ");
            }
            else
            {
                Console.Write("HATALI İSİM GİRİŞİ");
            }

            Console.Read();
        }
    }
}
