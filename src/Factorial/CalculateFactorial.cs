namespace Factorial;

internal class CalculateFactorial
{
    internal int FactorialResult(int number)
    {

        if (number < 0)
            Console.WriteLine("Number must be higher than 0");

        if (number == 0)
            return 1;

        while (number>0)
        {
            return number * FactorialResult(number - 1);
        }
        return 0;
    }

}
