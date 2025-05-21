class MyClass
{
    static void Main()
    {
        var rand = new Random();
        int[][] array = new int[rand.Next(3, 6)][];

        Console.WriteLine("Начальный массив: ");

        for (int i = 0; i < array.Length; i++)
        {
            int[] inArray = new int[rand.Next(3, 12)];

            for (int j = 0; j < inArray.Length; j++)
            {
                inArray[j] = rand.Next(1, 100);
            }

            array[i] = inArray;
        }

        SumRowAndColumn(array);
        Console.WriteLine();

        Console.WriteLine("Массив, отсортированный по возрастанию: ");

        SortAsc(array);

        for (int i = 0; i < array.Length; i++)
        {

            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + "\t");
            }

            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Массив, отсортированный по убыванию: ");

        SortDesc(array);

        for (int i = 0; i < array.Length; i++)
        {

            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + "\t");
            }

            Console.WriteLine();
        }

        Console.WriteLine($"\nМаксимальный элемент массива: {Max(array)}");
        Console.WriteLine($"Минимальный элемент массива: {Min(array)}");
        Console.WriteLine($"Сумма элементов массива: {Sum(array)}");
    }

    static void SumRowAndColumn(int[][] array)
    {
        int maxLength = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + "\t");
            }

            for (int j = 0; j < maxLength - array[i].Length; j++)
            {
                Console.Write("\t");
            }
            Console.WriteLine("|" + Sum(array[i]));

            if (array[i].Length > maxLength) maxLength = array[i].Length;
        }

        for (int i = 0; i <= maxLength; i++)
        {
            Console.Write("_______");
        }
        Console.WriteLine();

        for (int h = 0; h < maxLength; h++)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (h >= array[i].Length) continue;

                sum += array[i][h];                        
            }

            Console.Write(sum + "\t");
        }   

        Console.WriteLine(" " + Sum(array));
    }

    static int Sum(int[][] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            foreach (int el in array[i]) sum += el;
        }

        return sum;
    }

    static int Sum(int[] array)
    {
        int sum = 0;

        foreach (int i in array) sum += i;

        return sum;
    }

    static int Min(int[][] array)
    {
        int min = array[0][0];

        for (int i = 0; i < array.Length; i++)
        {
            foreach (int el in array[i])
            {
                if (el < min) min = el;
            }
        }

        return min;
    }

    static int Max(int[][] array)
    {
        int max = array[0][0];

        for (int i = 0; i < array.Length; i++)
        {
            foreach (int el in array[i])
            {
                if (el > max) max = el;
            }
        }

        return max;
    }

    static void SortAsc(int[][] array)
    {
        for (int x = 0; x < array.Length; x++)
        {
            for (int y = 0; y < array[x].Length; y++)
            {
                for (int x2 = 0; x2 < array.Length; x2++)
                {
                    for (int y2 = 0; y2 < array[x2].Length; y2++)
                    {
                        if (array[x][y] < array[x2][y2])
                        {
                            int el = array[x][y];
                            array[x][y] = array[x2][y2];
                            array[x2][y2] = el;

                        }
                    }
                }
            }
        }
    }

    static void SortDesc(int[][] array)
    {
        for (int x = 0; x < array.Length; x++)
        {
            for (int y = 0; y < array[x].Length; y++)
            {
                for (int x2 = 0; x2 < array.Length; x2++)
                {
                    for (int y2 = 0; y2 < array[x2].Length; y2++)
                    {
                        if (array[x][y] > array[x2][y2])
                        {
                            int el = array[x][y];
                            array[x][y] = array[x2][y2];
                            array[x2][y2] = el;

                        }
                    }
                }
            }
        }
    }
}



