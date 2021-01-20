using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself
            //değer tutucu, alias

            string kategoriEtiketi = "Kategori"; // çift tırnakla oluyor tek tırnak olmuyor
            int ogrenciSayisi = 3200; // tam sayı ama çok büyük sayılar olmuyor
            double faizOrani = 1.45; // ondalıklı sayılar
            bool sistemeGirisYapmisMi = true;   //true false
            float x = 4.5f;
            char a = 'x';
            decimal y = 4.5m;

            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
          
            
            if (sistemeGirisYapmisMi == true) //if yazıp 2 kere taba basılırsa otomatik oluşuyor
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");

            }
            




            

        }
    }
}
