using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
	internal class Drinks : Product
	{
		public override string Name { get; set; }
		bool isAdult;
		public Drinks() { }

		public Drinks(string name, double price, int quantity, bool isAdult) : base(name, price, quantity)
		{
			this.isAdult = isAdult;
		}

		public override string ToString()
		{
			return base.ToString() + $" Для взрослых: {(isAdult ? "Да" : "Нет")}";
		}
	}
}
