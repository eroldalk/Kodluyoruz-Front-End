using System;
using System.Collections;

namespace İntegerİkili
{
    public class Konsol_Islemleri
    {
        public void IlkMesaj()
        {
            System.Console.WriteLine("Lütfen aralarında boşluk olacak şekilde sayı giriniz.");
            System.Console.WriteLine("Eğer ikililer birbirinden farklıysa toplamları, aynıysa toplamlarının karesi ekrana yazılacak.");
            System.Console.WriteLine("İkili olması için n çift sayı olmalıdır.");
            System.Console.WriteLine("input : ");
        }
        public int[] KonsoldanSayılarıAl()
        {
            string input = Console.ReadLine();
            string[] stringSayılar = input.Split(" "); 
            int[] sayılar = new int[stringSayılar.Length]; 
            int i = 0;
            foreach (var item in stringSayılar)  
            {
                sayılar[i] = int.Parse(item);
                i++;
            }
            return sayılar;
        }
    }
}