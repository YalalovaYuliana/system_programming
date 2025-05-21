using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadOperationLecture
{
    internal class Program
    {
        static void MethodTime(int hours, int minutes = 0)
        {
            Console.WriteLine($"Time: {hours} hours {minutes} minutes");
        }

        static void Main(string[] args)
        {

            Salary salary = new Salary(99);
            Salary newSalary = salary + 10;
            Console.WriteLine($"Зарплата старая: {salary.Amount} Зарплата новая: {newSalary.Amount}");

            Console.WriteLine("\n____________________________________________\n");

            Point point = new Point(10, 10);
            Point point2 = new Point(10, 10);
            Point point3 = new Point(20, 20);
            Console.WriteLine(++point); // 11 11
            Console.WriteLine(point--); // 10 10
            Console.WriteLine(-point); // -10 -10
            Console.WriteLine(point); // 10 10
            Console.WriteLine(point == point2); // true
            Console.WriteLine(point != point3); // true
            Console.WriteLine(point == point3); // false
            Console.WriteLine(point < point3); // true
            Console.WriteLine(point3 > point2); // true

            Console.WriteLine("\n____________________________________________\n");

            CPoint cp1 = new CPoint { X = 10, Y = 10 };
            CPoint cp2 = new CPoint { X = 10, Y = 10 };
            CPoint cp3 = cp1;

            Console.WriteLine(ReferenceEquals(cp1, cp2)); // false
            Console.WriteLine(ReferenceEquals(cp1, cp3)); // true

            Console.WriteLine(cp1.Equals(cp2)); // false
            Console.WriteLine(cp1.Equals(cp3)); // true

            Console.WriteLine("\n____________________________________________\n");

            SPoint sPoint = new SPoint { X = 10, Y = 10 };
            SPoint sPoint2 = new SPoint { X = 10, Y = 10 };

            Console.WriteLine(ReferenceEquals(sPoint, sPoint)); // false
            Console.WriteLine(sPoint.Equals(sPoint2)); // true


            Console.WriteLine("\n____________________________________________\n");

            Point p1 = new Point { X = 2, Y = 3 };
            Point p2 = new Point { X = 3, Y = 1 };
            Vector v1 = new Vector(p1, p2);
            Vector v2 = new Vector { X = 2, Y = 3 };

            Console.WriteLine($"\tВектора\n{v1}\n{v2}");
            Console.WriteLine("Сложение " + (v1 + v2));
            Console.WriteLine("Разность " + (v1 - v2));
            Console.WriteLine("Умножение " + (v1 * 2));

            Console.WriteLine("\n____________________________________________\n");

            Hour hour = new Hour(12);
            MethodTime(hour);

            int num = 21;
            MethodTime((Hour)num);

            Hour h1 = new Hour(40);
            Hour h2 = new Hour(50);
            Hour h3 = h1 + h2;
            Console.WriteLine($"{h1} {h2} {h3}");

            Console.WriteLine("\n____________________________________________\n");

            Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };
            Square square = new Square { Length = 7 };
            Rectangle rectSquare = square;
            Console.WriteLine($"implicit square ({square}) to rectangle ({rectSquare})");
            rectSquare.Draw();

            Square squareRect = (Square)rectangle;
			Console.WriteLine($"\nexplicit rectangle ({rectangle}) to rectangle ({squareRect})");
			squareRect.Draw();

            Square squareInt = 12;
            int number = (int)square;

			Console.ReadKey();

        }
    }
}
