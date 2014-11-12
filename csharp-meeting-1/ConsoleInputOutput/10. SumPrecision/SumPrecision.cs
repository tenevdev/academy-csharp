using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumPrecision
{
    static void Main(string[] args)
    {
        double sum = 1, lastSum = 0;
        double precision = 0.001f;
        int index = 2;
        while (Math.Abs(sum - lastSum) > precision)
        {
            lastSum = sum;
            sum += 1 / (index * Math.Pow(-1, index++));
        }

        Console.WriteLine("{0:F3}", sum);
    }
}

