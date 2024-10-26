using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF 
            //örnek 1
            Console.Write("Lütfen Şifre Giriniz: ");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else { Console.WriteLine("Şifre Hatalı"); }


            //örnek 2
            string capital, country;
            Console.Write("Başkent girin: ");
            capital = Console.ReadLine();
            Console.Write("Ülke girin: ");
            country = Console.ReadLine();

            if (capital == "ankara" | capital == "Ankara" & country == "türkiye" | country == "Türkiye")
            {
                Console.WriteLine("Cevap doğru");
            }
            else
            {
                Console.WriteLine("Cevap yanlış");
            }

            //örnek 3
            int number;
            Console.Write("Sayı Giriniz :");
            number = int.Parse(Console.ReadLine());
            if (number == 5)
            { Console.WriteLine("Sayı doğru"); }
            else
            { Console.WriteLine("Sayı yalnış"); }


            //örnek 4
            int exam1, exam2, exam3, avarage;
            string result = " ";

            Console.Write("1.sınav: ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("2.sınav :");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("3.sınav :");
            exam3 = int.Parse(Console.ReadLine());

            avarage = (exam1 + exam2 + exam3) / 3;

            if (avarage < 50)
            {
                result = "Başarısız";
            }
            if (50 < avarage & avarage < 70)
            {
                result = "Orta";
            }
            if (70 < avarage & avarage < 80)
            {
                result = "İyi";

            }
            if (80 < avarage)
            {
                result = "Pekiyi";
            }
            Console.WriteLine(result);

            //örnek 4
            string username;
            Console.Write("Kullanıcı adı giriniz: ");
            username = Console.ReadLine();
            if (username != "admin")
            {
                Console.WriteLine("Kullanıcı adı hatalı: ");
            }
            else { Console.WriteLine("Hoş Geldiniz: "); }

            #endregion


            #region Mod
            int number1;
            number1 = 26;
            int result1 = number % 5;
            Console.Write(result1);


            //mod örneği
            Console.WriteLine("Sayı giriniz: ");
            int number2 = int.Parse(Console.ReadLine());
            if (number2 % 2 == 0)
            {
                Console.Write("Sayı çift");
            }
            else
            {
                Console.WriteLine("Sayi tek");
            }





            #endregion

            #region Menü Örneği
            Console.WriteLine("*****Menü*****");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Pizzalar");
            Console.WriteLine("3-Çorbalar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("------------------------");
            Console.WriteLine("*****Menü*****");

            string menuItem;
            Console.WriteLine("Menü seçiniz");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Ana Yemekler");
                Console.WriteLine("1-Kebap");
                Console.WriteLine("2-Ali Nazik");
                Console.WriteLine("3-Fasulye ");
                Console.WriteLine("4-Pilav");
                Console.WriteLine("------------------");

            }
            if (menuItem == "2")
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Pizzalar");
                Console.WriteLine("1-Karışık Pizza");
                Console.WriteLine("2-Tavuklu Pizza");
                Console.WriteLine("3-Süperbol Pizza ");
                Console.WriteLine("------------------");
            }
            if (menuItem == "3")
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Çorbalar");
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Ezogelin Çorbası");
                Console.WriteLine("------------------");
            }
            if (menuItem == "4")
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Salatalar");
                Console.WriteLine("1-Gavurdağ Salata");
                Console.WriteLine("2-Mevsim Salata");
                Console.WriteLine("3-Roka Salatası");
                Console.WriteLine("------------------");
            }
            if (menuItem == "5")
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Tatlılar");
                Console.WriteLine("1-Baklava");
                Console.WriteLine("2-Kadayıf");
                Console.WriteLine("3-Halka tatlısı ");
                Console.WriteLine("4-Sufle");
                Console.WriteLine("------------------");
            }

            #endregion

            #region Switch Case 

            Console.Write("Ay Girişi Yapınız:");
            int montNumber = int.Parse(Console.ReadLine());
            switch (montNumber)
            {
                case 1: Console.WriteLine("Ocak"); break;
                case 2: Console.WriteLine("Şubat"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("Nisan"); break;
                case 5: Console.WriteLine("Mayıs"); break;
                case 6: Console.WriteLine("Haziran"); break;
                case 7: Console.WriteLine("Temmuz"); break;
                case 8: Console.WriteLine("Agustos"); break;
                case 9: Console.WriteLine("Eylül"); break;
                case 10: Console.WriteLine("Ekim"); break;
                case 11: Console.WriteLine("Kasım"); break;
                case 12: Console.WriteLine("Aralık"); break;
                default: Console.WriteLine("Hatalı Giriş"); break;

            }

            //switch Örneği Hesap Makinesi
            int sayi1, sayi2, result2;
            char sembol;
            Console.Write("1. Sayı giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayı giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());
            Console.Write("Yapılacak işlemi Giriniz: ");
            sembol = char.Parse(Console.ReadLine());

            switch (sembol)
            {
                case ('-'): Console.WriteLine(sayi1 - sayi2); break;
                case ('+'): Console.WriteLine(sayi1 + sayi2); break;
                case ('/'): Console.WriteLine(sayi1 / sayi2); break;
                case ('*'): Console.WriteLine(sayi1 * sayi2); break;
                default: Console.WriteLine("Hatılı seçim"); break;
            }








            #endregion
            Console.Read();
        }
    }
}
