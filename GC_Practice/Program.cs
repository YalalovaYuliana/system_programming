using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GC_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiplay();   
            try
            {
                Pasport pasport = new Pasport();
                pasport.Number = "12345";
                pasport.Name = "Y";
                pasport.Name = "XYZ";
            } 
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            using(Pasport pasport = new Pasport())
            {
                pasport.Dispose();
            }
        }

        static void Multiplay()
        {
            string primer = Console.ReadLine();

            try
            {
                if (!Regex.IsMatch(primer, @"^\d+\*\d+(?:\*\d+)*$"))
                {
                    throw new Exception("Неверный ввод!");
                }

                string[] numbers = primer.Split('*');
                long result = 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    checked
                    {
                        result *= int.Parse(numbers[i]);
                    }
                }
                Console.WriteLine($"Результат умножения: {result}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнение!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
