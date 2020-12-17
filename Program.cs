using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncHesapMakinesi
{
    class Program
    {
        // HesapMakinesi sınıfının öğeleri ve metodları.
        public class HesapMakinesi
        {
            public static double Sayi1 { get; set; }
            public static double Sayi2 { get; set; }
            public static char Islem { get; set; }
            public static Task<double> Sonuc { get; set; }

            static async Task<double> AsyncToplama(double _sayi1, double _sayi2)
            {
                var sonuc = await Task.Run(() => (_sayi1 + _sayi2));
                Console.WriteLine($"{_sayi1} + {_sayi2} = {sonuc}");
                return sonuc;
            }
            static async Task<double> AsyncCikarma(double _sayi1, double _sayi2)
            {
                var sonuc = await Task.Run(() => (_sayi1 - _sayi2));
                Console.WriteLine($"{_sayi1} - {_sayi2} = {sonuc}");
                return sonuc;
            }
            static async Task<double> AsyncCarpma(double _sayi1, double _sayi2)
            {
                var sonuc = await Task.Run(() => (_sayi1 * _sayi2));
                Console.WriteLine($"{_sayi1} * {_sayi2} = {sonuc}");
                return sonuc;
            }
            static async Task<double> AsyncBolme(double _sayi1, double _sayi2)
            {
                var sonuc = await Task.Run(() => (_sayi1 / _sayi2));
                Console.WriteLine($"{_sayi1} / {_sayi2} = {sonuc}");
                return sonuc;
            }

            public static void AsyncIslem(char _islem)
            {
                switch (_islem)
                {
                    case '+':
                        Sonuc = AsyncToplama(Sayi1, Sayi2);
                        Sonuc.Wait();
                        break;
                    case '-':
                        Sonuc = AsyncCikarma(Sayi1, Sayi2);
                        Sonuc.Wait();
                        break;
                    case '*':
                        Sonuc = AsyncCarpma(Sayi1, Sayi2);
                        Sonuc.Wait();
                        break;
                    case '/':
                        Sonuc = AsyncBolme(Sayi1, Sayi2);
                        Sonuc.Wait();
                        break;
                    default:
                        Sonuc = null;
                        Console.WriteLine("Yanlış işlem!");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            // Static 
            Console.WriteLine("Birinci sayı:");
            HesapMakinesi.Sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci sayı:");
            HesapMakinesi.Sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İşlem tipi:");
            HesapMakinesi.Islem = Convert.ToChar(Console.ReadLine());
            HesapMakinesi.AsyncIslem(HesapMakinesi.Islem);
            HesapMakinesi.Sonuc.Wait();
        }

    }
}
