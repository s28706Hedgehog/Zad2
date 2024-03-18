class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new[] { 1, 1, 2, 4 };
        Console.WriteLine(AvgMethod(arr));
    }

    public static double AvgMethod(int[] array)
    {
        int sumSum = 0;
        foreach(int val in array)
        {
            sumSum += val;
        }

        return sumSum / array.Length;
    }
}