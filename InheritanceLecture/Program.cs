using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {

			Employee[] employees =
			{
				new Manager("Manager", "Managerov", DateTime.Now, 200_000, "Первая", "Маркетинг"),
				new ManualWorker("Manual", "Worker", DateTime.Now, 500_000, 3, "Воркшоп"),
				new Scientist("Scientist", "Scientistov", DateTime.Now, 900_000, "Наука"),
				new Specialist("Specialist", "Specialistov", DateTime.Now, 100_000, "Вторая", "Технологии"),
			};

			foreach (Employee employee in employees)
			{
				employee.Print(); 

				if (employee is Manager)
				{
					((Manager)employee).Say();
				}
				else if (employee is ManualWorker)
				{
					((ManualWorker)employee).Say();
				}
				else if (employee is Scientist)
				{
					((Scientist)employee).Say();
				}
				else if (employee is Specialist)
				{
					((Specialist)employee).Say();
				}

				Console.WriteLine();
			}

			Console.ReadKey();


        }
    }

    class Manager : Employee
    {
        string grade;
        string fieldActivity;

		public Manager() { }

		public Manager(string name, string surname, DateTime birthday, decimal salary, string grade, string fieldActivity) : base(name, surname, birthday, salary)
		{
			this.grade = grade;
            this.fieldActivity = fieldActivity;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Степень: {grade}\nПоле деятельности: {fieldActivity}");
		}

		public new void Say() 
		{
			Console.WriteLine("Я менеджер");
		}
	}

	class ManualWorker : Employee
	{
		int rang;
		string workshop;

		public ManualWorker() { }

		public ManualWorker(string name, string surname, DateTime birthday, decimal salary, int rang, string workshop) : base(name, surname, birthday, salary)
		{
			this.rang = rang;
			this.workshop = workshop;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Ранг: {rang}\nМастерская: {workshop}");
		}

		public new void Say()
		{
			Console.WriteLine("Я мануальный работник");
		}
	}

	class Scientist : Employee
	{
		string scientificDirection;

		public Scientist() { }

		public Scientist(string name, string surname, DateTime birthday, decimal salary, string scientificDirection) : base(name, surname, birthday, salary)
		{
			this.scientificDirection = scientificDirection;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Научное направление: {scientificDirection}");
		}
		public new void Say()
		{
			Console.WriteLine("Я учёный");
		}

	}

	class Specialist : Employee
	{
		string qualification;
		string department;

		public Specialist() { }

		public Specialist(string name, string surname, DateTime birthday, decimal salary, string qualification,string department) : base(name, surname, birthday, salary)
		{
			this.qualification = qualification;
			this.department = department;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Квалификация: {qualification}\nОтдел: {department}");
		}

		public new void Say()
		{
			Console.WriteLine("Я специалист");
		}
	}
}
