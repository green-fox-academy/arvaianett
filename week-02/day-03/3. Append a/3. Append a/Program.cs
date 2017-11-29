using System;

namespace _3._Append_a
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";

            AppendA(am);
            Console.ReadLine();
        }

        static void AppendA(string something)
        {
            something = something + "a";

            Console.WriteLine(something);
        }
    }
}
