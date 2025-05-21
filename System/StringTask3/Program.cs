using System.Text;

class MyClass
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        string[] separators = { ". ", "! ", "? " };

        for (int i = 0; i < separators.Length; i++)
        {
            string[] newText = text.Split(separators[i]);
            toUpperFirstLetter(newText);
            text = String.Join(separators[i], newText);
        }

        Console.WriteLine(text);
    }

    static void toUpperFirstLetter(String[] sentenses)
    {
        for (int i = 0; i < sentenses.Length; i++)
        {
            StringBuilder sb = new StringBuilder(sentenses[i]);
            sb[0] = char.Parse(sb[0].ToString().ToUpper());
            sentenses[i] = sb.ToString();
        }
    }
}


