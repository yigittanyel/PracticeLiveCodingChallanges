namespace FindMaximumAndMinimum;

internal class FindMinimum
{
    internal int FindMin(int[] arrays)
    {
        int min = arrays[0];

        if (arrays.Length < 0)
            Console.WriteLine("Array lenght must be higher than 0");

        if (arrays.Length == 1)
            return arrays[0];

        for (int i = 0; i < arrays.Length; i++)
        {
            if (arrays[i] < min)
            {
                min = arrays[i];
            }
        }

        return min;
    }
}
