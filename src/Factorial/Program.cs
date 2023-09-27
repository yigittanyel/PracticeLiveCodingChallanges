using Factorial;

CalculateFactorial factorial = new CalculateFactorial();

Console.WriteLine("Enter a number to calculate factorial:");
int number = Convert.ToInt32(Console.ReadLine());

var result = factorial.FactorialResult(number);
Console.WriteLine("Factorial of " + number + " is " + result);


