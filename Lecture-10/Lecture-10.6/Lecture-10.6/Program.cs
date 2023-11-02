using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DÖNGÜLER-1 (FOR DÖNGÜSÜ)

            int i;
            int total = 0;

            for (i = 1; i < 10; i+=2)
            {
                total += i;
            }

            Console.Write("1-10 arasındaki tek rakamların toplamı = " + total);

            Console.Read();
        }
    }
}
