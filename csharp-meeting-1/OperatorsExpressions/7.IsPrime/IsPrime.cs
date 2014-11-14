using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.IsPrime
{
    class IsPrime
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // 1 to 100

            bool is2357 = (number == 2) || (number == 3) || (number == 5) || (number == 7);
            bool isOtherPrime = (number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0);

            bool isPrime = is2357 || isOtherPrime;

            Console.WriteLine("The number {0} is prime : {1}", number, isPrime);
        }
    }
}
