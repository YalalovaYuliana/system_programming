using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{

    interface IWorker
    {
        void Work(House house);
    }

    class Worker : IWorker
    {
        public void Build(House house)
        {
            IPart notReadyPart = null;

            Console.WriteLine("\n____НА СТРОЙКЕ____\n");

            foreach (IPart part in house)
            {
                if (!part.IsReady)
                {
                    notReadyPart = part;
                    part.IsReady = true;
                    break;
                }
            }

            if (notReadyPart != null)
            {
                Console.WriteLine($"Строим {notReadyPart.Name}...");
            } else
            {
                Console.WriteLine("Отдыхаем :)");
            }   
        }
        public void Work(House house) 
        { 
            Build(house);
        }
    }

    class TeamLeader : IWorker
    {
        public void CreateReport(House house)
        {
            double readyAmount = 0;

            Console.WriteLine("\n____ОТЧЁТ____\n");

            foreach (IPart part in house)
            {
                if (part.IsReady)
                {
                    readyAmount++;
                }
                string readyText = part.IsReady ? "готово" : "не готово";
                Console.WriteLine($"{part.Name} - {readyText}");
            }
            Console.WriteLine($"\nГотово на {(100.0 / house.parts.Length * readyAmount):F2}%\n");
        }
        public void Work(House house)
        {
            CreateReport(house);
        }
    }
    class Team : IEnumerable
    {
        IWorker[] Workers {  get; set; }

        public Team(IWorker[] workers)
        {
            Workers = workers;
        }

        public IEnumerator GetEnumerator()
        {
            return Workers.GetEnumerator();
        }
    }

    interface IPart
    {
        string Name { get; }
        TimeSpan BuildTime { get; }
        bool IsReady { get; set; }
    }

    class House : IEnumerable
    {
        public IPart[] parts {  get; set; }

        public House(IPart[] parts)
        {
            this.parts = parts;
        }

        public IEnumerator GetEnumerator()
        {
            return parts.GetEnumerator();
        }
    }

    class Basement : IPart
    {
        public string Name => "Подвал";
        public TimeSpan BuildTime => TimeSpan.FromDays(5);
        public bool IsReady { get; set; }
        
    }

    class Wall : IPart
    {
        public string Name => "Стена";
        public TimeSpan BuildTime => TimeSpan.FromDays(6);
        public bool IsReady { get; set; }
    }

    class Door : IPart
    {
        public string Name => "Дверь";
        public TimeSpan BuildTime => TimeSpan.FromDays(1);
        public bool IsReady { get; set; }
    }

    class Window : IPart
    {
        public string Name => "Окно";
        public TimeSpan BuildTime => TimeSpan.FromDays(1);
        public bool IsReady { get; set; }
    }

    class Roof : IPart
    {
        public string Name => "Крыша";
        public TimeSpan BuildTime => TimeSpan.FromDays(3);
        public bool IsReady { get; set; }
    }
}
