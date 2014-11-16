using System;

namespace PrimeNumbers
{
    class PrimeNumbers
	{
		static void Main()
		{
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 184;

            long n = 10000000;
            bool[] array = new bool[n]; //Initialized with False value

            // Remove non-primes by finding mutiples 
            for (int j = 2; j < n; j++)
            {
                if (array[j] == false)
                {
                    for (long p = 2; (p * j) < n; p++)
                    {
                        array[p * j] = true; // Set non-prime indexes to true;
                    }
                }
            }

            // False is prime
            for (int i = 2; i < n; i++)
            {
                if (array[i] == false)
                {
                    Console.Write("{0} ", i);
                }
            }
			Console.WriteLine();
		}
	}
}
