using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SubsetSum
{
    class SubsetSum
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]
            {
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
            };

            int sum = 0;

            //2-digit sums
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j =  i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", numbers[i], numbers[j]);
                    }
                }
            }

            //3-digit sums
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", numbers[i], numbers[j], numbers[k]);
                        }
                    }
                }
            }

            //4-digit sums
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (sum - numbers[i] == 0)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (j != i)
                        {
                            Console.Write("{0} + ", numbers[j]);
                        }
                    }
                    Console.WriteLine("= 0");
                }
            }

            //5-digit sum
            if (sum == 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("{0} + ", numbers[i]);
                }
                Console.WriteLine("= 0");
            }
            
        }
    }
}
