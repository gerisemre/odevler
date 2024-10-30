using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Girilen Sayinin tek cift kontrolu


            Console.Write("Bir sayi giriniz: ");

            int sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0)


                Console.WriteLine("Girilen Sayi Cifttir.");


            else

                Console.WriteLine("Girilen sayi tektir.");



            // 1 den 10 a kadar sayıları ekrana yazı değeri olarak yazma işlemi
            // (örn 1 girildiğinde ekrana BİR yazılsın - switch yapısı)

            Console.Write("Bir sayi giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            switch (sayi2) {


                case 1:
                    Console.WriteLine("BIR");
                    break;
                case 2:
                    Console.WriteLine("IKI");
                    break;
                case 3:
                    Console.WriteLine("UC");
                    break;
                case 4:
                    Console.WriteLine("DORT");
                    break;
                case 5:
                    Console.WriteLine("BES");
                    break;
                case 6:
                    Console.WriteLine("ALTI");
                    break;
                case 7:
                    Console.WriteLine("YEDI");
                    break;
                case 8:
                    Console.WriteLine("SEKIZ");
                    break;
                case 9:
                    Console.WriteLine("DOKUZ");
                    break;
                case 10:
                    Console.WriteLine("ON");
                    break;

                default:

                    Console.WriteLine("1 ile 10 arasinda bir sayi giriniz");
                    break;
            }


            //Kullanıcı adı admin ve şifre Admin_32453@ olduğunda giriş başarılı değilse başarısız uyarısı veren c# kodu

            Console.Write("Kullanici adinizi giriniz: ");
            string isimGiris = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Sifrenizi giriniz: ");
            string sifreGiris = Console.ReadLine();

            if (isimGiris == "admin" && sifreGiris == "Admin_32453@")

                Console.WriteLine("Giris Basarili");

            else Console.WriteLine("Kullanici adiniz veya sifreniz hatali.");

            //Instagram, X gibi uygulamalarda sifre ya da kullanici adindan hangisini yanlis girdigimiz soylenmiyor
            // o yuzden ben de bu sekilde aynisini yaptim.


            //10-20 20-30 30-40 arası sıcaklık durumlarına göre ekrana
            //(normal - sıcak - çok sıcak) uyarısı veren veren c# kodu (if else if else if else yapısı)


            Console.Write("Bir sicaklik degeri giriniz: ");
            int sicaklik = int.Parse(Console.ReadLine());

            if (sicaklik >= 10 && sicaklik < 20)

                Console.WriteLine("normal");

            else if (sicaklik >= 20 && sicaklik < 30)

                Console.WriteLine("sicak");

            else if (sicaklik >= 30 && sicaklik < 40)

                Console.WriteLine("cok sicak");

            else

                Console.WriteLine("10 ile 40 arasinda bir sicaklik giriniz.");




            Console.ReadKey();
        }
    }
}
