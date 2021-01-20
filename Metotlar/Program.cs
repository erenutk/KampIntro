using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};
            Urun[] ur = new Urun[] { };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("");
            Console.WriteLine("---------Metotlar-------------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            foreach (var urun in urunler)
            {
                sepetManager.Ekle(urun);
            }
            sepetManager.Ekle2("Armut","Yeşil armut", 12,9);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,7);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);



        }
    }
}


