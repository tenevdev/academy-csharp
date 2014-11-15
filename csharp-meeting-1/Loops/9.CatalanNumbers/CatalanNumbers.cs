using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
	{
        static BigInteger Factorial(BigInteger n)
        {
            if (n == 1 || n < 0)
                return 1;
            return n * Factorial(n - 1);
        }

		static void Main (string[] args)
		{
            int n = int.Parse(Console.ReadLine());

            BigInteger catalanNumber = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
            Console.WriteLine(catalanNumber);
		}
	}
}
