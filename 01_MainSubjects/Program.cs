using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            Console.WriteLine("Merhaba Dünya");
            Console.Write("Merhaba Dünya");

            Console.WriteLine("****Yemek Kategorileri****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine();
            Console.WriteLine("****Yemek Kategorileri****");
            #endregion

            #region Değişkenler
            string customerName;
            string customerSurname;
            string city;
            string country, district, phone;
            customerName = "Ahmet";
            customerSurname = "Apuhan";
            phone = "5065772932";
            city = "İstanbul";
            district = "Sancaktepe";
            country = "Türkiye";
            Console.WriteLine("***Rezervasyon Kartı***");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim :" + phone);
            Console.WriteLine("Adres: " + district + "/ " + city + " " + country);
            Console.WriteLine("--------------------------");

            customerName = "Mehmet";
            customerSurname = "Delice";
            phone = "5065772932";
            city = "İzmir";
            district = "Alsancak";
            country = "Türkiye";
            Console.WriteLine("***Rezervasyon Kartı***");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim :" + phone);
            Console.WriteLine("Adres: " + district + "/ " + city + " " + country);
            Console.WriteLine("--------------------------");


            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 20;
            int pizzaPrice = 100;

            Console.WriteLine("*****Restoran Menü Fiyatı*****");
            Console.WriteLine();
            Console.WriteLine("-Hamburger: " + hamburgerPrice + "Tl");
            Console.WriteLine("-Kola: " + cokePrice + " TL");
            Console.WriteLine("-Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-Su: "+waterPrice+" TL");
            Console.WriteLine();
            Console.WriteLine("****Sipariş****");

            int toplam;
            int hamburgerCount = 3;
            int cokeCount = 2;
            int waterCount = 4;
            int pizzaCount = 1;

            toplam = hamburgerCount * hamburgerPrice + cokePrice * cokeCount + waterPrice * waterCount + pizzaCount * pizzaPrice;
            Console.WriteLine("Toplam Tutar: " + toplam);


            #endregion





            Console.Read();
        }
    }

}

