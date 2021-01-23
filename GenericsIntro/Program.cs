using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("xxx");
            Console.WriteLine(isimler.Length);

            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(1);
            sayilar.Add(3);
            sayilar.Add(8);
            Console.WriteLine(sayilar.Length);



        }

    }

}
