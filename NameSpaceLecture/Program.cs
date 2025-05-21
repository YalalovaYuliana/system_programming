using A;
using B;
using namespaceCD = C.D;
using System;


namespace NameSpaceLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(A.Increment.Value);
            Console.WriteLine(B.Increment.Value);
            Console.WriteLine(namespaceCD::Increment.Value);

            Console.ReadKey();
        }
    }
}
