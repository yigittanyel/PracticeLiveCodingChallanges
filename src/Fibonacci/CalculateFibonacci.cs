namespace Fibonacci;

internal class CalculateFibonacci
{
    internal int FibonacciResult(int number)
    {
        if (number < 0)
            Console.WriteLine("Number must be higher than 0");

        if (number == 0)
            return 0;

        if (number == 1)
            return 1;

        return FibonacciResult(number - 1) + FibonacciResult(number - 2);
    }
}
