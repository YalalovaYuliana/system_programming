Console.WriteLine("Введите длину линии: ");

if (int.TryParse(Console.ReadLine(), out int length))
{
    Console.WriteLine("Введите символ заполнитель: ");
    if (Char.TryParse(Console.ReadLine(), out char chr))
    {
        Console.WriteLine("Введите направление линии (Г - горизонтальная, В - вертикальная): ");

        switch (Console.ReadLine().ToUpper())
        {
            case "Г":
                for (int i = 0; i < length; i++) Console.Write(chr);
                break;
            case "В":
                for (int i = 0; i < length; i++) Console.WriteLine(chr);
                break;
            default:
                Console.WriteLine("Некорректный ввод направления!");
                break;
        }
    }
    else Console.WriteLine("Некорректный ввод символа!");
}
else Console.WriteLine("Некорректный ввод длины!");
