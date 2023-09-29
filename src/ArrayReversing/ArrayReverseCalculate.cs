namespace ArrayReversing;

internal class ArrayReverseCalculate
{
    internal int[] Reverse(int[] arrays)
    {
        int temp = 0;

        for (int i = 0; i < arrays.Length / 2; i++) 
            //dizinin ortasından sona doğru gidilerek her seferinde bir elemanın yeri değiştiriliyor.
        {
            temp = arrays[i];
            arrays[i] = arrays[arrays.Length - i - 1];
            arrays[arrays.Length - i - 1] = temp;
        }
        Console.WriteLine("Reversed array: ");
        foreach (var array in arrays)
        {
            Console.Write(array + " ");
        }

        return arrays;
    }   
}
