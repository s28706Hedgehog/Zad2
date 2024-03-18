class Program
{
    public static double AvgMethod(int[] array)
    {
        int sum = 0;
        foreach (int val in array)
        {
            sum += val;
        }

        return sum / array.Length;
    }
    
    public static void Main(string[] args)
    {
        int[] arr = new[] { 1, 1, 2, 4 };
        Console.WriteLine(AvgMethod(arr));
    }
}