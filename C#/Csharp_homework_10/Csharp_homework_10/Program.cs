﻿using System;

namespace Csharp_homework_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17,};

            Console.WriteLine("********Sırasız Dizi ****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("********Sıralı Dizi ****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Clear
            Console.WriteLine("********Array Clear****");
            // sayıDizisi elemanları kullanarak 2.index ten itibaren 2 tane elemanı 0'lar
            Array.Clear(sayiDizisi, 2, 2);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //reverse
            Console.WriteLine("********Array Reverse****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //IndexOf
            Console.WriteLine("********Array Indexof****");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));
            
            //resize
            Console.WriteLine("********Array Resize****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
