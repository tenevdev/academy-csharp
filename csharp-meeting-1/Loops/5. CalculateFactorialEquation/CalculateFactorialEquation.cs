using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorialEquation
{
    class CalculateFactorialEquation
    {
        static BigInteger Factorial(int n)
        {
            if (n == 1 || n < 0)
                return 1;
            return (BigInteger)n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),
                k = int.Parse(Console.ReadLine());

            BigInteger nFact = Factorial(n);
            BigInteger kFact = Factorial(k);
            BigInteger diffFact = Factorial(k-n);

            Console.WriteLine((nFact * kFact) / diffFact);
        }
    }
}