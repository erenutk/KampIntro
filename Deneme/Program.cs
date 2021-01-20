using System;

public class Example
{
    public static void Main()
    {
        Console.WriteLine("**********Sayı Tahmin Oyunu**********");
        Console.WriteLine("1 ile 80 arasındaki sayıyı tahmin etmeye çalışın.");
        Console.WriteLine("");


        int sayi = new Random().Next(1, 81);
        string tahminEdiniz = "Tahmin ettiğiniz sayı: ";
        Console.WriteLine(tahminEdiniz);
        var sayiTahmin = Int32.Parse(Console.ReadLine());

        while (true)
        {


            if (sayiTahmin > sayi)
            {
                Console.WriteLine("Tahmin ettiğiniz sayı daha küçük olmalı.");
                sayiTahmin = Int32.Parse(Console.ReadLine());
            }
            else if (sayiTahmin < sayi)
            {
                Console.WriteLine("Tahmin ettiğiniz sayı daha büyük olmalı.");
                sayiTahmin = Int32.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Tebrikler doğru sayıyı buldunuz.");
                break;            
            }
        }
    }
}
