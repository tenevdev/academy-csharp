using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReverseDigits
{
    class ReverseDigits
    {
        static int Reverse(int number)
        {
            int reverse = 0;
            List<byte> digits = new List<byte>(); 
            while (number > 0)
            {
                digits.Add((byte)(number % 10));
                number /= 10;
            }
            for (int i = 0; i < digits.Count; i++)
            {
                reverse += (int)Math.Pow(10, digits.Count - i - 1) * digits[i];
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(n));
        }
    }
}
