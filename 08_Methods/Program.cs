using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void (Geriye Değer Döndürmeyen)
            void Costomerlİst() //methods  oluştu
            {
                Console.WriteLine("Ali Yıldız");
                Console.WriteLine("Mehmet Ali");
                Console.WriteLine("Müşteri Listesi Metot");
            }
            Costomerlİst();//method çağırıldı.
            Costomerlİst();//method çağırıldı.

            void sum() //method oluştu.
            {
                int x = 1; int y = 2; int z = 3;
                Console.WriteLine(x + y + z);
            }
            sum();//method çağırıldı.


            #endregion


            #region Geriye Değer Dönmeyen Parametre Alan
            void write(string s) //method oluştu
            {
                Console.WriteLine(s);
            }

            write("Ahmet Apuhan"); //method içine parametre alarak çağırıldı.

            void write2(string s, string s1) //2 parametre alacak.
            {
                Console.WriteLine("Adı: " + s + " " + "Soyadı: " + s1);
            }
            write2("Ahmet ", "Apuhan "); //method çağırıldı.
            write2("Mehmet ", "Canlı");

            void sum1(int x, int y, int z)
            {
                Console.WriteLine("Toplam= " + (x + y + z));
            }
            sum1(2, 4, 7);





            #endregion

            #region Geriye Değer Döndüren Method
            string studentCard()
            {
                string name = "Ali";
                string surname = "Muşlu";
                return name + " " + surname;
            }
            Console.WriteLine(studentCard());


            string countryCard(string cName, string cCapital, string cFlagColor)
            {
                string cardinfo = "Ülke: " + cName + "Başkent :" + cCapital + " " + "Bayrak Rengi: " + cFlagColor;
                return cardinfo;
            }
            string a, b, c;

            Console.Write("Ülke Adı: ");
            a = Console.ReadLine();


            Console.Write("Başkent :");
            b = Console.ReadLine();


            Console.Write("Bayrak Rengi: ");
            c = Console.ReadLine();

            Console.WriteLine(countryCard(a, b, c));


            int toplama(int s1, int s2)
            {
                int result = s1 + s2;
                return result;
            }
            Console.WriteLine(toplama(12, 46));



            #endregion
            Console.Read();
        }
    }
}
