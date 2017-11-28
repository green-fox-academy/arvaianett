using System;

namespace d1_exercise32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type 0: ");
            string number = Console.ReadLine();

            for (int j = int.Parse(number); j < 5; j++)

                for (int i = int.Parse(number); i < 5; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("%%%%%");
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("%%  %");
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("% % %");
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("%  %%");
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("%%%%%");
                    }

                    Console.ReadLine();
                }

            
        }
    }
}
