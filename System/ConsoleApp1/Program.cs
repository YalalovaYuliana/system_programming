// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int op = 3;

int result = switch(op) 
{
    1 => 1 + 2;
    3 => 1 + 1;
    _ => 3;
}
