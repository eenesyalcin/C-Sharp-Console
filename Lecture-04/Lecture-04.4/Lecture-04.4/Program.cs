using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_04._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ARİTMETİK 4 İŞLEM UYGULAMASI

            int edge, squarePerimeter, squareArea;
            int shortEdge, longEdge, rectanglePerimeter, rectangleArea;

            Console.WriteLine("*** KARENİN ALANI ve ÇEVRESİ");
            Console.Write("Lütfen karenin bir kenarını giriniz = ");
            edge = Convert.ToInt32(Console.ReadLine());
            squarePerimeter = 4 * edge;
            squareArea = edge * edge;
            Console.WriteLine("Karenin bir kenarı = " + edge);
            Console.WriteLine("Karenin çevresi = " + squarePerimeter);
            Console.WriteLine("Karenin alanı = " + squareArea);
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("\n*** DİKDÖRTGENİN ALANI ve ÇEVRESİ");
            Console.Write("Lütfen dikdörtgenin kısa kenarını giriniz = ");
            shortEdge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen dikdörtgenin uzun kenarını giriniz = ");
            longEdge = Convert.ToInt32(Console.ReadLine());
            rectanglePerimeter = (shortEdge + longEdge) * 2; 
            rectangleArea = shortEdge * longEdge;
            Console.WriteLine("Dikdörtgenin kısa kenarı = " + shortEdge);
            Console.WriteLine("Dikdörtgenin uzun kenarı = " + longEdge);
            Console.WriteLine("Dikdörtgenin çevresi = " + rectanglePerimeter);
            Console.WriteLine("Dikdörtgenin kısa kenarı = " + rectangleArea);
            Console.WriteLine("--------------------------------------------------");

            Console.Read();
        }
    }
}
