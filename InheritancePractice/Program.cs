using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Product[] products =
			{
				new HouseholdChemicals("Чистодом", 120, 12, "Для зеркал"),
				new Grocery("Кефир", 55, 21, false),
				new Drinks("Лимонад", 67, 5, false),
			};

			foreach (Product product in products)
			{
                Console.WriteLine(product);
                Console.WriteLine(product.GetHashCode());
			}

			Grocery p1 = new Grocery("Кефир", 55, 21, false);
			Drinks p2 = new Drinks("Кефир", 55, 21, false);

			Console.WriteLine(p1.Equals(p2));

			Console.ReadKey();
		}
	}
}
