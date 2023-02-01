using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Kare : IHesaplama
    {
        private float _kenar, _yukseklik;

        public float Alan()
        {
            Console.Clear();
            Console.Write("Bir Kenarı Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float kenar))
            {
                _kenar = kenar;
            }

            return _kenar * _kenar;
        }

        public float Cevre()
        {

            Console.Clear();
            Console.Write("Bir Kenarı Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float kenar))
            {
                _kenar = kenar;
            }

            return 4 * _kenar;
        }

        public float Hacim()
        {
            Console.Clear();
            Console.Write("Bir Kenarı Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float kenar))
            {
                _kenar = kenar;
            }
            Console.Write("Yükseklik Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float yukseklik))
            {
                _yukseklik = yukseklik;
            }


            return _kenar * _kenar * _yukseklik;
        }
    }
}
