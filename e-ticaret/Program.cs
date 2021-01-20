using System;

namespace e_ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Brand = "Monster";
            product1.Name = "Abra A5";
            product1.Price = 7694.05;
            product1.Score = 4.6;

            Product product2 = new Product();
            product2.Brand = "Apple";
            product2.Name = "Macbook Air";
            product2.Price = 7199;
            product2.Score = 5;

            Product product3 = new Product();
            product3.Brand = "Huawei";
            product3.Name = "Matebook D 14";
            product3.Price = 6288;
            product3.Score = 4.8;

            Product product4 = new Product();
            product4.Brand = "Lenovo";
            product4.Name = "V15";
            product4.Price = 6310.22;
            product4.Score = 2.2;

            Product[] products = new Product[] 
            {
                product1,product2,product3,product4    
            };

            Console.WriteLine("for \n");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Brand +" "+ products[i].Name +": "+ products[i].Price + " TL" +" - "+ products[i].Score +" Puan" );
            }

            Console.WriteLine("");
            Console.WriteLine("foreach \n");

            foreach (Product product in products)
            {
                Console.WriteLine(product.Brand + " " + product.Name + ": " + product.Price + " TL" + " - " + product.Score + " Puan");
            }

            Console.WriteLine("");
            Console.WriteLine("while \n");
            
            int a = 0;
            while (a < products.Length )
            {
                Console.WriteLine(products[a].Brand + " " + products[a].Name + ": " + products[a].Price + " TL" + " - " + products[a].Score + " Puan");
                a++;
            }


        }
    }


    class Product
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Score { get; set; }
    }








}   

