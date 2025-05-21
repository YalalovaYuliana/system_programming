namespace StringTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] unacceptedWords = { "fish", "sea" };

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            Dictionary<String, int> badWords = new Dictionary<String, int>();

            foreach (var unacceptedWord in unacceptedWords)
            {
                if (text.Contains(unacceptedWord))
                {                

                    string censorship = "";
                    int amount = 0;

                    foreach (string word in text.Split(' '))
                    {
                        if (word.Contains(unacceptedWord)) amount++;
                    }

                    for (int j = 0; j < unacceptedWord.Length; j++)
                    {
                        censorship += "*";
                    }

                    text = text.Replace(unacceptedWord, censorship);

                    badWords.Add(unacceptedWord, amount);

                }
            }

            if (badWords.Count > 0)
            {
                Console.Write("Недопустимые слова: ");

                foreach (string key in badWords.Keys)
                {
                    Console.Write(key + " ");
                }

                Console.WriteLine("\n\nРезультат работы:\n" + text + "\n");
                Console.WriteLine("Статистика:\n");

                foreach (string key in badWords.Keys)
                {
                    Console.WriteLine($"{badWords[key]} замены слова {key}");
                }
            }
            else Console.WriteLine("Недопустимых слов нет!");
        }
    }
}