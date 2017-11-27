using System;

namespace exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int oneDayHours = 24;
            int oneDayMinutes = 60;
            int oneDaySeconds = 60;
            
            Console.WriteLine(oneDaySeconds * oneDayMinutes * oneDayHours - currentSeconds * currentMinutes * currentHours);

            Console.ReadLine();
        }
    }
}
