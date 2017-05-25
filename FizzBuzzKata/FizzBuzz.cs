using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz  
    {
        public static bool isDivisibleByThree(int number)
        {
            return isDivisibleBy(number, 3);
        }

        public static bool isDivisibleByFive(int number)
        {
            return isDivisibleBy(number, 5);
        }

        public static bool isDivisibleByThreeAndFive(int number)
        {
            return isDivisibleBy(number, 15);
        }

        public static bool isDivisibleBy(int number, int divisor)
        {
            return (number % divisor == 0);
        }

        public static string play(int number)
        {
            if (isDivisibleBy(number, 15))
                return "Fizzbuzz";
            else if (isDivisibleBy(number, 5))
                return "Buzz";
            else if (isDivisibleBy(number, 3))
                return "Fizz";
            else
                return number.ToString();
        }
    }
}
