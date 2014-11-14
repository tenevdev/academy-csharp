using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CheckDivisionBy7And5
{
    class CheckDivisionBy7And5
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool canBeDivided = number % 35 == 0;
            Console.WriteLine("{0} can be divided by 7 and 5 : {1}", number, canBeDivided);
        }
    }
}
