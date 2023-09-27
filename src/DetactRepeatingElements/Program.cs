using DetactRepeatingElements;

DetectRepeating detectRepeating = new DetectRepeating();
int[] arrays = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
int[] repeatingElements = detectRepeating.DetectRepeatingElements(arrays);


foreach (var element in repeatingElements)
{
    Console.Write(element + " ");
}


Console.ReadKey();
