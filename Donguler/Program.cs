using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            //array - dizi

            string[] kurslar = new string[]  { "Yazılım Geliştirici Yetiştirme Kampı" ,
                "Programlamaya başlangıç için temel kurs",
                "Java" , "Python"  }; //kurs1 kurs2 ... diye yaz string yerine @@@@@@@@
          
            
            
           
            
            for (int i = 0; i < kurslar.Length; i++) //i++ i+=2
            {
                Console.WriteLine(kurslar[i]); 
              
            }

            Console.WriteLine("");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
