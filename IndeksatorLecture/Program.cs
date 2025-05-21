using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndeksatorLecture
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Shop laptops = new Shop(3);
			laptops[0] = new Laptop { Vendor = "Samsung", Price = 5200 };
			laptops[1] = new Laptop { Vendor = "Asus", Price = 4700 };
			laptops[2] = new Laptop { Vendor = "LG", Price = 4300 };
			for (int i = 0; i < laptops.Length; i++)
				Console.WriteLine(laptops[i]);

			try
			{
				for (int i = 0; i < laptops.Length; i++)
					Console.WriteLine(laptops[i]);

				Console.WriteLine($"Производитель Asus: {laptops["Asus"]}.");
				Console.WriteLine($"Производитель HP: {laptops["HP"]},");
				laptops["HP"] = new Laptop();
				Console.WriteLine($"Стоимость 4300: {laptops[4300.0]}.");
				Console.WriteLine($"Стоимость 10500: {laptops[10500.0]}.");
				laptops[10500.0] = new Laptop();
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}

            Console.WriteLine("\n-----------------------------\n");

			MultArray array = new MultArray(2, 3);

			for (int i = 0; i < array.Rows; i++)
			{
				for (int j = 0; j < array.Cols; j++)
				{
					array[i, j] = i + j;
					Console.Write($"{array[i, j]}");
				}
                Console.WriteLine();
			}

		}
	}
}
