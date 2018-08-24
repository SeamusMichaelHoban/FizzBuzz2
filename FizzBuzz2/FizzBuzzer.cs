using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int input)
        {
            if (IsMutipleOf3(input) && IsMultipleOf5(input))
            {
                return "FizzBuzz";
            }
            if (IsMutipleOf3(input))
            {
                return "Fizz";
            }
            if (IsMultipleOf5(input))
            {
                return "Buzz";
            }
            return input.ToString();

        }

        private bool IsMutipleOf3(int number)
        {
            return number % 3 == 0;
        }
        
        private bool IsMultipleOf5(int number)
        {
            return number % 5 == 0;
        }
    }
}
