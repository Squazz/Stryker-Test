using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Calculator.Calculator _sut = new();

        [DataTestMethod]
        [DataRow(5, 5, 10)]
        public void Test_Add(int first, int second, int expected)
        {
            int result = _sut.Add(first, second);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(5, 5, 0)]
        public void Test_Subtract(int first, int second, int expected)
        {
            int result = _sut.Subtract(first, second);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        public void Test_Multiply(int first, int second, int expected)
        {
            int result = _sut.Multiply(first, second);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1, 0)]
        public void Test_Divide(int first, int second, int expected, int remainder)
        {
            var result = _sut.Divide(first, second);

            Assert.AreEqual(expected, result.result);
            Assert.AreEqual(remainder, result.remainder);
        }

        [TestMethod]
        public void Test_Divide_ByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => _sut.Divide(1, 0));
        }
    }
}
