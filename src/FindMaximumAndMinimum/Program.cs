using FindMaximumAndMinimum;

FindMaximum findMaximum = new FindMaximum();
FindMinimum findMinimum = new FindMinimum();


int[] array = { 57, 44, 51, 78, 14, 38, 88, 74, 39 };

Console.Write("Array:");
foreach(var x in array)
{
    Console.Write(x + " ");
}
Console.WriteLine();
Console.WriteLine("Array lenght:" + array.Length);
Console.WriteLine("-----------------------------------");
Console.WriteLine("Maximum: "+findMaximum.FindMax(array));
Console.WriteLine("Minimum: "+findMinimum.FindMin(array));
