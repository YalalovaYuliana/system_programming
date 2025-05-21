using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
	internal class Grocery : Product
	{
		public override string Name { get; set; }
		bool isVegeterian;
		public Grocery() { }

		public Grocery(string name, double price, int quantity, bool isVegeterian) : base(name, price, quantity)
		{
			this.isVegeterian = isVegeterian;
		}

		public override string ToString()
		{
			return base.ToString() + $" Для вегетарианцев: {(isVegeterian ? "Да" : "Нет")}";
		}
	}
}
