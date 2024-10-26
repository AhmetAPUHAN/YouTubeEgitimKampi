using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Diziler
            string[] colors = new string[4];
            colors[0] = "Beyaz";
            colors[1] = "Siyah";
            colors[2] = "Kırmızı";
            colors[3] = "Bordo";
            Console.WriteLine(colors[0]);


            string[] cities = new string[4];
            cities[0] = "Milano";
            cities[1] = "Adana";
            cities[2] = "Lyon";
            cities[3] = "Budapeşte";
            Console.WriteLine(cities[0] + " " + cities[1]);

            Console.WriteLine("****Tüm dizi****");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }


            string[] contry = { "Türkiye", "Yunanistan" };
            Console.WriteLine(contry.Length); //dizi uzunluğunu verir.


            int[] numbers = { 3, 56, 26, 48, 29, 65, 89, 46, 99, 36 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.Write("3 e kalansız bölünen sayı: ");
                    Console.WriteLine(numbers[i]);
                }
            }

            int maxNumber = numbers[0]; //maxnumber adında değişken tanımladın ve dizinin bir index atadı değeri

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            Console.Write("Dizinin en büyük sayısı: ");
            Console.Write(maxNumber);


            #endregion

            #region Dizi Metot

            //length dizi uzunluğu
            Console.WriteLine(cities.Length);

            //short sıralama
            Console.WriteLine("Dizinin sırasız hali");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine(numbers[6]);


            Array.Sort(numbers);
            Console.WriteLine("Dizinin sıralı hali");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine(numbers[6]);


            //ındexof aranan dizi elemanının index verir
            int index = Array.IndexOf(numbers, 36);
            Console.WriteLine("36 numbers dizisinin " + index + " nolu indexinde");

            //Kullanıcıdan Değer alma 
            string[] sehir = new string[5];
            for (int i = 0; i < sehir.Length; i++)
            {
                Console.Write($"Lütfen {i + 1} .  Şehri giriniz: ");
                sehir[i] = Console.ReadLine();
            }
            Console.WriteLine("Belirlenen Şehirler:");
            for (int i = 0; i < sehir.Length; i++)
            { Console.WriteLine(sehir[i]); }


            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);

            #endregion


            Console.Read();
        }
    }
}
