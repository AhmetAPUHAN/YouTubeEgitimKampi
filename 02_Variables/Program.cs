using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            double applePrice, orangaPrice, potatoPrice;
            applePrice = 12.3;
            orangaPrice = 14.5;
            potatoPrice = 8.76;
            Console.WriteLine("Elma Fiyatı: "+applePrice);
            Console.WriteLine("Portakal Fiyatı: " + orangaPrice);
            Console.WriteLine("Patates Fiyatı: "+potatoPrice);

            Console.WriteLine("Sipariş Detayı");
            double appleGram, orangGram, potatoGram;
            appleGram = 123.4;
            orangGram = 34.5;
            potatoGram = 12.53;
            double elmaToplam = applePrice * appleGram;
            double portakalToplam = orangaPrice * orangGram;
            double patatesToplam = potatoPrice * potatoGram;
            Console.WriteLine("Alınan elma tutarı: " +elmaToplam );
            Console.WriteLine("Alınan portakal tutarı: " +portakalToplam );
            Console.WriteLine("Alınan patates tutarı: " +patatesToplam );
            Console.WriteLine("Toplam Tutar: " + (elmaToplam+portakalToplam+patatesToplam));

            #endregion






            Console.Read();
        }
    }
}
