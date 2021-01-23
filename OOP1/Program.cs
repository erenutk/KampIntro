using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Id = 1,
                CategoryId = 2,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitsInStock = 3,
            };
            Product product2 = new Product { Id = 2, CategoryId= 5, UnitsInStock=5, ProductName="Kalem", UnitPrice=35};

            //PascalCase   //camelCase
            //case sensitive(küçük büyük harf duyarlılığı)
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Topla2(3, 6);



        }
    }
}
