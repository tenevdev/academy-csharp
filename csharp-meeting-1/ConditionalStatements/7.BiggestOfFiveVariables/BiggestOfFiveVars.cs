using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfFiveVariables
{
    class BiggestOfFiveVars
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;

            double[] vars = new double[5]
            {
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
            };

            for (int i = 0; i < vars.Length; i++)
            {
                if (max < vars[i])
                {
                    max = vars[i];
                }
            }

            Console.WriteLine("The biggest of these numbers is {0}", max);
        }
    }
}
