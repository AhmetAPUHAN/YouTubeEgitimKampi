using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach
            string[] cities = { "milano", "adana", "istanbul", "varşova" };
            foreach (string city in cities) { Console.WriteLine(city); }

            int[] numbers = { 1, 3, 5, 2, 8, 12, 75 };
            foreach (int number in numbers) { Console.WriteLine(number); }

            foreach (int number in numbers)
            {
                if (number % 2 == 0) { Console.WriteLine(number); }
            }

            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            Console.WriteLine(total);



            #endregion
            #region Lİst    

            List<int> liste = new List<int>()
            {
                1,2,3,4,56,8,64,6
            };
            foreach (int number in liste) { Console.WriteLine(number); }

            string word = "merhaba";
            foreach (char c in word) { Console.WriteLine(c); }

            #endregion


            #region Örnek Sınav Sistemi
            Console.Write("**Sınav Sistemi**");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("sınıfınızda kaç öğrenci var? ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.Öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;

                for (int j = 0; j < 3; j++) //sınav notu girişi
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}.sınav notunu giriniz. ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyor
                }

                studentExamAvg[i] = totalExamResult / 3;
            }


            //sınav ortalamaları ve isim bilgileri
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması :{studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50) // geçme kalma durumu 
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else { Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı."); }
            }









            #endregion

            Console.Read();
        }
    }
}
