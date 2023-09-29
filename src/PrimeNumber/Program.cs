using PrimeNumber;

PrimeNumberCalculate primeNumberCalculate = new PrimeNumberCalculate();

Console.WriteLine("For quit please press Ctrl + C");
Console.WriteLine();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Write a number to calculate is prime number or not.");
    var number = Convert.ToInt32(Console.ReadLine());

    var result = primeNumberCalculate.IsPrime(number);
    if (result is true)
    {
        Console.WriteLine($"{number} is prime number.");
    }
    else
    {
        Console.WriteLine($"{number} is not prime number.");
    }
}
