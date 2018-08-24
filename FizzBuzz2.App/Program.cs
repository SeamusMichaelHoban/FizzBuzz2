using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzer();
            for (int i = 0; i < 100; i++)
            {
                //Use our library we cretated.
                var output = fizzBuzzer.FizzBuzz(i);
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
