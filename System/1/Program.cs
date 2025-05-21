Console.Write("Введите три числа через пробел: ");

string[] strNumbers = Console.ReadLine().Split(" ");
List<int> numbers = new List<int>();

foreach (var item in strNumbers)
{
    numbers.Add(Int32.Parse(item.ToString()));
}

numbers.Sort();

if ((numbers[2] - numbers[1]) == (numbers[1] - numbers[0])) Console.WriteLine("YES");
else Console.WriteLine("NO");