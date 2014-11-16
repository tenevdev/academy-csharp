using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SequenceOfGivenSum
{
    class SequenceOfGivenSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter sum: ");
            int sum = int.Parse(Console.ReadLine());
            int currentSum = 0, index = -1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                currentSum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    currentSum += array[j];
                    if (sum == currentSum)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    break;
                }
            }

            if (index != -1)
            {
                Console.Write("{");
                int s = 0;
                while (s != sum)
                {
                    s += array[index];
                    Console.Write(" {0}", array[index]);
                    index += 1;
                }
                Console.WriteLine(" }");
            }
            else
            {
                Console.WriteLine("No sequence found.");
            }
        }
    }
}
