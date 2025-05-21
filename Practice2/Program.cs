using System;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("EL", "Электронные весы", 1200, 2);
            product1.PrintProductInfo();
            product1.ProductArrived(-1);
            product1.ProductArrived(12);
            product1.ProductOverpriced(-100);
            product1.ProductOverpriced(1199);
            product1.ProductSold(6);
            product1.PrintProductInfo();

            (string productId, string name, double price, int quantity) = product1;
            Console.WriteLine($"Hello from Deconstruct: {productId} {name} {price} {quantity}");

            PrintSeparator();

            Product product2 = new Product("ML", "Музыкальная шкатулка");
            product2.PrintProductInfo();
            product2.Price = 560;
            product2.Quantity = 32;
            product2.PrintProductInfo();

        }

        public static void PrintSeparator()
        {
            Console.WriteLine("\n_________________________________________\n");
        }
    }
}
