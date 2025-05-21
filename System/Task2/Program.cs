Console.WriteLine("КАЛЬКУЛЯТОР");
Console.WriteLine("Пример ввода: \"2,25 + 2\"");
Console.WriteLine("Допустимые операции: +, -, *, /");

string[] numbers = Console.ReadLine().Split(" ");

bool isNumber1 = double.TryParse(numbers[0], out double n1);
bool isNumber2 = double.TryParse(numbers[2], out double n2);

if (isNumber1 && isNumber2)
{
    string operation = numbers[1];
    
    switch (operation) 
    {
        case "+":
            Console.WriteLine(n1 + n2);
            break;
        case "-":
            Console.WriteLine(n1 - n2);
            break;
        case "*":
            Console.WriteLine(n1 * n2);
            break;
        case "/":
            if (n2 == 0) Console.WriteLine("На ноль делить нельзя!");
            else Console.WriteLine(n1 / n2);
            break;
        default: 
            Console.WriteLine("Некорректная операция!");
            break;
    }
}
else Console.WriteLine("Некорректный ввод!");




