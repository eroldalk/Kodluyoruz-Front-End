using System;
using System.Collections;

class program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir cümle giriniz:");
        string cumle = Console.ReadLine(); 
        Metod(cumle);
    }

    static void Metod(string cumle)
    {
        char[] cımbız = { ' ' };
        string[] cımbızlanmıs = cumle.Split(cımbız); 
        for (int sayar = 0; sayar < cımbızlanmıs.Length; sayar++)
        {
            char[] harfler = cımbızlanmıs[sayar].ToCharArray(); 
            char yedek = harfler[0];
            harfler[0] = harfler[harfler.Length - 1];
            harfler[harfler.Length - 1] = yedek;
            string yenikelime = string.Concat(harfler);
            System.Console.Write(yenikelime + " ");
        }
    }
}