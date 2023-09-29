namespace PrimeNumber;

internal class PrimeNumberCalculate
{
    internal bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        else if (number == 2)
        {
            return true;
        }
        else if (number % 2 == 0)
        {
            return false;
        }

        int counter = 3;

        while ((counter * counter) <= number)
        {
            if (number % counter == 0)
            {
                return false;
            }
            else
            {
                counter += 2;
            }
        }
        return true;
    }
}
