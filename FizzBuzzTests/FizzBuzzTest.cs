using System;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizz()
        {
            var i = 3;
            Assert.AreEqual(("Fizz"), FizzBuzzGenerator.CalculateFizzBuzz(i));
        }

        [TestMethod]
        public void TestBuzz()
        {
            var i = 5;
            Assert.AreEqual(("Buzz"), FizzBuzzGenerator.CalculateFizzBuzz(i));
        }

        [TestMethod]
        public void TestFizzBuzz()
        {
            var i = 15;
            Assert.AreEqual(("FizzBuzz"), FizzBuzzGenerator.CalculateFizzBuzz(i));
        }

        [TestMethod]
        public void TestNoFizzNoBuzz()
        {
            var i = 2;
            Assert.AreEqual(String.Empty, FizzBuzzGenerator.CalculateFizzBuzz(i));
        }
    }
}
