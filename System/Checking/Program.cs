while (true)
{
    Console.WriteLine("Выберите режим игры: 1 - Компьютер угадывает, 2 - Игрок угадывает, 3 - Выйти из игры");

    switch (Console.ReadLine())
    {
        case "1":
            ComputerMode();
            break;
        case "2":
            UserMode();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Некорректный выбор режима игры!");
            break;
    }
}

void ComputerMode()
{
    Console.WriteLine("Введите начало диапазона включительно:");
    int start = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите конец диапазона включительно:");
    int end = int.Parse(Console.ReadLine());
    int numberOfAttempts = (int)Math.Ceiling(Math.Log2(end - start));
    Console.WriteLine($"Мне потребуется до {numberOfAttempts} попыток на угадывание");

    for (int i = 0; i < numberOfAttempts; i++)
    {
        int guessNumber = (int)((end - start) / 2 + start);
        Console.WriteLine($"Вы загадали число {guessNumber}? (Д/Н)");

        if (Console.ReadLine().ToLower() == "д") break;
        else if (guessNumber == end || guessNumber == start)
        {
            Console.WriteLine("Вы пытаетесь меня обмануть!");
            break;
        }
        else
        {
            Console.WriteLine("Загаданное число больше или меньше? (Б/М)");

            if (Console.ReadLine().ToLower() == "б") start = guessNumber;
            else end = guessNumber;
        }
    }
}

void UserMode()
{
    Console.WriteLine("Введите начало диапазона включительно:");
    int start = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите конец диапазона включительно:");
    int end = int.Parse(Console.ReadLine());
    int numberOfAttempts = (int)Math.Ceiling(Math.Log2(end - start));
    Random random = new Random();
    int hiddenNumber = random.Next(start, end);
    Console.WriteLine($"Вам дано {numberOfAttempts} попыток на угадывание");

    bool isWin = false;

    for (int i = 0; i < numberOfAttempts; i++)
    {
        Console.WriteLine("Введите число:");
        int guessNumber = int.Parse(Console.ReadLine());

        if (guessNumber == hiddenNumber)
        {
            Console.WriteLine("Вы угадали!");
            isWin = true;
            break;
        }
        else
        {
            if (hiddenNumber < guessNumber) Console.WriteLine("Подсказка: Загаданное число меньше");
            else Console.WriteLine("Подсказка: Загаданное число больше");
        }
    }

    if (!isWin)
    {
        Console.WriteLine($"Вы проиграли... \nЗагаданное число: {hiddenNumber}");
    }
}
