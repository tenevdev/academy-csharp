using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.SignedProduct
{
    class SignedProduct
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            bool sign = true;
            if (first < 0)
            {
                sign = !sign;
            }
            if (second < 0)
            {
                sign = !sign;
            }
            if (third < 0)
            {
                sign = !sign;
            }
            if (sign)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
