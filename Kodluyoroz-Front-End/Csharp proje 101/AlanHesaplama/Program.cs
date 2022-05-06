using AlanHesaplama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    

        Dictionary<int, object> menu = new Dictionary<int, object>();
        menu.Add(1, new Daire());
        menu.Add(2, new Ucgen());
        menu.Add(3, new Kare());
        menu.Add(4, new Dikdortgen());
        Dictionary<int,string> menu2 = new Dictionary<int,string>();
        menu2.Add(1, "Alan");
        menu2.Add(2, "Çevre");
        menu2.Add(3, "Hacim");

        Console.WriteLine("Seçim Yapınız :  ");
        foreach (var item in menu)
        {
             Console.WriteLine("({0}) {1}", item.Key, item.Value.GetType().Name);
         }
        byte code = InputControl();

    if (menu.TryGetValue(code,out var value))
{
    
    if (value.GetType().Name=="Dikdortgen")
    {
        Console.Clear();
        Dikdortgen dikdortgen = (Dikdortgen)value;
        string result = Menu(menu2);
        if (result=="Alan")
        {
            Console.WriteLine("Sonuc : {0}", dikdortgen.Alan());
        }
        if (result=="Çevre")
        {
            Console.WriteLine("Sonuc : {0}", dikdortgen.Cevre());
        }
        if (result=="Hacim")
        {
            Console.WriteLine("Sonuc : {0}", dikdortgen.Hacim());
        }
    }


    if (value.GetType().Name == "Daire")
    {
        Console.Clear();
        Daire daire = (Daire)value;
        string result = Menu(menu2);
        if (result == "Alan")
        {
            Console.WriteLine("Sonuc : {0}", daire.Alan());
        }
        if (result == "Çevre")
        {
            Console.WriteLine("Sonuc : {0}", daire.Cevre());
        }
        if (result == "Hacim")
        {
            Console.WriteLine("Sonuc : {0}", daire.Hacim());
        }
    }

    if (value.GetType().Name == "Kare")
    {
        Console.Clear();
        Kare kare = (Kare)value;
        string result = Menu(menu2);
        if (result == "Alan")
        {
            Console.WriteLine("Sonuc : {0}", kare.Alan());
        }
        if (result == "Çevre")
        {
            Console.WriteLine("Sonuc : {0}", kare.Cevre());
        }
        if (result == "Hacim")
        {
            Console.WriteLine("Sonuc : {0}", kare.Hacim());
        }
    }


    if (value.GetType().Name == "Ucgen")
    {
        Console.Clear();
        Ucgen ucgen = (Ucgen)value;
        string result = Menu(menu2);
        if (result == "Alan")
        {
            Console.WriteLine("Sonuc : {0}", ucgen.Alan());
        }
        if (result == "Çevre")
        {
            Console.WriteLine("Sonuc : {0}", ucgen.Cevre());
        }
        if (result == "Hacim")
        {
            Console.WriteLine("Sonuc : {0}", ucgen.Hacim());
        }
    }

}

    static byte InputControl()
{
    byte code = 0;
    Console.Write("İşlem Kodu : ");
    while (!byte.TryParse(Console.ReadLine(), out code) || code < 0)
    {
        Console.Write("İşlem Kodu Geçersiz! Tekrar Giriniz: ");
    }
    return code;
}

    static string Menu(Dictionary<int, string> _menu)
    {
    Console.WriteLine("Seçim Yapınız :  ");
    foreach (var item in _menu)
    {
        Console.WriteLine("({0}) {1}", item.Key, item.Value);
    }
    byte code = InputControl();
    if (_menu.TryGetValue(code, out var value))
    {
        return value;
    }
    else
    {
        return "";
    }

    
    }
