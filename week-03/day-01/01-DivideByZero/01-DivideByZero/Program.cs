using System;

namespace _01_DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(DivideTen(input));

            Console.ReadLine();
        }

        static int DivideTen(int number)
        {
            int result = 0;

            try
            {
                result = 10 / number;                             
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("fail");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}
