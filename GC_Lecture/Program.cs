using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max generation: {GC.MaxGeneration}");
            GarbageHelper hlp = new GarbageHelper();
            Console.WriteLine($"Object generation: {GC.GetGeneration(hlp)}");
            Console.WriteLine($"Busy memory (byte): {GC.GetTotalMemory(false)}");
            hlp.MakeGarbage();
            Console.WriteLine($"Busy memory (byte): {GC.GetTotalMemory(false)}");
            GC.Collect();
            Console.WriteLine($"Busy memory (byte): {GC.GetTotalMemory(false)}");
            Console.WriteLine($"Object generation: {GC.GetGeneration(hlp)}");
            GC.Collect();
            Console.WriteLine($"Busy memory (byte): {GC.GetTotalMemory(false)}");
            Console.WriteLine($"Object generation: {GC.GetGeneration(hlp)}");
        }
    }

    class GarbageHelper
    {
        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                _ = new Person();
            }
        } 
        class Person
        {
            string name;
            string age;
        }
        
    }
}
