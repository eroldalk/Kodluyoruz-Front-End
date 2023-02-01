string secim = "";
double bakiye = 1000;
double ekHesap = 1000;
double ekHesapLimiti = 1000;

do
{
    Console.Write("1-Bakiye Görüntüle \n2-Para Yatırma \n3-Para Çekme \n4-Çıkış \nİşleminiz: ");
    secim = Console.ReadLine();

    switch (secim)
    {
        case "1":
            Console.WriteLine("Bakiyeniz {0} TL", bakiye);
            Console.WriteLine("Ek Hesap Bakiyeniz {0} TL", ekHesap);
            break;
        case "2":
            Console.Write("Yatırmak İstediğiniz Miktar: ");
            double yatirilanMiktar = double.Parse(Console.ReadLine());

            if (ekHesap < ekHesapLimiti)
            {
                double ekHesaptanKullanilan = ekHesapLimiti - ekHesap;
                if (yatirilanMiktar >= ekHesaptanKullanilan)
                {
                    ekHesap = ekHesapLimiti;
                    bakiye = yatirilanMiktar - ekHesaptanKullanilan;
                }
                else
                {
                    ekHesap += yatirilanMiktar;
                }
            }
            else
                bakiye += yatirilanMiktar;

            break;
        case "3":
            Console.Write("Çekmek İstediğiniz Miktar: ");
            double cekilecekMiktar = double.Parse(Console.ReadLine());

            if (cekilecekMiktar > bakiye)
            {
                double toplam = bakiye + ekHesap;
                Console.Write("Ek Hesap Kullanılsın Mı ? (e/h)");
                string ekHesapTercihi = Console.ReadLine();

                if (ekHesapTercihi == "e")
                {
                    if (cekilecekMiktar > ekHesap)
                    {
                        Console.WriteLine("Ek Hesap Bakiyeniz Yetersiz");
                    }
                    else
                    {
                        Console.WriteLine("Paranızı Alabilirsiniz.");
                        ekHesap -= (cekilecekMiktar - bakiye);
                        bakiye = 0;

                    }

                }
                else
                {
                    Console.WriteLine("Bakiyeniz Yeterli Değildir.");

                }

            }
            else
            {
                Console.WriteLine("Paranızı Alabilirsiniz.");
                bakiye -= cekilecekMiktar;

            }

            break;
        case "4":
            Console.WriteLine("Çıkış İşlemi");
            break;
        default:
            Console.WriteLine("Hatalı Seçim Lütfen Menüde Belirtilen İşlemleri Gerçekleştirin.");
            break;
    }
}
while (secim != "4");

Console.WriteLine("Uygulamadan Çıkış Yapıldı...");