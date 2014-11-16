using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtendPolynomials
{
    class ExtendPolynomials
    {
        static int[] Add(int[] first, int[] second)
        {
            int longer = first.Length > second.Length ? first.Length : second.Length;
            int[] sum = new int[longer];
            for (int i = 0; i < longer; i++)
            {
                if (i < first.Length)
                {
                    sum[i] += first[i];
                }
                if (i < second.Length)
                {
                    sum[i] += second[i];
                }
            }
            return sum;
        }

        static int[] Substract(int[] first, int[] second)
        {
            int longer = first.Length > second.Length ? first.Length : second.Length;
            int[] result = new int[longer];
            for (int i = 0; i < longer; i++)
            {
                if (i < first.Length)
                {
                    result[i] += first[i];
                }
                if (i < second.Length)
                {
                    result[i] -= second[i];
                }
            }
            return result;
        }

        static int[] Multiply(int[] first, int[] second)
        {
            int longer = first.Length > second.Length ? first.Length : second.Length;
            int[] result = new int[longer];
            for (int i = 0; i < longer; i++)
            {
                if (i < first.Length)
                {
                    result[i] += first[i];
                }
                if (i < second.Length)
                {
                    result[i] *= second[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            Console.WriteLine("Input array: ");
            for (int i = 0; i < n; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Input m: ");
            int m = int.Parse(Console.ReadLine());

            int[] second = new int[m];
            Console.WriteLine("Input array: ");
            for (int i = 0; i < m; i++)
            {
                second[i] = int.Parse(Console.ReadLine());
            }

            int[] res = Add(first, second);

            Console.WriteLine("Add : ");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("{0} * x^{1}", res[i], i);
            }

            res = Substract(first, second);
            Console.WriteLine("Substract : ");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("{0} * x^{1}", res[i], i);
            }

            res = Multiply(first, second);
            Console.WriteLine("Multiply : ");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("{0} * x^{1}", res[i], i);
            }
        }
    }
}
