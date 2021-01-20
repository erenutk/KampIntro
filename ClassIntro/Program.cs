﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[]
            {
            kurs1, kurs2, kurs3, kurs4
            };

            foreach (Kurs kurs in kurslar)  //var verildiği zaman hangi veri tipindeyse o çalışır Kurs yerine var yazmak aynı şey
            {
                Console.WriteLine(kurs.KursAdi + " - " + kurs.IzlenmeOrani);
            }
            while (true)
            {
                Console.WriteLine("Helal Eren");
                break;
            }
            Console.WriteLine("");
            Console.WriteLine("Merhaba\tDünya\n\n");
            Console.WriteLine("ayn");


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Yazılım Kampına Hoşgeldiniz");
            }
            Console.WriteLine("");
            int a = 1;
            while (a <=10)
            {
                Console.WriteLine("Yazılım Kampına Hoşgeldiniz\n");
                a++;
            }


        }


    }

    class Kurs
    {
        public string KursAdi { get; set; } //prop tab tab property:özellik
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
        public int MyProperty { get; set; }

    }
}
