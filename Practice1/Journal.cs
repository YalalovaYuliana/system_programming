using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Journal
    {
        string name;
        int yearFounded;
        string description;
        string phone;
        string email;
        int employeeAmount = 0;

        public static Journal operator +(Journal a, int n)
        {
            Journal newJournal = (Journal)a.MemberwiseClone();
            newJournal.employeeAmount += n;
            return newJournal;
        }

        public static Journal operator +(int n, Journal a) => a + n;
        public static Journal operator +(Journal a, Journal b) => a + b.employeeAmount;

        public static Journal operator -(Journal a, int n)
        {
            Journal newJournal = (Journal)a.MemberwiseClone();
            newJournal.employeeAmount -= n;
            return newJournal;
        }

        public static Journal operator -(int n, Journal a) => a - n;
        public static Journal operator -(Journal a, Journal b) => a - b.employeeAmount;

        public override bool Equals(object obj)
        {
            if (obj is Journal) 
            {
                return employeeAmount == (obj as Journal).employeeAmount;
            }
            return false;
        }

        public static bool operator ==(Journal a, Journal b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Journal a, Journal b)
        {
            return !a.Equals(b);
        }

        public static bool operator >(Journal a, Journal b)
        {
            return a.employeeAmount > b.employeeAmount;
        }
        public static bool operator <(Journal a, Journal b)
        {
            return !(a > b);
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int YearFounded
        {
            get => yearFounded;
            set => yearFounded = value >= 1663 ? value : 1663;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = Regex.IsMatch(value, @"^\d{11}$") ? value : "";
        }

        public string Email
        {
            get => email;
            set => email = Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") ? value : "";
        }

        public Journal(string name, int yearFounded, string description)
        {
            Name = name;
            YearFounded = yearFounded;
            Description = description;
        }

        public Journal(string name, int yearFounded, string description, string contactPhone, string contactEmail, int employeeAmount) : this(name, yearFounded, description)
        {
            Phone = contactPhone;
            Email = contactEmail;
            this.employeeAmount = employeeAmount;
        }

        public void Print()
        {
            Console.WriteLine($"Название журнала: {Name}\n" 
                            + $"Год основания: {YearFounded}\n"
                            + $"Описание: {Description}\n"
                            + $"Контактный телефон: {Phone}\n"
                            + $"Контактный e-mail: {Email}\n"
                            + $"Количество сотрудников: {employeeAmount}");
        }
    }
}
