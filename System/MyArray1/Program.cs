using System;

class MyClass
{
    static void Main()
    {
        var rand = new Random();
        int[] array = new int[rand.Next(4, 20)];

        Console.Write("Начальный массив: ");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 100);
            Console.Write(array[i] + " ");
        }

        Console.Write("\nМассив, отсортированный по возрастанию: ");

        SortAsc(array);

        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.Write("\nМассив, отсортированный по убыванию: ");

        SortDesc(array);

        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine($"\nМаксимальный элемент массива: {Max(array)}");
        Console.WriteLine($"Минимальный элемент массива: {Min(array)}");
        Console.WriteLine($"Сумма элементов массива: {Sum(array)}");

    }

    static int Sum(int[] array)
    {
        int sum = 0;

        foreach (int i in array) sum += i;

        return sum;
    }

    static int Min(int[] array)
    {
        int min = array[0];

        foreach (int i in array)
        {
            if (i < min) min = i;
        }

        return min;
    }

    static int Max(int[] array)
    {
        int max = array[0];

        foreach (int i in array)
        {
            if (i > max) max = i;
        }

        return max;
    }

    static void SortAsc(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[i])
                {
                    int el = array[i];
                    array[i] = array[j];
                    array[j] = el;
                }              
            }
        }
    }

    static void SortDesc(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > array[i])
                {
                    int el = array[i];
                    array[i] = array[j];
                    array[j] = el;
                }
            }
        }
    }
}




