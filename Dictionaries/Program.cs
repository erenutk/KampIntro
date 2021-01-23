using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciListesi = new MyDictionary<int, string>();
            ogrenciListesi.Add(1, "Eren");
            ogrenciListesi.Add(2, "Utku");
            ogrenciListesi.Add(3, "Elif");

            for (int i = 0; i < ogrenciListesi.Length; i++)
            {
                Console.WriteLine("Numara : " + ogrenciListesi.Key[i] + " İsim : "+ ogrenciListesi.Value[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Öğrenci Sayısı : " + ogrenciListesi.Length);
        }
    }
}
