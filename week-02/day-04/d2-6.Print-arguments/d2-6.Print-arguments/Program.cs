using System;

namespace d2_6.Print_arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer("first");
            Printer("first", "second");
            Printer("first", "second", "third", "fourh");
            
            Console.ReadLine();
        }

        static void Printer(params string[] print)
        {
            foreach (string p in print)
            {
                Console.Write(p);
            }
            Console.WriteLine();
        }
    }
}
