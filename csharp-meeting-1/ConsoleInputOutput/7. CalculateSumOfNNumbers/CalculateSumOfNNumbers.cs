using System;

class CalculateSumOfNNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] number = new int[n];
        for (int i = 0; i < n; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        foreach (var num in number)
        {
            sum += num;   
        }
        Console.WriteLine("The sum is {0}", sum);
    }
}