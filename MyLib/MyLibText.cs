using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MyLib
{
    public static class MyLibText
    {
        public static string[] GetSentences(string text) => text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        public static string[] GetWords(string text)
        {
            List<String> words = new List<string>();
            foreach (string sentence in GetSentences(text))
            {
                words.AddRange(sentence.Trim().Split(' '));
            }

            return words.ToArray();
        }

        public static int GetSentencesAmount(string text) => GetSentences(text).Length;
           
        public static int GetWordsAmount(string text) => text.Split(' ').Length;
  
        public static int GetCharsAmountWithSpaces(string text) => text.Length;
            
        public static int GetCharsAmountWithoutSpaces(string text) => text.Replace(" ", "").Length;

        public static double GetAverageLengthOfWord(string text)
        {
            double wordsCharsAmount = 0;
            string[] words = GetWords(text);

            foreach (string word in words)
            {
                wordsCharsAmount += word.Length;
            }

            return wordsCharsAmount / words.Length;
        }

        public static int GetSpaceAmount(string text) => GetWords(text).Length - 1;

        public static int GetLettersAmount(string text)
        {
            int letterAmount = 0;
            foreach (char letter in text)
            {
                if (Char.IsLetter(letter))
                    letterAmount++;
            }

            return letterAmount;
        }

        public static int GetVowelsAmount(string text)
        {
            string vowels = "ауоиэыяюеё";
            int vowelsAmount = 0;
            foreach (char letter in text)
            {
                if (vowels.Contains(Char.ToLower(letter)))
                    vowelsAmount++;
            }

            return vowelsAmount;
        }

        public static int GetСonsonantsAmount(string text) => GetLettersAmount(text) - GetVowelsAmount(text);

        public static (int amount, int[] indexes) GetOfOccurrencesAndIndexesPart(string text, string subtext)
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < text.Length - subtext.Length; i++)
            {
                if (text.Substring(i, subtext.Length).ToLower() == subtext.ToLower())
                {
                    indexes.Add(i);
                }
            }

            return (indexes.Count(), indexes.ToArray());

        }


        public static (int amount, int[] indexes) GetOfOccurrencesAndIndexesWhole(string text, string subtext)
        {
            Regex regex = new Regex($@"[ .,!?]*{subtext}[ .,!?]", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(text);
            return (matches.Count, new int[3]);

        }
    }
}
