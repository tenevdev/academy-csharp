using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PrintMinAndMax
{
    class PrintMinAndMax
    {
        static void Main(string[] args)
        {
            Console.Write("Input count:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Input sequence");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("Max: {0}\nMin: {1}", max, min);
        }
    }
}
