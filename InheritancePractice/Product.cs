using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
	internal abstract class Product
	{
		public abstract string Name { get; set; }
        double price;
		int quantity;

		public Product() { }

		public Product(string name, double price, int quantity)
		{
			Name = name;
			this.price = price;
			this.quantity = quantity;
		}

		public override string ToString()
		{
			return $"Название: {Name} Цена: {price} Количество: {quantity}";
		}

		public override int GetHashCode()
		{
			return Name.Length + (int)price;
		}

		public override bool Equals(object obj)
		{
			if (obj is Product)
			{
				return ((Product)obj).Name == this.Name;
			}

			return false;
		}
	}
}
