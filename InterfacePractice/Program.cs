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

            Park park2 = (Park)park.Clone();

            park2.Transports[0] = new PassengerCar("My car", "00000", 120);

            Console.WriteLine(park.Transports[0]);

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");

            IWorker[] workers =
            {
                new TeamLeader(),
                new Worker()
            };

            Team team = new Team(workers);

            IPart[] project =
            {
                new Basement(),
                new Wall(),
                new Wall(), 
                new Wall(),
                new Wall(),
                new Door(),
                new Window(),
                new Window(),
                new Window(),
                new Window(),
                new Roof()
            };

            House house = new House(project);

            Console.WriteLine("_____________________СТРОЙКА______________________\n\n");

            for (int i = 0; i <= project.Length; i++)
            {
                foreach (IWorker worker in team)
                {
                    worker.Work(house);
                }
            }

            Console.WriteLine("\n_______________ДОМ ГОТОВ!_____________\n");

            Console.WriteLine("░░░░░▄▄▄▄▄░░░░▄██▄░░░░░░░░░░░░░\r\n░░░░░▀████░▄███▀▀██▄▄░░░░░░░░░░\r\n░░░░░░███████▀░▄▄░▀███▄░░░░░░░░\r\n░░░░░░█████▀░▄████▄░▀███▄░░░░░░\r\n░░░░▄███▀░░▄███▀▀███▄░▀███▄▄░░░\r\n░░▄███▀░▄▄████░░░░████▄░░▀███▄░\r\n▄███▀░▄████████▄▄███████▄▄░▀██▄\r\n▀▀░░▄██████████████████████░░▀▀\r\n░░░░████▀▀▀▀▀▀▀███▀▀▀▀▀▀▀██░░░░\r\n░░░░████░██░██░███░██░██░██░░░░\r\n░░░░████░▄▄░▄▄░███░██░██░██░░░░\r\n░░░░████░▀▀░▀▀░███▄▄▄▄▄▄▄██░░░░\r\n░░░░████░██░██░████████████░░░░\r\n░░░▄████▄▄▄▄▄▄▄████████████▄░░░\r\n░░░█████████████████████████░░░\r\n░░░█████████████████████████░░░");
        }
    }
}
