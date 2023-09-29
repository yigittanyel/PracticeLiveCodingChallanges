namespace BinarySearchAlgorithm;

internal class BinarySearchImplementation
{
    internal int Search(int[] arrays, int searchElement)
    {
        int first = 0;
        int last = arrays.Length - 1;
        int middle = (first + last) / 2;

        while (first <= last)
        {
            if (arrays[middle] < searchElement)
            {
                first = middle + 1;
            }
            else if (arrays[middle] == searchElement)
            {
                return middle;
            }
            else
            {
                last = middle - 1;
            }
            middle = (first + last) / 2;
        }
        return -1;
    }
}
