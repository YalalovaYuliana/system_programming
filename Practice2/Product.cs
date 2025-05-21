using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Product
    {
        static int ID;
        string productId;
        string name;
        double price;
        int quantity;


        static Product()
        {
            ID++;
        }

        public string ProductId
        {
            get => productId; 
            set => productId = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Price
        {
            get => price;
            set => price = value > 0 ? value : 0;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value > 0 ? value : 0;
        }

        public Product() {}

        public Product(string productId, string name)
        {
            ProductId = $"{productId}-{ID++:D3}";
            Name = name;
        }

        public Product(string productId, string name, double price, int quantity) : this(productId, name) 
        {
            Price = price;
            Quantity = quantity;
        }

        public void Deconstruct(out string productId, out string name, out double price, out int quantity)
        {
            productId = this.productId;
            name = this.name;
            price = this.price;
            quantity = this.quantity;
        }

        public void ProductArrived(int quantityArrived)
        {
            if (quantityArrived > 0) 
            {
                this.quantity += quantityArrived;
                Console.WriteLine($"Название:{name}\nИНФО: ПОСТУПЛЕНИЕ ТОВАРА\nТекущее количество товара на складе: {quantity}\n");
            }
            else
            {
                Console.WriteLine($"Название:{name}\nИНФО: ПОСТУПЛЕНИЕ ТОВАРА\nОШИБКА: Количество товара не может быть отрицательным!\n");
            }         
        }

        public void ProductSold(int quantitySold)
        {
            if (quantitySold <= Quantity)
            {
                this.quantity -= quantitySold;
                Console.WriteLine($"Название:{name}\nИНФО: ТОВАР РАСПРОДАН\n");
            }
            else Console.WriteLine("Нет такого количества товара");
            
        }

        public void ProductWrittenOff()
        {
            Quantity = 0;
            Console.WriteLine($"Название:{name}\nИНФО: ТОВАР СПИСАН\n");
        }

        public void ProductOverpriced(double newPrice)
        {
            if (newPrice < 0)
            {
                Console.WriteLine($"Название:{name}\nИНФО: ИЗМЕНЕНИЕ ЦЕНЫ\nОШИБКА: Цена товара не может быть отрицательной!\n");
            }
            else
            {
                Price = newPrice;
                Console.WriteLine($"Название:{name}\nИНФО: ИЗМЕНЕНИЕ ЦЕНЫ\nТекущая цена: {price} рублей\n");
            }           
        }

        public void PrintProductInfo()
        {
            Console.WriteLine($"ID: {productId}\nНаименование: {name}\nСтоимость: {price} рублей\nКоличество: {quantity}\n");
        }

        public static void PrintTotalQuantityOfProducts()
        {
            Console.WriteLine($"Общее количество товара на складе: {ID - 1}");
        }
    }
}
