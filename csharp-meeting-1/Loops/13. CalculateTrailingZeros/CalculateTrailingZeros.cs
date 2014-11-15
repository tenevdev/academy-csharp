using System;

namespace _13.CalculateTrailingZeros
{
    class CalculateTrailingZeros
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());

            ulong counter = 0;
            int power = 1;

            do
            {
                counter += n / (ulong)Math.Pow(5, power);
                power++;

            } while (Math.Pow(5, power) <= n);

            
            Console.WriteLine("The number of trailing zeros is {0}", counter);
        }
    }
}
