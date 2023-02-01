using System;

namespace MutlakKareAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            MutlakKare mutlak=new MutlakKare();
            Console.Write("Lütfen bir sayı giriniz..:");
            int count =int.Parse(Console.ReadLine());
            mutlak.KareAlma(count);
        }
    }
}