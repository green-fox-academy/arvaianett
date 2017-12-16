using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class FibonacciClass
    {
        public int NthFibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return NthFibonacci(n - 1) + NthFibonacci(n - 2);
            }
        }
    }
}
