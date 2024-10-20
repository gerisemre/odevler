using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GedikÖdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İki Sayının Farkını Bulan C# Kodu
            int s1, s2, toplam;
            Console.Write("1. Sayıyı giriniz: ");

            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: ");
            
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = s1 - s2;
            Console.WriteLine("Toplam : " + toplam);

            Console.WriteLine("Farkları");

            //5 Sayısının karesini bulan uygulama
            int sayi = 5;
            Console.WriteLine("Sayının Karesi :" + (sayi * sayi).ToString());

            // 10 sayısının 3 e bölümünden kalanı bulma (%-mod alma- operatörü kullanılır)
            int on = 10;
            Console.WriteLine(on % 3);
            Console.ReadKey();
            // Klavyeden girilen 4 sayinin toplamini ve çarpimini bulan uygulama

            Console.WriteLine("Lütfen 4 Adet Sayı Girin");
            int say1 = Convert.ToInt16(Console.ReadLine());
            int say2= Convert.ToInt16(Console.ReadLine());
            int say3 = Convert.ToInt16(Console.ReadLine());
            int say4 = Convert.ToInt16(Console.ReadLine());

            int top;
            int carp;

            top = say1 + say2 + say3 + say4;
            carp = say1*say2*say3*say4;
            Console.WriteLine("Sayıların Toplamı :" + top.ToString());
            Console.WriteLine("Sayıların Carpimi:" + carp.ToString());

            //Klavyeden Girilien İki Sayının Bölümünü Bulan Uygulama

            Console.WriteLine("Lütfen iki adet sayı girin");
            int sa1 = Convert.ToInt16(Console.ReadLine());
            int sa2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Cevap :" + (s1/s2).ToString());

            //Dikdörtgen prizmasının hacmini bulan uygulama

            Console.WriteLine("Lütfen Dikdörtgenin Kenarlarını Giriniz:");
            int ken1 = Convert.ToInt16(Console.ReadLine());
            int ken2 = Convert.ToInt16(Console.ReadLine());
            int ken3 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Dikdörtgenler Prizmasının Hacmi :"+(ken1*ken2*ken3).ToString());

        }
    }
}
