using System;
using System.Text.RegularExpressions;

namespace Practice1
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string surname;
        private DateTime dateOfBirth;
        private string phone;
        private string email;
        private string position;
        private string jobDescription;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = DateTime.Today.Year - value.Year >= 18 ? value : DateTime.Today.AddYears(-18);
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

        public string Position
        {
            get => position;
            set => position = value;
        }

        public string JobDescription
        {
            get => jobDescription;
            set => jobDescription = value;
        }

        public Employee(string firstName, string lastName, string surname, DateTime dateOfBirth, string phone, string email, string position, string jobDescription) : this(firstName, lastName, surname, dateOfBirth, phone, email)
        {
            Position = position;
            JobDescription = jobDescription;
        }

        public Employee(string firstName, string lastName, string surname, DateTime dateOfBirth, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"ФИО: {LastName} {FirstName} {Surname}\n" +
                   $"Дата рождения: {DateOfBirth.ToString("yyyy-MM-dd")}\n" +
                   $"Телефон: {Phone}\n" +
                   $"Почта: {Email}\n" +
                   $"Должность: {Position}\n" +
                   $"Описание работы: {JobDescription}";
        }
    }
}
