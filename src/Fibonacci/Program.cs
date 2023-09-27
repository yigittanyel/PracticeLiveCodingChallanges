using Fibonacci;

CalculateFibonacci calculateFibonacci = new CalculateFibonacci();
Console.WriteLine("Enter a number to calculate fibonacci:");
int number = Convert.ToInt32(Console.ReadLine());

var result = calculateFibonacci.FibonacciResult(number);
Console.WriteLine("Fibonacci of " + number + " is " + result);