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
            return (number % 3 == 0);
        }

        public static bool isDivisibleByFive(int number)
        {
            return (number % 5 == 0);
        }

        public static bool isDivisibleByThreeAndFive(int number)
        {
            return (number % 15 == 0);
        }
    }
}
