using System;
using System.Collections.Generic;

namespace StructPractice
{
    struct Triangle
    {
        public double x;
        public double y;
        public double z;

        public Triangle(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool IsExist() => x < (y + z) && y < (z + x) && z < (x + y);

        public (double a, double b, double c) GetCorners()
        {
            if (IsExist())
            {
                double doubleX = Math.Pow(x, 2);
                double doubleY = Math.Pow(y, 2);
                double doubleZ = Math.Pow(z, 2);

                double a = Math.Acos((doubleY + doubleZ - doubleX) / (2 * y * z)) * 180 / Math.PI;
                double b = Math.Acos((doubleX + doubleZ - doubleY) / (2 * x * z)) * 180 / Math.PI;
                double c = Math.Acos((doubleX + doubleY - doubleZ) / (2 * x * y)) * 180 / Math.PI;

                return (a, b, c);
            } 

            return (0, 0, 0);
        }

        public double GetArea()
        {
            if (IsExist())
            {
                double p = (x + y + z) / 2;
                return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            }

            return 0;
        }

    }

    struct EvenNumberGenerator
    {
        public int GetEvenNumber() 
        { 
            int number = new Random().Next();

            return number % 2 == 0 ? number : number + 1;
        } 
    }

    struct OddNumberGenerator
    {
        public int GetOddNumber()
        {
            int number = new Random().Next();

            return number % 2 != 0 ? number : number + 1;
        }
    }

    struct JustNumberGenerator
    {
        public int GetJustNumber()
        {
            int number = new Random().Next(1, 1000);

            for(int i = number; ;i++)
            {
                bool isJust = true;
                for(int j = 2; j < Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isJust = false;
                        break;
                    }
                }
                if (isJust) return i;
            }
        }
    }

    struct FibonachchiNumberGenerator
    {
        public int GetFibonachchiNumber()
        {
            int number = new Random().Next(1, 1000);

            for (int i = number; ; i++)
            {
                if (Math.Sqrt(5 * Math.Pow(i, 2) + 4) % 1 == 0 ||
                    Math.Sqrt(5 * Math.Pow(i, 2) - 4) % 1 == 0)
                    return i;
            }
        }
    }

    struct Employee 
    {
        public string firstName;
        public string lastName;
        public string surname;
        public DateTime birthday;
        public int skillLevel;
        public string position;
        public Gender gender;
        public enum Gender
        {
            Женский,
            Мужской
        }
        public Employee(string firstName, string lastName, string surname, DateTime birthday, int skillLevel, string position, Gender gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.surname = surname;
            this.birthday = birthday;
            this.skillLevel = skillLevel;
            this.position = position;
            this.gender = gender;
        }

        public int GetSalary() => 50000 + 5000 * skillLevel;
    }

    struct Text
    {
        public string text;

        public Text(string text) => this.text = text;

        string[] GetSentences() => text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        public string[] GetWords()
        {
            List<String> words = new List<string>();
            foreach (string sentence in GetSentences())
            {
                words.AddRange(sentence.Trim().Split(' '));
            }

            return words.ToArray();
        }

        public int GetSentencesAmount() => GetSentences().Length;

        public int GetWordsAmount() => text.Split(' ').Length;

        public int GetCharsAmountWithSpaces() => text.Length;

        public int GetCharsAmountWithoutSpaces() => text.Replace(" ", "").Length;

        public double GetAverageLengthOfWord()
        {
            double wordsCharsAmount = 0;
            string[] words = GetWords();

            foreach (string word in words)
            {
                wordsCharsAmount += word.Length;
            }

            return wordsCharsAmount / words.Length;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle(5, 7, 8);
            Console.WriteLine("Треугольник (5, 7, 8) существует: " + myTriangle.IsExist());
            Console.WriteLine("Площадь треугольника: " + myTriangle.GetArea());
            Console.WriteLine("Углы треугольника: " + myTriangle.GetCorners());

            Triangle notExistsTriangle = new Triangle(100, 2, 5);
            Console.WriteLine("Треугольник (100, 2, 5) существует: " + notExistsTriangle.IsExist());

            EvenNumberGenerator evenGenerator = new EvenNumberGenerator(); // this is a problem
            Console.WriteLine("Чётное число: " + evenGenerator.GetEvenNumber());

            OddNumberGenerator oddGenerator = new OddNumberGenerator();
            Console.WriteLine("Нечётное число: " + oddGenerator.GetOddNumber()); 

            JustNumberGenerator justGenerator = new JustNumberGenerator();
            Console.WriteLine("Простое число: " + justGenerator.GetJustNumber());

            FibonachchiNumberGenerator fib = new FibonachchiNumberGenerator();
            Console.WriteLine("Число Фибоначчи: " + fib.GetFibonachchiNumber());

            Employee employee = new Employee();
            employee.skillLevel = 12;
            Console.WriteLine("Зарплата работника: " + employee.GetSalary());
            

            Text text = new Text("В лесу родилась Ёлочка.");
            Console.WriteLine("Текст: " + text.text);
            Console.WriteLine("Количество предложений в тексте: " + text.GetSentencesAmount());
            Console.WriteLine("Количество слов в тексте: " + text.GetWordsAmount());
            Console.WriteLine("Количество символов в тексте с пробелами: " + text.GetCharsAmountWithSpaces());
            Console.WriteLine("Количество символов в тексте без пробелов: " + text.GetCharsAmountWithoutSpaces());
            Console.WriteLine("Средняя длина слова в тексте: " + text.GetAverageLengthOfWord());

            Console.ReadKey();
        }
    }
}
