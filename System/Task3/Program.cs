Console.Write("Введите два числа через пробел: ");

string[] numbers = Console.ReadLine().Split(" ");

bool isNumber1 = int.TryParse(numbers[0], out int a);
bool isNumber2 = int.TryParse(numbers[1], out int b);

if (isNumber1 && isNumber2 && a < b)
{
    for (int i = a; i <= b; i++)
    {
        for (int j = 0; j <= i; j++)
            Console.Write(i);
        Console.WriteLine();
    }
}
else Console.WriteLine("Некорректный ввод!");
