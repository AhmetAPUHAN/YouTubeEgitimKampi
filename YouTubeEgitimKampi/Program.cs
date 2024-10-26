using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeEgitimKampi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            for (int i = 3; i < 10; i++)
            {
                Console.WriteLine("Eğitim Kampı");
            }

            for (int i = 0; i < 50; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.Write("Kaç defa yazılsın?:");
            int finishValue = int.Parse(Console.ReadLine());
            for (int i = 1; i < finishValue; i++)
            {
                Console.WriteLine("Yaşasın Cumhuriyet");
            }

            for (int i = 0; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);

                }

            }

            int totalValue = 0;
            for (int i = 0; i < 10; i++)
            {
                totalValue += i;
                Console.WriteLine(totalValue);
            }

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    totalValue += i;
                    Console.WriteLine(i);
                }
            }

            int count = 0;
            for (int i = 1; i < 60; i++)
            {
                if (i % 7 == 0)
                {
                    count++;
                }

            }
            Console.WriteLine(count);

            int bacterium = 1;
            for (int i = 1; i <= 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + ".saat sonunda :" + bacterium);
            }
            #endregion


            #region While Döngüsü

            int k = 1;
            while (k <= 10)
            {
                Console.WriteLine("Merhaba Döngüler");
                k++;
            }

            int j = 1;
            while (j <= 10)
            {
                if (j % 3 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            int i1 = 1;
            int sum = 0;
            while (i1 <= 10)
            {

                sum += i1;
                i1++;

            }


            Console.WriteLine(sum);


            Console.WriteLine("3 basamaklı sayı giriniz");
            int i2 = int.Parse(Console.ReadLine());
            int a1 = i2 / 100;

            int a3 = i2 % 10;
            int a2 = (i2 % 100) / 10;
            int top = a1 + a2 + a3;
            Console.WriteLine(top);

            #endregion

            #region ALT ALTA 10 YILDIZ
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("*");
            }

            //ALT ALTA HER SATIRDA 10 YILDIZ
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("**********");

            }
            #endregion
            #region DİK ÜÇGEN 
            for (int i = 1; i < 10; i++)
            {


                for (int z = 1; z <= i; z++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();


            }
            for (int i = 10; i >= 1; i--)
            {

                for (int z = 1; z <= i; z++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
            #endregion

            #region ELMAS

            int s = 5;
            for (int i = 1; i < s; i++)
            {
                for (int z = s - i; z > 0; z--)
                {
                    Console.Write(" ");
                }
                for (int n = 1; n <= 2 * i - 1; n++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            int m = 5;
            for (int i = m; i >= 1; i--)
            {
                for (int l = m - i; l > 0; l--)
                {
                    Console.Write(" ");
                }
                for (int e = 1; e <= 2 * i - 1; e++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            #endregion





            Console.Read();
        }
    }
}
