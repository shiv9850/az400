using Calculator.BL.Contracts;
using Calculator.BL.Services;
using NUnit.Framework;

namespace Calculator.NUnitTest
{
    public class Tests
    {
        private ICalculatorService _calculatorService;
        [SetUp]
        public void Setup()
        {
            _calculatorService = new CalculatorService();
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(1, -2, -1)]
        [TestCase(-1, -1, -2)]
        public void AddTest_ExpectedResult(long num1, long num2, long expectedResult)
        {
            var actualResult = this._calculatorService.Add(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}