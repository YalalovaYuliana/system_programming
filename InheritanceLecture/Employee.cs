using System;

namespace InheritanceLecture
{
    internal class Employee : Human
    {
        decimal salary;

        public decimal Salary { get => salary; set => salary = value > 0 ?  value : 0; }

        public Employee() { }

        public Employee(string name, string surname, DateTime birthday, decimal salary) : base(name, surname, birthday)
        {
            Salary = salary;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Зарплата: {salary}");
        }
		public new void Say() // скрывает метод в классе родителе
		{
			Console.WriteLine("Я работник");
		}

	}
}
