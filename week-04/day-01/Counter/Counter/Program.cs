using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter();
            
            counter1.Add();
            Console.WriteLine(counter1.C);

            counter1.Get();
            Console.WriteLine(counter1.C);

            counter1.Reset();
            Console.WriteLine(counter1.C);

            Console.ReadLine();
        }
    }
}
