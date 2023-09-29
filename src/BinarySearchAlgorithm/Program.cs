using BinarySearchAlgorithm;

BinarySearchImplementation bsi = new();

Console.WriteLine("Please Ctrl+C for quit.");
Console.WriteLine();
int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("Array: ");

foreach(var item in array)
{
    Console.Write(item+" ");
}
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Please enter the searched number: ");
    int searchElement = Convert.ToInt32(Console.ReadLine());

    var result = bsi.Search(array, searchElement);

    if (result == -1)
    {
        Console.WriteLine("Element not found!");
    }
    else
    {
        Console.WriteLine($"{searchElement} found at index: {result} ");
    }
}

