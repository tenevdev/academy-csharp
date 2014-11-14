using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.IsThirdDigit7
{
    class IsThirdDigit7
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isThirdDigit7 = (number / 100) % 10 == 7;
            Console.WriteLine("The third digit of {0} is 7 : {1}", number, isThirdDigit7);
        }
    }
}
