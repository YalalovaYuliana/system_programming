using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice1
{
    internal class WebSite
    {
        string name;
        string path;
        string description;
        string ip;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Path
        {
            get => path;
            set => path = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string Ip
        {
            get => ip;
            set
            {
                string pattern = @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
                ip = Regex.IsMatch(value, pattern) ? value : "";
            }
        }

        public WebSite(string name, string path, string description)
        {
            Name = name;
            Path = path;
            Description = description;
        }

        public WebSite(string name, string path, string description, string ip) : this(name, path, description)
        {
            Ip = ip;
        }

        public void Print()
        {
            Console.WriteLine($"Название сайта: {Name}\n" +
                               $"Путь: {Path}\n" +
                               $"Описание: {Description}\n" +
                               $"IP-адрес: {Ip}"); 
        }

    }
}
