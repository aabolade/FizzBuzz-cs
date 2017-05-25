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
        {)
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
    }
}
