using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GercekMusteri musteri1 = new GercekMusteri() {
                Adi="Engin", 
                Soyadi="Demiroğ",
                Id=1,
                TcNo="12345678910",
                MusteriNo= "12345",                       
                //Gerçek - Tüzel
                //SOLID
            };
            TuzelMusteri musteri2 = new TuzelMusteri() 
            {
                Id=2,
                MusteriNo="54321",
                SirketAdi="Kodlama.io",
                VergiNo="1234567890",

            };
            Musteri musteri3 = new GercekMusteri() { };
            Musteri musteri4 = new TuzelMusteri();
        }   
    }
}
