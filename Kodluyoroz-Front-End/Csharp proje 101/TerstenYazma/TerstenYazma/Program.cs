using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.Write("İlk hali : ");
        string veri = Console.ReadLine();

        var dizi = veri.ToArray();

        var yenidizi =  dizi.Reverse();

        string yeniveri = string.Join("", yenidizi);
        Console.WriteLine($"Son hali : {yeniveri}");

        
    }
}