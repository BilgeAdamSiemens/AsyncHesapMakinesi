using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncHesapMakinesi
{
    public class HesapMakinesi
    {
        private double sayi1;
        private double sayi2;
        private char islem;
        private double sonuc;
        public HesapMakinesi()
        {
            Sayi1 = sayi1;
            Sayi2 = sayi2;
            Islem = islem;
            Sonuc = sonuc;
        }

        public double Sayi1 
        {
            get
            {
                return sayi1;
            }
            set 
            {
                sayi1 = value;
            } 
        }
        public double Sayi2 { get; set; }
        public char Islem { get; set; }
        public double Sonuc { get; set; }

        public static async void Toplama(double _sayi1, double _sayi2)
        {
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //await Toplama();
            HesapMakinesi hm = new HesapMakinesi();
            Console.WriteLine("Birinci sayı:");
            hm.Sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İşlem tipi:");
            hm.Islem = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("İkinci sayı:");
            hm.Sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(AsyncHesapla(hm.Sayi1, hm.Sayi2, hm.Islem));
            


        }

        public static async Task<double> AsyncHesapla(double _sayi1, double _sayi2, char _islemTipi)
        {
            Task<double> sonuc = Task.Run(() => {
                switch (_islemTipi)
                {
                    case '+':
                        sonuc = _sayi1 + _sayi2;
                        break;
                    case '-':
                        sonuc = _sayi1 - _sayi2;
                        break;
                    case '*':
                        sonuc = _sayi1 * _sayi2;
                        break;
                    case '/':
                        sonuc = _sayi1 / _sayi2;
                        break;
                    default:
                        break;
                }
            });
            

            return _sayi1 + _sayi2;
        }

    }
}
