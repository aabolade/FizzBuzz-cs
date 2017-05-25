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

        [TestMethod]
        public void ChecksWhenNumberIsDivisibleByThreeAndFive()
        {
            Assert.AreEqual(FizzBuzz.isDivisibleByThreeAndFive(15), true);
        }

        [TestMethod]

        public void ChecksWhenNumberIsNotDivisibleByThreeAndFive()
        {
            Assert.AreEqual(FizzBuzz.isDivisibleByThreeAndFive(9), false);
        }

        [TestMethod]

        public void ChecksWhenNumberIsDivisibleByADivisor()
        {
            Assert.AreEqual(FizzBuzz.isDivisibleBy(16,4), true);
            Assert.AreEqual(FizzBuzz.isDivisibleBy(25, 5), true);
            Assert.AreEqual(FizzBuzz.isDivisibleBy(9, 3), true);
        }

        [TestMethod]

        public void ChecksWhenNumberIsNotDivisibleByADivisor()
        {
            Assert.AreEqual(FizzBuzz.isDivisibleBy(16, 3), false);
            Assert.AreEqual(FizzBuzz.isDivisibleBy(25, 6), false);
            Assert.AreEqual(FizzBuzz.isDivisibleBy(9, 2), false);
        }

        [TestMethod]

        public void ReturnsFizzWhenNumberIsDivisibleByThree()
        {
            Assert.AreEqual(FizzBuzz.play(3), "Fizz");
        }

        [TestMethod]

        public void ReturnsBuzzWhenNumberIsDivisibleByThree()
        {
            Assert.AreEqual(FizzBuzz.play(5), "Buzz");
        }

        [TestMethod]

        public void ReturnsFizzBuzzWhenNumberIsDivisibleByThreeAndFive()
        {
            Assert.AreEqual(FizzBuzz.play(15), "Fizzbuzz");
        }

        [TestMethod]

        public void ReturnsNumberWhenNotDivisibleByThreeFiveOrBothThreeAndFive()
        {
            Assert.AreEqual(FizzBuzz.play(7), "7");
        }

    }
}
