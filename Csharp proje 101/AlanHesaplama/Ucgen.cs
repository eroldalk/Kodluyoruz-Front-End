using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Ucgen:IHesaplama
    {
        private float _a, _b, _c,_yukseklik;

        public float Alan()
        {
            Console.Clear();
            Console.Write("A Kenarı Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float a))
            {
                _a = a;
            }

            Console.Write("B Kenarı Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float b))
            {
                _b = b;
            }

            Console.Write("C Kenarı Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float c))
            {
                _c = c;
            }

            float s = (_a + _b + _c);

            double alan = Math.Sqrt((s * (s - a) * (s - b) * (s - c)));
            return Convert.ToSingle(alan);
        }

        public float Cevre()
        {


            Console.Clear();
            Console.Write("A Kenarı Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float a))
            {
                _a = a;
            }

            Console.Write("B Kenarı Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float b))
            {
                _b = b;
            }

            Console.Write("C Kenarı Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float c))
            {
                _c = c;
            }


            return a+b+c;
        }

        public float Hacim()
        {

            Console.Write("Taban Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float a))
            {
                _a = a;
            }
            Console.Write("Yükseklik Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float yukseklik))
            {
                _yukseklik = yukseklik;
            }

            return a * _yukseklik /2;
        }
    }
}
