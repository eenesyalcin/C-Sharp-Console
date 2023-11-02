using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_09._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SWITCH-CASE YAPISI

            string city;
            Console.Write("Lütfen Kastamonu ilinin başka ile olan uzaklığını öğrenmek için baş harfi büyük olacak şekilde il giriniz = ");
            city = Console.ReadLine();
            Console.WriteLine("\n--------------------------------------------------");

            switch (city)
            {
                case "Adana":
                    Console.Write("Kastamonu ilinin Adana iline olan uzaklığı = 690 km");
                    break;
                case "Adıyaman":
                    Console.Write("Kastamonu ilinin Adıyaman iline olan uzaklığı = 889 km");
                    break;
                case "Afyon":
                    Console.Write("Kastamonu ilinin Afyon iline olan uzaklığı = 501 km");
                    break;
                case "Ağrı":
                    Console.Write("Kastamonu ilinin Ağrı iline olan uzaklığı = 987 km");
                    break;
                case "Amasya":
                    Console.Write("Kastamonu ilinin Amasya iline olan uzaklığı = 253 km");
                    break;
                case "Ankara":
                    Console.Write("Kastamonu ilinin Ankara iline olan uzaklığı = 245 km");
                    break;
                case "Antalya":
                    Console.Write("Kastamonu ilinin Antalya iline olan uzaklığı = 789 km");
                    break;
                case "Artvin":
                    Console.Write("Kastamonu ilinin Artvin iline olan uzaklığı = 876 km");
                    break;
                case "Aydın":
                    Console.Write("Kastamonu ilinin Aydın iline olan uzaklığı = 848 km");
                    break;
                case "Balıkesir":
                    Console.Write("Kastamonu ilinin Balıkesir iline olan uzaklığı = 670 km");
                    break;
                case "Bilecik":
                    Console.Write("Kastamonu ilinin Bilecik iline olan uzaklığı = 462 km");
                    break;
                case "Bingöl":
                    Console.Write("Kastamonu ilinin Bingöl iline olan uzaklığı = 889 km");
                    break;
                case "Bitlis":
                    Console.Write("Kastamonu ilinin Bitlis iline olan uzaklığı = 1082 km");
                    break;
                case "Bolu":
                    Console.Write("Kastamonu ilinin Bolu iline olan uzaklığı = 246 km");
                    break;
                case "Burdur":
                    Console.Write("Kastamonu ilinin Burdur iline olan uzaklığı = 667 km");
                    break;
                case "Bursa":
                    Console.Write("Kastamonu ilinin Bursa iline olan uzaklığı = 519 km");
                    break;
                case "Çanakkale":
                    Console.Write("Kastamonu ilinin Çanakkale iline olan uzaklığı = 790 km");
                    break;
                case "Çankırı":
                    Console.Write("Kastamonu ilinin Çankırı iline olan uzaklığı = 114 km");
                    break;
                case "Çorum":
                    Console.Write("Kastamonu ilinin Çorum iline olan uzaklığı = 196 km");
                    break;
                case "Denizli":
                    Console.Write("Kastamonu ilinin Denizli iline olan uzaklığı = 722 km");
                    break;
                case "Diyarbakır":
                    Console.Write("Kastamonu ilinin Diyarbakır iline olan uzaklığı = 955 km");
                    break;
                case "Edirne":
                    Console.Write("Kastamonu ilinin Edirne iline olan uzaklığı = 738 km");
                    break;
                case "Elazığ":
                    Console.Write("Kastamonu ilinin Elazığ iline olan uzaklığı = 802 km");
                    break;
                case "Erzincan":
                    Console.Write("Kastamonu ilinin Erzincan iline olan uzaklığı = 618 km");
                    break;
                case "Erzurum":
                    Console.Write("Kastamonu ilinin Erzurum iline olan uzaklığı = 806 km");
                    break;
                case "Eskişehir":
                    Console.Write("Kastamonu ilinin Eskişehir iline olan uzaklığı = 478 km");
                    break;
                case "Gaziantep":
                    Console.Write("Kastamonu ilinin Gaziantep iline olan uzaklığı = 815 km");
                    break;
                case "Giresun":
                    Console.Write("Kastamonu ilinin Giresun iline olan uzaklığı = 505 km");
                    break;
                case "Gümüşhane":
                    Console.Write("Kastamonu ilinin Gümüşhane iline olan uzaklığı = 667 km");
                    break;
                case "Hakkari":
                    Console.Write("Kastamonu ilinin Hakkari iline olan uzaklığı = 1394 km");
                    break;
                case "Hatay":
                    Console.Write("Kastamonu ilinin Hatay iline olan uzaklığı = 881 km");
                    break;
                case "Isparta":
                    Console.Write("Kastamonu ilinin Isparta iline olan uzaklığı = 666 km");
                    break;
                case "Mersin":
                    Console.Write("Kastamonu ilinin Mersin(İçel) iline olan uzaklığı = 683 km");
                    break;
                case "İstanbul":
                    Console.Write("Kastamonu ilinin İstanbul iline olan uzaklığı = 508 km");
                    break;
                case "İzmir":
                    Console.Write("Kastamonu ilinin İzmir iline olan uzaklığı = 824 km");
                    break;
                case "Kars":
                    Console.Write("Kastamonu ilinin Kars iline olan uzaklığı = 1006 km");
                    break;
                case "Kayseri":
                    Console.Write("Kastamonu ilinin Kayseri iline olan uzaklığı = 462 km");
                    break;
                case "Kırklareli":
                    Console.Write("Kastamonu ilinin Kırklareli iline olan uzaklığı = 719 km");
                    break;
                case "Kırşehir":
                    Console.Write("Kastamonu ilinin Kırşehir iline olan uzaklığı = 328 km");
                    break;
                case "Kocaeli":
                    Console.Write("Kastamonu ilinin Kocaeli(İzmit) iline olan uzaklığı = 397 km");
                    break;
                case "Konya":
                    Console.Write("Kastamonu ilinin Konya iline olan uzaklığı = 503 km");
                    break;
                case "Kütahya":
                    Console.Write("Kastamonu ilinin Kütahya iline olan uzaklığı = 556 km");
                    break;
                case "Malatya":
                    Console.Write("Kastamonu ilinin Malatya iline olan uzaklığı = 722 km");
                    break;
                case "Manisa":
                    Console.Write("Kastamonu ilinin Manisa iline olan uzaklığı = 805 km");
                    break;
                case "Kahramanmaraş":
                    Console.Write("Kastamonu ilinin Kahramanmaraş iline olan uzaklığı = 735 km");
                    break;
                case "Mardin":
                    Console.Write("Kastamonu ilinin Mardin iline olan uzaklığı = 1050 km");
                    break;
                case "Muğla":
                    Console.Write("Kastamonu ilinin Muğla iline olan uzaklığı = 867 km");
                    break;
                case "Muş":
                    Console.Write("Kastamonu ilinin Muş iline olan uzaklığı = 999 km");
                    break;
                case "Nevşehir":
                    Console.Write("Kastamonu ilinin Nevşehir iline olan uzaklığı = 419 km");
                    break;
                case "Niğde":
                    Console.Write("Kastamonu ilinin Niğde iline olan uzaklığı = 501 km");
                    break;
                case "Ordu":
                    Console.Write("Kastamonu ilinin Ordu iline olan uzaklığı = 461 km");
                    break;
                case "Rize":
                    Console.Write("Kastamonu ilinin Rize iline olan uzaklığı = 717 km");
                    break;
                case "Sakarya":
                    Console.Write("Kastamonu ilinin Sakarya(Adapazarı) iline olan uzaklığı = 360 km");
                    break;
                case "Samsun":
                    Console.Write("Kastamonu ilinin Samsun iline olan uzaklığı = 309 km");
                    break;
                case "Siirt":
                    Console.Write("Kastamonu ilinin Siirt iline olan uzaklığı = 1142 km");
                    break;
                case "Sinop":
                    Console.Write("Kastamonu ilinin Sinop iline olan uzaklığı = 188 km");
                    break;
                case "Sivas":
                    Console.Write("Kastamonu ilinin Sivas iline olan uzaklığı = 475 km");
                    break;
                case "Tekirdağ":
                    Console.Write("Kastamonu ilinin Tekirdağ iline olan uzaklığı = 640 km");
                    break;
                case "Tokat":
                    Console.Write("Kastamonu ilinin Tokat iline olan uzaklığı = 367 km");
                    break;
                case "Trabzon":
                    Console.Write("Kastamonu ilinin Trabzon iline olan uzaklığı = 642 km");
                    break;
                case "Tunceli":
                    Console.Write("Kastamonu ilinin Tunceli iline olan uzaklığı = 748 km");
                    break;
                case "Şanlıurfa":
                    Console.Write("Kastamonu ilinin Şanlıurfa iline olan uzaklığı = 952 km");
                    break;
                case "Uşak":
                    Console.Write("Kastamonu ilinin Uşak iline olan uzaklığı = 613 km");
                    break;
                case "Van":
                    Console.Write("Kastamonu ilinin Van iline olan uzaklığı = 1219 km");
                    break;
                case "Yozgat":
                    Console.Write("Kastamonu ilinin Yozgat iline olan uzaklığı = 296 km");
                    break;
                case "Zonguldak":
                    Console.Write("Kastamonu ilinin Zonguldak iline olan uzaklığı = 271 km");
                    break;
                case "Aksaray":
                    Console.Write("Kastamonu ilinin Aksaray iline olan uzaklığı = 425 km");
                    break;
                case "Bayburt":
                    Console.Write("Kastamonu ilinin Bayburt iline olan uzaklığı = 711 km");
                    break;
                case "Karaman":
                    Console.Write("Kastamonu ilinin Karaman iline olan uzaklığı = 614 km");
                    break;
                case "Kırıkkale":
                    Console.Write("Kastamonu ilinin Kırıkkale iline olan uzaklığı = 219 km");
                    break;
                case "Batman":
                    Console.Write("Kastamonu ilinin Batman iline olan uzaklığı = 1055 km");
                    break;
                case "Şırnak":
                    Console.Write("Kastamonu ilinin Şırnak iline olan uzaklığı = 1239 km");
                    break;
                case "Bartın":
                    Console.Write("Kastamonu ilinin Bartın iline olan uzaklığı = 182 km");
                    break;
                case "Ardahan":
                    Console.Write("Kastamonu ilinin Ardahan iline olan uzaklığı = 987 km");
                    break;
                case "Iğdır":
                    Console.Write("Kastamonu ilinin Iğdır iline olan uzaklığı = 1097 km");
                    break;
                case "Yalova":
                    Console.Write("Kastamonu ilinin Yalova iline olan uzaklığı = 462 km");
                    break;
                case "Karabük":
                    Console.Write("Kastamonu ilinin Karabük iline olan uzaklığı = 112 km");
                    break;
                case "Kilis":
                    Console.Write("Kastamonu ilinin Kilis iline olan uzaklığı = 875 km");
                    break;
                case "Osmaniye":
                    Console.Write("Kastamonu ilinin Osmaniye iline olan uzaklığı = 776 km");
                    break;
                case "Düzce":
                    Console.Write("Kastamonu ilinin Düzce iline olan uzaklığı = 291 km");
                    break;
                default:
                    Console.Write("HATALI İL GİRİŞİ YAPTINIZ");
                    break;
            }

            Console.Read();
        }
    }
}
