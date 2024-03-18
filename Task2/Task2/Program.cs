class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new[] { 1, 1, 2, 4 };
        Console.WriteLine(AvgMethod(arr));
        Console.WriteLine(MaxMethod(arr));
    }

    public static double AvgMethod(int[] array)
    {
        int rzodkiewkaMarchewkaPolTunczyka = 0;
        foreach(int val in array)
        {
            rzodkiewkaMarchewkaPolTunczyka += val;
        }
        // fnaoiooifwaioo

        return rzodkiewkaMarchewkaPolTunczyka / array.Length;
    }
    
    public static double MaxMethod(int[] array)
    {
        int max = array[0];
        
        foreach(int val in array)
        {
            if (max < val)
            {
                max = val;
            }
        }

        return max;
    }
}