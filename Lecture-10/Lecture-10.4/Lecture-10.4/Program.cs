using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DÖNGÜLER-1 (FOR DÖNGÜSÜ)

            int i;
            int total = 0;

            for (i = 1; i < 10; i++)
            {
                total += i;
            }

            Console.Write("1-10 arasındaki rakamların toplamı = " + total);

            Console.Read();
        }
    }
}
