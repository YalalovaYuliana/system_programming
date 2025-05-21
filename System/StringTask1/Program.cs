using System.Text;

//Console.Write("Enter your string: ");

//string str = Console.ReadLine();
//StringBuilder reversedStr = new StringBuilder(str.Length);
//Console.WriteLine(reversedStr.Capacity);

//for (int i = str.Length - 1;  i >= 0; i--)
//{
//    reversedStr.Append(str[i]);
//}

//if (str == reversedStr.ToString()) Console.WriteLine("Your string is polydrome");
//else Console.WriteLine("Your string isn't polydrome");

Console.Write("Enter your string: ");

string str = Console.ReadLine().ToLower();

char[] strArray = str.ToCharArray();

Array.Reverse(strArray);

if (str == new string(strArray)) Console.WriteLine("Your string is polydrome");
else Console.WriteLine("Your string isn't polydrome");