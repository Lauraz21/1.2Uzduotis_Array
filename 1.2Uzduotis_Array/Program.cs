using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int result = SumOfNumbers(numbers);
        Console.WriteLine(result);
    }

    public static int SumOfNumbers(int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
}
