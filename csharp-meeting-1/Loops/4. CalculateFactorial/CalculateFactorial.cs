using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorial
{
    class CalculateFactorial
    {
        static BigInteger Factorial(int n)
        {
            if (n == 1)
                return 1;
            return (BigInteger)n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),
                k = int.Parse(Console.ReadLine());

            //Recursive
            BigInteger nFact = Factorial(n);
            BigInteger kFact = Factorial(k);

            //Loops
            BigInteger nF = 1, kF = 1;
            for (BigInteger i = 2; i <= n; i++)
            {
                nF *= i;
            }
            for (BigInteger i = 2; i <= k; i++)
            {
                kF *= i;
            }

            Console.WriteLine("Using loops -> {0}! / {1}! = {2}", n, k, nF / kF);
            Console.WriteLine("Recursive -> {0}! / {1}! = {2}", n, k, nFact / kFact);
        }
    }
}
