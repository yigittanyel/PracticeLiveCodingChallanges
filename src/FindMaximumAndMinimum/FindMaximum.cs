namespace FindMaximumAndMinimum;

internal class FindMaximum
{
    internal int FindMax(int[] arrays)
    {
        int max = arrays[0];

        if (arrays.Length < 0)
            Console.WriteLine("Array lenght must be higher than 0");

        if (arrays.Length == 1)
            return arrays[0];

        for (int i = 0; i < arrays.Length; i++)
        {
            if (arrays[i] > max)
            {
                max = arrays[i];
            }
        }

        return max;
    }
}
