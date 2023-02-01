using System;

namespace Csharp_homework_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kuş", "köpek", "kedi", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            
            //döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını girin");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıdizisi = new int[diziUzunlugu];
            

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz", i + 1);
                sayıdizisi[i] = int.Parse(Console.ReadLine());

            }

            int toplam = 0;
            foreach (var sayi in sayıdizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);

        }
    }
}