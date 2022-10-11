class ArraySwaps
{
    static void swapArray(string[] args)
    {
        int[] InputArray = new int[] { 3, 4, 5, 6 };
        int[] result = ReversedArray(InputArray);
        foreach (var item in result)
        {
            Console.WriteLine(item.ToString());
        }
    }

    static int[] ReversedArray(int[] array)

    {
        int n = array.Length;
        int[] emptyArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            emptyArray[i] = array[n - i - 1];
        }
        return emptyArray;


    }

}



