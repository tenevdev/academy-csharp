using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddPolynomials
{
    class AddPolynomials
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
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("{0} * x^{1}", res[i], i);
            }

        }
    }
}
