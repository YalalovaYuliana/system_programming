using System;

class MyClass
{
    static void Main()
    {
        var rand = new Random();
        int[,] array = new int[rand.Next(2, 6), rand.Next(2, 6)];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rand.Next(1, 100);
            }
        }

        Console.WriteLine("Начальный массив: ");     

        SumRowAndColumn(array);

        Console.WriteLine();

        Console.WriteLine("Массив, отсортированный по возрастанию: ");

        SortAsc(array);

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Массив, отсортированный по убыванию: ");

        SortDesc(array);

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nМаксимальный элемент массива: {Max(array)}");
        Console.WriteLine($"Минимальный элемент массива: {Min(array)}");
        Console.WriteLine($"Сумма элементов массива: {Sum(array)}");
    }

    static int Sum(int[,] array)
    {
        int sum = 0;

        foreach (int i in array) sum += i;

        return sum;
    }

    static void SumRowAndColumn(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
                sum += array[i, j];
            }
            Console.WriteLine("|" + sum);
        }

        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write("_______");
        }
        Console.WriteLine();

        for (int i = 0; i < array.GetLength(1); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                sum += array[j, i];
            }
            Console.Write(sum + "\t");
        }

        Console.WriteLine(" " + Sum(array));
    }

    static int Min(int[,] array)
    {
        int min = array[0, 0];

        foreach (int i in array)
        {
            if (i < min) min = i;
        }

        return min;
    }

    static int Max(int[,] array)
    {
        int max = array[0, 0];

        foreach (int i in array)
        {
            if (i > max) max = i;
        }

        return max;
    }

    static void SortAsc(int[,] array)
    {
        int arrayLenghtRow = array.GetLength(0);
        int arrayLenghtColumn = array.GetLength(1);

        for (int x = 0; x < arrayLenghtRow; x++)
        {
            for (int y = 0; y < arrayLenghtColumn; y++)
            {
                for (int i = 0; i < arrayLenghtRow; i++)
                {
                    for (int k = 0; k < arrayLenghtColumn; k++)
                    {
                        if (array[i, k] > array[x, y])
                        {
                            int el = array[x, y];
                            array[x, y] = array[i, k];
                            array[i, k] = el;
                            
                        }
                    }
                }
            }
        }
    }

    static void SortDesc(int[,] array)
    {
        int arrayLenghtRow = array.GetLength(0);
        int arrayLenghtColumn = array.GetLength(1);

        for (int x = 0; x < arrayLenghtRow; x++)
        {
            for (int y = 0; y < arrayLenghtColumn; y++)
            {
                for (int i = 0; i < arrayLenghtRow; i++)
                {
                    for (int k = 0; k < arrayLenghtColumn; k++)
                    {
                        if (array[i, k] < array[x, y])
                        {
                            int el = array[x, y];
                            array[x, y] = array[i, k];
                            array[i, k] = el;

                        }
                    }
                }
            }
        }
    }
}


