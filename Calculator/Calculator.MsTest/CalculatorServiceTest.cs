using Calculator.BL.Contracts;
using Calculator.BL.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.MsTest
{
    [TestClass]
    public class CalculatorServiceTest
    {
        private ICalculatorService _calculatorService;

        [TestInitialize]
        public void Init()
        { 
            _calculatorService = new CalculatorService();
        }

        [TestCleanup]
        public void CLeanUP()
        {
            _calculatorService = null;
        }

        [TestMethod]
        [DataRow(1,2,3)]
        [DataRow(1, -2,-1)]
        [DataRow(-1, -1,-2)]
        public void AddTest_ExpectedResult(long num1,long num2,long expectedResult)
        {
            var actualResult = this._calculatorService.Add(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}