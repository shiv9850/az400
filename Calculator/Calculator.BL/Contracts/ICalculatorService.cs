namespace Calculator.BL.Contracts
{
    public interface ICalculatorService
    {
        long Sum(params long[] numbers);

        long Add(long num1, long num2);

        long Substract(long num1,long num2);
    }
}
