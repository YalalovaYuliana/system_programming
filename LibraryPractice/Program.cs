using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyLib.MyLibText;
using static MyLib.MyLibArray;

namespace LibraryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "ро В лесу родилась Ёлочка! В лесу она росла.";
            Console.WriteLine(GetCharsAmountWithoutSpaces(text));
            Console.WriteLine(GetSpaceAmount(text));
            Console.WriteLine(GetLettersAmount(text));
            Console.WriteLine(GetVowelsAmount(text));
            Console.WriteLine(GetСonsonantsAmount(text));

            (int amount, int[] indexes) = GetOfOccurrencesAndIndexesPart(text, "ро");

            Console.WriteLine(amount);

            foreach (var item in indexes)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            (int amount2, int[] indexes2) = GetOfOccurrencesAndIndexesWhole(text, "ро");

            Console.WriteLine(amount2);


            Console.WriteLine("___________________________________");

            int[] intArray = new int[5] { 1, 2, 3, 4, 5};

            (int[] even, int[] odd) = GetEvenOddNumberArrays(intArray);

            foreach (var item in even)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in odd)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            string[] strArray = new string[5] { "ёж", "медведь", "лошадь", "жук", "котэ"};

            SortInAsc(strArray);

            foreach (var item in strArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            SortInDesc(strArray);

            foreach (var item in strArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
