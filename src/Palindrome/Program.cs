using Palindrome;

CalculatePalindrome calculatePalindrome = new CalculatePalindrome();
Console.WriteLine("Enter a word for calculate is palindrome or not.");
var word=Console.ReadLine();
var res=calculatePalindrome.IsPalindrome(word) ? "Palindrome" : "Not Palindrome";

Console.WriteLine($"{word} is {res}");
Console.ReadLine();