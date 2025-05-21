using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritancePractice
{
	internal class HouseholdChemicals : Product
	{
		public override string Name { get; set; }
		string type;

		public HouseholdChemicals() { }

		public HouseholdChemicals(string name, double price, int quantity, string type) : base(name, price, quantity)
		{
			this.type = type;
		}

		public override string ToString()
		{
			return base.ToString() + $" Тип: {type}";
		}
	}
}
