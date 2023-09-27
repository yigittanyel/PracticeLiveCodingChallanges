namespace DetactRepeatingElements;

internal class DetectRepeating
{
    internal int[] DetectRepeatingElements(int[] arrays)
    {
        int[] repeatingElements = new int[arrays.Length];
        int counter = 0;

        for (int i = 0; i < arrays.Length; i++)
        {
            for (int j = i + 1; j < arrays.Length; j++)
            {
                if (arrays[i] == arrays[j])
                {
                    repeatingElements[counter] = arrays[i];
                    counter++;
                }
            }
        }

        return repeatingElements;
    }
}
