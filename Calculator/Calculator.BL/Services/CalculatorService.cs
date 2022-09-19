using Calculator.BL.Contracts;

namespace Calculator.BL.Services
{
    public class CalculatorService : ICalculatorService
    {
        public long Add(long num1, long num2)
        {
            return num1 + num2;
        }

        public long Substract(long num1, long num2)
        {
            return (num1 - num2);
        }

        public long Sum(params long[] numbers)
        {
            return numbers.Sum();
        }
    }
}
