using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzKata;

namespace FizzBuzzKataTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChecksWhenNumberIsDivisibleByThree()
        {
            Assert.AreEqual(FizzBuzz.isDivisibleByThree(3), true);
        }

        [TestMethod]
        public void ChecksWhenNumberIsNotDivisibleByThree()
        {
            Assert.AreEqual(FizzBuzz.isDivisibleByThree(2), false);
        }

        [TestMethod]

        public void ChecksWhenNumberIsDivisibleByFive()
        {
            Assert.AreEqual(FizzBuzz.isDivisibleByFive(5), true);
        }

        [TestMethod]

        public void ChecksWhenNumberIsNotDivisibleByFive()
        {
            Assert.AreEqual(FizzBuzz.isDivisibleByFive(4), false);
        }
    }
}
