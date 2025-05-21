using System;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Yuliana", "Yalalova", "Arturovna", new DateTime(2006, 3, 30), "89004567788", "uliana@mail.ru");
            Console.WriteLine(employee1);

            Console.WriteLine();

            Employee employee2 = new Employee("Ivan", "Ivanov", "Ivanovich", DateTime.Now, "89056784488", "ivan$mail.ru", "HR manager", "smthng");
            Console.WriteLine(employee2);

            PrintSeparator();

            WebSite webSite1 = new WebSite("ranepa", "lms.ranepa.ru", "СДО", "192.168.1.1");
            webSite1.Print();

            Console.WriteLine();

            WebSite webSite2 = new WebSite("web-site", "web-site.com", "very intresting web-site", "192.168.1");
            webSite2.Print();

            PrintSeparator();

            Journal journal1 = new Journal("Modnayy journal", 1920, "very modnyy journal", "89004567893", "modnyy@email.com", 12);
            journal1.Print();

            Console.WriteLine();

            Journal journal2 = new Journal("Adventure journal", 2002, "very adventure journal", "890045678", "@email.com", 2);
            journal2.Print();

            Console.WriteLine();

            Journal journal3 = journal1 + journal2;
            journal3.Print();


            Console.WriteLine();

            Journal journal4 = journal2 - 1;
            journal4.Print();

            Console.WriteLine(journal1 > journal2);
            Console.WriteLine(journal1 == journal2);

            PrintSeparator();

            Publishing publishing = new Publishing();
            publishing.journals = new Journal[] { journal1, journal2 };
            publishing[1].Print();
            Console.WriteLine();
            publishing["Modnayy journal"].Print();
        }

        public static void PrintSeparator()
        {
            Console.WriteLine("\n_________________________________________\n");
        }
    }
}
