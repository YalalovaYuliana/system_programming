using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public static class MyLibArray
    {
        static Random random = new Random();

        public static void FillArray(int[] array, int start, int end)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(start, end);
            }
        }

        public static void FillArray(int[][] array, int start, int end)
        {
            for (int i = 0; i < array.Length; i++)
            {
                FillArray(array[i], start, end);
            }
        }

        public static void FillArray(double[] array, int start, int end)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(start, end);
            }
        }

        public static void FillArray(double[][] array, int start, int end)
        {
            for (int i = 0; i < array.Length; i++)
            {
                FillArray(array[i], start, end);
            }
        }

        public static void FillArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble();
            }
        }

        public static void FillArray(double[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                FillArray(array[i]);
            }
        }

        public static double SumElements(double[] array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static double SumElements(double[][] array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    sum += array[i][j];
            }

            return sum;
        }

        public static int SumElements(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int SumElements(int[][] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    sum += array[i][j];
            }

            return sum;
        }

        public static double MultipleElements(double[] array)
        {
            double multiple = 1;

            for (int i = 0; i < array.Length; i++)
            {
                multiple *= array[i];
            }

            return multiple;
        }

        public static double MultipleElements(double[][] array)
        {
            double multiple = 1;

            for (int i = 0; i < array.Length; i++)
            {
                multiple *= MultipleElements(array[i]);
            }

            return multiple;
        }

        public static long MultipleElements(int[] array)
        {
            long multiple = 1;

            for (int i = 0; i < array.Length; i++)
            {
                multiple *= array[i];
            }

            return multiple;
        }

        public static long MultipleElements(int[][] array)
        {
            long multiple = 1;

            for (int i = 0; i < array.Length; i++)
            {
                multiple *= MultipleElements(array[i]);
            }

            return multiple;
        }

        public static (double maxElement, int x) GetMaxElement(double[] array)
        {
            double maxElement = Double.MinValue;
            int x = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    x = i;
                }
            }

            return (maxElement, x);
        }

        public static (double maxElement, int x, int y) GetMaxElement(double[][] array)
        {
            double maxElement = Double.MinValue;
            int x = 0;
            int y = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > maxElement)
                    {
                        maxElement = array[i][j];
                        x = i;
                        y = j;
                    }
                }
            }

            return (maxElement, x, y);
        }

        public static (int maxElement, int x) GetMaxElement(int[] array)
        {
            int maxElement = Int32.MinValue;
            int x = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    x = i;
                }
            }

            return (maxElement, x);
        }

        public static (int maxElement, int x, int y) GetMaxElement(int[][] array)
        {
            int maxElement = Int32.MinValue;
            int x = 0;
            int y = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > maxElement)
                    {
                        maxElement = array[i][j];
                        x = i;
                        y = j;
                    }
                }
            }

            return (maxElement, x, y);
        }

        public static (string maxElement, int x) GetMaxElement(string[] array)
        {
            string maxElement = array[0];
            int x = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].Length > maxElement.Length)
                {
                    maxElement = array[i];
                    x = i;
                }
            }

            return (maxElement, x);
        }

        public static (string maxElement, int x, int y) GetMaxElement(string[][] array)
        {
            string maxElement = array[0][0];
            int x = 0;
            int y = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j].Length > maxElement.Length)
                    {
                        maxElement = array[i][j];
                        x = i;
                        y = j;
                    }
                }
            }

            return (maxElement, x, y);
        }

        public static (double minElement, int x) GetMinElement(double[] array)
        {
            double minElement = Double.MaxValue;
            int x = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                    x = i;
                }
            }

            return (minElement, x);
        }

        public static (double minElement, int x, int y) GetMinElement(double[][] array)
        {
            double minElement = Double.MaxValue;
            int x = 0;
            int y = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] < minElement)
                    {
                        minElement = array[i][j];
                        x = i;
                        y = j;
                    }
                }
            }

            return (minElement, x, y);
        }

        public static (int minElement, int x) GetMinElement(int[] array)
        {
            int minElement = Int32.MaxValue;
            int x = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                    x = i;
                }
            }

            return (minElement, x);
        }

        public static (int minElement, int x, int y) GetMinElement(int[][] array)
        {
            int minElement = Int32.MaxValue;
            int x = 0;
            int y = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] < minElement)
                    {
                        minElement = array[i][j];
                        x = i;
                        y = j;
                    }
                }
            }

            return (minElement, x, y);
        }

        public static (string minElement, int x) GetMinElement(string[] array)
        {
            string minElement = array[0];
            int x = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].Length < minElement.Length)
                {
                    minElement = array[i];
                    x = i;
                }
            }

            return (minElement, x);
        }

        public static (string minElement, int x, int y) GetMinElement(string[][] array)
        {
            string minElement = array[0][0];
            int x = 0;
            int y = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j].Length < minElement.Length)
                    {
                        minElement = array[i][j];
                        x = i;
                        y = j;
                    }
                }
            }

            return (minElement, x, y);
        }

        public static string GetStringFormatArray(double[] array)
        {
            StringBuilder strArray = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                strArray.Append(array[i] + " ");
            }

            return strArray.ToString();
        }


        public static string GetStringFormatArray(double[][] array)
        {
            StringBuilder strArray = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    strArray.Append(array[i][j] + " ");
                }

                strArray.Append("\n");

            }

            return strArray.ToString();
        }

        public static string GetStringFormatArray(int[] array)
        {
            StringBuilder strArray = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                strArray.Append(array[i] + " ");
            }

            return strArray.ToString();
        }


        public static string GetStringFormatArray(int[][] array)
        {
            StringBuilder strArray = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    strArray.Append(array[i][j] + " ");
                }

                strArray.Append("\n");

            }

            return strArray.ToString();
        }

        public static string GetStringFormatArray(string[] array)
        {
            StringBuilder strArray = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                strArray.Append(array[i] + " ");
            }

            return strArray.ToString();
        }


        public static string GetStringFormatArray(string[][] array)
        {
            StringBuilder strArray = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    strArray.Append(array[i][j] + " ");
                }

                strArray.Append("\n");

            }

            return strArray.ToString();
        }

        public static void SortInAsc(string[] array) => Array.Sort(array);

        public static void SortInDesc(string[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        public static (int[] evenNumbers, int[] oddNumbers) GetEvenOddNumberArrays(int[] array)
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            foreach (int i in array)
            {
                if (i % 2 == 0)
                    evenNumbers.Add(i);
                else
                    oddNumbers.Add(i);
            }

            return (evenNumbers.ToArray(), oddNumbers.ToArray());
        }
    }
}
