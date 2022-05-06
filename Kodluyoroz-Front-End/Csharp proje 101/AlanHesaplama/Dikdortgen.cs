using System;
namespace AlanHesaplama
{
    public class Dikdortgen : IHesaplama
    {
        private float _genislik, _uzunluk, _yukseklik;

        public float Alan()
        {
            Console.Clear();
            Console.Write("Genişlik Giriniz : ");
            if (float.TryParse(Console.ReadLine(),out float genislik))
            {            
                _genislik = genislik;
            }
            Console.Write("Yükseklik Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float yukseklik))
            {
                _yukseklik = yukseklik;
            }
            return _genislik * _yukseklik;
        }

        public float Cevre()
        {

            Console.Write("Genişlik Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float genislik))
            {
                _genislik = genislik;
            }
            Console.Write("Yükseklik Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float yukseklik))
            {
                _yukseklik = yukseklik;
            }
            return 2 * (_genislik + _yukseklik);
        }

        public float Hacim()
        {

            Console.Write("Genişlik Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float genislik))
            {
                _genislik = genislik;
            }
            Console.Write("Yükseklik Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float yukseklik))
            {
                _yukseklik = yukseklik;
            }

            Console.Write("Uzunluk Giriniz : ");
            if (float.TryParse(Console.ReadLine(), out float uzunluk))
            {
                _uzunluk = uzunluk;
            }
            return _uzunluk * _yukseklik * _genislik;
        }
    }
}
