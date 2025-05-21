using System;
using static system_programming.Residence;

namespace system_programming
{
    class MyClass
    {
        public readonly int var = 10;
        public readonly int[] myArr = { 1, 2, 3 };
    }

    public class Residence
    {
        public enum ResidenceType
        {
            House = 1_000_000,
            Flat = 100_000,
            Bungalow = 10_000,
            Apartment = 100_000
        }

        public static int contractAmount = 0;
        private int contractID;
        private ResidenceType type;
        private int numberOfBedrooms;
        private bool hasGarage;
        private bool hasGarden;

        public void Deconstruct(out ResidenceType type, out int numberOfBedrooms, out bool hasGarage, out bool hasGarden)
        {
            type = this.type;
            numberOfBedrooms = this.numberOfBedrooms;
            hasGarage = this.hasGarage; 
            hasGarden = this.hasGarden;
        }

        public Residence(ResidenceType type, int numberOfBedrooms, bool hasGarage)
        {
            contractID = ++contractAmount;
            Type = type;
            NumberOfBedrooms = numberOfBedrooms;
            HasGarage = hasGarage;
        }
        public Residence(ResidenceType type, int numberOfBedrooms, bool hasGarage, bool hasGarden) : this(type, numberOfBedrooms, hasGarage)
        {
            HasGarden = hasGarden;
        }

        public ResidenceType Type
        {
            get => type;
            set => type = value;
        }

        public int NumberOfBedrooms
        {
            get => numberOfBedrooms;
            set => numberOfBedrooms = value >= 0 ? value : 0;
        }

        public bool HasGarage
        {
            get => hasGarage;
            set => hasGarage = value;
        }

        public bool HasGarden
        {
            get => hasGarden;
            set => hasGarden = value;
        }

        public double CalculateBuildingCost()
        {
            double cost = (int)type;

            double additionalCostToNumberOfBedrooms = 1.1;
            double additionalCostIfHasGarden = 1.2;
            double additionalCostIfHasGarage = 1.3;

            if (numberOfBedrooms > 3) cost *= additionalCostToNumberOfBedrooms;

            if (hasGarage) cost *= additionalCostIfHasGarage;

            if (hasGarden) cost *= additionalCostIfHasGarden;

            return cost;
        }

        public double CalculateSalePrice()
        {
            return CalculateBuildingCost() * 1.6;
        }

        public void Print()
        {
            Console.WriteLine($"{contractID}. {type}\nCost: {CalculateSalePrice()}$\nNumber of bedrooms: {numberOfBedrooms}\nHas garage: {(hasGarage ? "Yes" : "No")}\nHas garden: {(hasGarden ? "Yes" : "No")}");
        }
    }

    class ClassArgs
    {
        public static double Average(params int[] a)
        {
            if (a.Length == 0) throw new Exception("Недостаточно аргументов");
            double sum = 0;
            foreach (int el in a) sum += el;
            return sum / a.Length;
        }
    }

    class Student
    {
        private int studentID = 0;
        public static int studentAmount;
        private string firstName = "John";
        private string lastName = "Doe";
        private int age;

        public void Deconstruct(out string firstName, out string lastName, out int age) 
        {
            firstName = this.firstName;
            lastName = this.lastName;
            age = this.age;
        }

        public int Age
        {
            get => age;
            set => age = value > 15 && value < 70 ? value : 30;
        }

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

        public Student(string firstName, string lastName, int age) : this(firstName)
        {
            LastName = lastName;
            Age = age;
        }

        public Student(string firstName)
        {
            studentID = ++studentAmount;
            FirstName = firstName;
        }

        public void Print()
        {
            Console.WriteLine($"{studentID} {firstName} {lastName} {age}");
        }
    }

    class ClientBank
    {
        private double _currBalance;
        private static double _bonus;

        public double CurrBalance
        {
            get => _currBalance; 
            set => _currBalance = value; 
        }

        public void Deconstruct(out double bonus) => bonus = _bonus;

        public ClientBank(double currBalance) => CurrBalance = currBalance;

        public static void SetBonus(double newRate) => _bonus = newRate;
        public static double GetBonus(double newRate) => _bonus;

        public double GetPercentes(double summa)
        {
            if ((_currBalance - summa) > 0)
            {
                double percent = summa * _bonus;
                _currBalance -= percent;
                return percent;
            }

            return -1;
        }

    }

    class Car
    {
        private static int maxSpeed;
        private string _driverName;
        private int _currSpeed;

        public static int MaxSpeed
        {
            get => maxSpeed;
            set => maxSpeed = value > 15 && value < 500 ? value : 200;
        }

        public string DriverName
        {
            get => _driverName;
            set => _driverName = value;
        }

        public int CurrSpeed
        {
            get => _currSpeed;
            set => _currSpeed = value;
        }

        public void Deconstructor(out string driverName, out int currSpeed)
        {
            driverName = _driverName;
            currSpeed = _currSpeed;
        }

        public Car() : this("Нет водителя") { }
        public Car(string driverName) : this(driverName, 0) { }
        public Car(string driverName, int currSpeed)
        {
            DriverName = driverName;
            CurrSpeed = currSpeed;
        }

        public void PrintState() => Console.WriteLine($"{_driverName} едет со скоростью {_currSpeed} км/ч.");

        public void SpeedUp(int delta) => _currSpeed += delta;
 
    }

    class ClassA
    {
        public void MethodA(ClassB obj)
        {
            obj.MethodB(this);
        }
    }

    class ClassB
    {
        public void MethodB(ClassA obj)
        {
            Console.WriteLine("Work with class " + obj.GetType().Name);
        }
    }

    class Example
    {
        int _num;

        public void Deconstructor(out int num) => num = _num;

        public int Num
        {
            get => _num;
            set => _num = value > 0 ? value : 0;
        }

        public Example(int num)
        {
            Num = num;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine($"myClass var: {myClass.var}");

            PrintSeparator();

            Residence residence = new Residence(Residence.ResidenceType.Flat, 3, true);
            residence.Print();
            (ResidenceType type, int numberOfBedrooms, bool hasGarage, bool hasGarden) = residence;

            Residence residence2 = new Residence(Residence.ResidenceType.House, 6, true, true);
            residence2.Print();

            PrintSeparator();

            ClassArgs classArgs = new ClassArgs();
            Console.WriteLine($"Average (10, 11, 12) = {ClassArgs.Average(new int[] {10, 11, 12})}");

            PrintSeparator();

            Student student = new Student("Yuliana", "Yalalova", 18);
            student.Print();

            Student student2 = new Student("Mishka");
            student2.Print();

            PrintSeparator();

            ClassA classA = new ClassA();
            ClassB classB = new ClassB();
            classA.MethodA(classB);

            PrintSeparator();

            Car car = new Car("Yuliana", 14);
            car.SpeedUp(5);
            car.PrintState();

            PrintSeparator();

            ClientBank clientBank = new ClientBank(3000);
            ClientBank.SetBonus(10);
            Console.WriteLine("Percent: " + clientBank.GetPercentes(200));
        }

        public static void PrintSeparator()
        {
            Console.WriteLine("\n_________________________________________\n");
        }
    }
}
