using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndeksatorLecture
{
	internal class Shop
	{
		Laptop[] LaptopArr {  get; set; }
		public int Length
		{
			get
			{
				return LaptopArr.Length;
			}

		}

		public Shop(int size)
		{
			LaptopArr = new Laptop[size];
		}
		public Shop(params Laptop[] LaptopArr) 
		{
			this.LaptopArr = LaptopArr;
		}

		public Laptop this[int index]
		{
			get
			{
				if (index >= 0 && index < LaptopArr.Length)
				{
					return LaptopArr[index];
				} else
				{
					throw new IndexOutOfRangeException();
				}
			}
			set
			{
				LaptopArr [index] = value;
			}
		}

		public Laptop this[string name]
		{
			get
			{
				if (Enum.IsDefined(typeof(Vendors), name) && FindByVendor(name) >= 0)
				{
					return LaptopArr[FindByVendor(name)];
				} 
				else
				{
					return new Laptop();
				}
			}
			set
			{
				if (Enum.IsDefined(typeof(Vendors), name) && FindByVendor(name) >= 0)
				{
					LaptopArr[FindByVendor(name)] = value;
				}
			}
		}

		public int FindByVendor(string vendor)
		{
			for (int i = 0; i < LaptopArr.Length; i++)
			{
				if (LaptopArr[i].Vendor == vendor)
					return i;
			}
			return -1;
		}

		public Laptop this[double price]
		{
			get
			{
				if (FindByPrice(price) >= 0)
				{
					return this[FindByPrice(price)];
				}
				throw new Exception("Not available cost");
			}
			set
			{
				if (FindByPrice(price) >= 0)
					this[FindByPrice(price)] = value;

			}
		}

		public int FindByPrice(double price)
		{
			for (int i = 0; i < LaptopArr.Length; i++)
			{
				if (LaptopArr[i].Price == price) return i;
			}
			return -1;
		}
	}

	enum Vendors { Samsung, Asus, LG }

	class Laptop
	{
		public string Vendor { get; set; }
		public int Price { get; set; }
		public override string ToString()
		{
			return $"Vendor: {Vendor}, Price: {Price}";
		}

	}
}
