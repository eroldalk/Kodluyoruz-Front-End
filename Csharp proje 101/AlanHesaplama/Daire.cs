using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Daire : IHesaplama
    {
        private float _yaricap, _yukseklik;
        private const float pi = 3.14f;

        public float Alan()
        {
            Console.Clear();
            Console.Write("Yarı Çap Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float yaricap))
            {
                _yaricap = yaricap;
            }

            return pi * (_yaricap * _yaricap);
        }

        public float Cevre()
        {

            Console.Clear();
            Console.Write("Yarı Çap Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float yaricap))
            {
                _yaricap = yaricap;
            }

            return 2 * pi * _yaricap;
        }

        public float Hacim()
        {

            Console.Write("Yarı Çap Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float yaricap))
            {
                _yaricap = yaricap;
            }
            Console.Write("Yükseklik Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float yukseklik))
            {
                _yukseklik = yukseklik;
            }


            return pi * (_yaricap * _yaricap) * _yukseklik;
        }
    }
}
