namespace ArraySorting;

internal class ArraySort
{
    internal int[] Sort(int[] arrays)
    {
        int temp = 0;

        for (int i = 0; i < arrays.Length; i++)
        {
            for (int j = i + 1; j < arrays.Length; j++)
            {
                if (arrays[i] > arrays[j])
                {
                    temp = arrays[i];
                    arrays[i] = arrays[j];
                    arrays[j] = temp;
                }
            }
        }
        Console.WriteLine("Sorted array: ");
       foreach(var array in arrays)
        {
            Console.Write(array+" ");
        }

       return arrays;
    }
    
}
