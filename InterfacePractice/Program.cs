using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport[] transports = new Transport[]
            {
                new Motorcycle("Harley-Davidson2", "C039FG", 210, true),
                new PassengerCar("Toyota Camry", "A123BC", 220),
                new Truck("Volvo FH16", "B456DE", 120, 20000),
                new Motorcycle("Harley-Davidson", "C789FG", 180, false),
                new PassengerCar("BMW X5", "D012HI", 240),
                new Truck("MAN TGX", "E345JK", 110, 25000)
            };

            Park park = new Park(transports);
            park.Sort();

            Console.WriteLine("\n__________________TRANSPORT PARK__________________\n");
            Console.WriteLine("|^^^^^^^^^^^\\||____\r\n|               |||\"\"'|\"\"\\__,_\r\n| _____________ l||__|__|__|)\r\n__|(@)@)\"\"\"\"\"\"\"**|(@)(@)**|(@)____\n\n");
            foreach (Transport transport in transports)
            {
                Console.WriteLine(transport);
                Console.WriteLine();
            }

            Console.WriteLine("_______Сортировка по максимальной грузоподъёмности_______\n".ToUpper());

            park.Sort(new LoadCapacityComparer());

            foreach (Transport transport in transports)
            {
                Console.WriteLine(transport);
                Console.WriteLine();
            }
        }
    }
}
