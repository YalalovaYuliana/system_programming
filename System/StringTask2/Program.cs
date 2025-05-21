Console.WriteLine("ПЛЮС/МИНУС КАЛЬКУЛЯТОР\n");
Console.Write("Введите арифметические выражение в формате (\"12 + 1\"): ");

string[] expression = Console.ReadLine().Split(' ');

if (expression.Length == 3 && int.TryParse(expression[0], out int firstNumber) && int.TryParse(expression[2], out int secondNumber))
{
    switch (expression[1])
    {
        case "+":
            Console.WriteLine("Ответ: " + (firstNumber + secondNumber));
            break;
        case "-":
            Console.WriteLine("Ответ: " + (firstNumber - secondNumber));
            break;
        default:
            Console.WriteLine("Недопустимая операция! Можно вводить только \"+\" или \"-\"");
            break;
    }
}
else Console.WriteLine("Пример введён неправильно!");
