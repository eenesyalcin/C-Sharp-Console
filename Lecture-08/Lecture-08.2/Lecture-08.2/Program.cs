using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_08._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF-ELSE YAPISI-3

            double price, discount, paidPrice;

            Console.Write("Lütfen ürünlerin toplam tutarını giriniz = ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------");

            if(price > 0 && price <= 100)
            {
                discount = price * 10 / 100;
                paidPrice = price - discount;
                Console.WriteLine("İndirim tutarı = " + discount);
                Console.Write("Ödenecek tutar = " + paidPrice);
            }
            else if(price > 100 && price <= 150)
            {
                discount = price * 15 / 100;
                paidPrice = price - discount;
                Console.WriteLine("İndirim tutarı = " + discount);
                Console.Write("Ödenecek tutar = " + paidPrice);
            }
            else if (price > 150)
            {
                discount = price * 20 / 100;
                paidPrice = price - discount;
                Console.WriteLine("İndirim tutarı = " + discount);
                Console.Write("Ödenecek tutar = " + paidPrice);
            }
            else
            {
                Console.Write("YANLIŞ TUTAR GİRDİNİZ");
            }

            Console.Read();
        }
    }
}
