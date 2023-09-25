using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoyKiloEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boy Kilo Endeksi
            double boy, kilo, indeks = 0;
            Console.Write("Boyunuzu m cinsinden Giriniz (Ör:165)  : ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz : ");
            kilo = Convert.ToDouble(Console.ReadLine());
            indeks = (kilo / (boy * boy))*10000;
            Console.WriteLine("================================================");
            Console.WriteLine("Vücut Kitle İndexiniz : " + indeks);
            if (indeks < 18.5)
            {
                Console.WriteLine("Zayıf");
            }
            else if (indeks >= 18.5 && indeks < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (indeks >= 25 && indeks < 30)
            {
                Console.WriteLine("Kilolu");
            }
            else if (indeks >= 30 && indeks < 35)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Morbid Obez");
            }
            //--------incele-----------
            //Console.ReadKey();
            //double sayi = 15.4568;
            //Console.WriteLine(Math.Round(sayi, 2));
            //string deger = Console.ReadLine();
            //deger = deger.Replace(',', '.');
            //double boy = Convert.ToDouble(deger);
            Console.ReadKey();
        }
    }
}
