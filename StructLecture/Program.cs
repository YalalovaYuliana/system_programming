using System;

namespace StructLecture
{

    struct Currency
    {
        public string currencyCode;
        public string currencySymbol;
        public int fractionDigits;

        public Currency(string currencyCode, string currencySymbol)
        {
            this.currencyCode = currencyCode;
            this.currencySymbol = currencySymbol;
            
            this.fractionDigits = 2;
        }
    }

    struct Dimensions
    {
        public double Length;
        public double Width;

        public Dimensions(double length, double width)
        {
           
            Length = length;
            Width = width;
        }

        public void Print()
        {
            Console.WriteLine($"Длина {Length}, ширина {Width}.");
        }
    }

    struct Person
    {
        public string name;
        public int age;

        public Person(string name) : this(name, 1) { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");

        internal class Program
        {
            static void Main(string[] args)
            {
                Currency currency = new Currency();
                currency.currencyCode = "GBP";
                Console.WriteLine(currency.currencyCode);
                UpdateCurrency(ref currency);
                Console.WriteLine(currency.currencyCode);

                object o = currency;
                Currency? currency2 = null;

                currency2 = currency2 ?? new Currency();

                currency2 = (Currency)o;

                Dimensions d;
                d = new Dimensions();
                d.Print();
                d.Length += 2;
                d.Width += 2;
                d.Print();

                Dimensions d2 = new Dimensions(2.4, 5.5);
                d2.Print();

                Person bob = new Person();
                Person tom = new Person() { name = "Tom", age = 20 };
                //Person sam = tom with { name = "Sam" };
                bob.Print();
                tom.Print();

                Residence residence = new Residence(Residence.ResidenceType.House, 2, true);
                UpdateResidence(residence);
                Console.WriteLine(residence.NumberOfBedrooms);

                int? i = null;
                int j = 99;
                i = i ?? 5;
                i = i ?? 10;
                i = j;
                //j = i;


                dynamic dyn = new Residence(Residence.ResidenceType.Bungalow, 3, false);
                dyn = 1;
                Object obj = 1;
                dyn++;
                Console.WriteLine(dyn.GetType());
                Console.WriteLine(obj.GetType());

                dyn = "Yes";
                dyn.blablabla();
            }

            public static void UpdateCurrency(ref Currency currency)
            {
                currency.currencyCode = "EUR";
            }

            public static void UpdateResidence(Residence residence)
            {
                residence.NumberOfBedrooms = 3;
            }
        }
    }
}
