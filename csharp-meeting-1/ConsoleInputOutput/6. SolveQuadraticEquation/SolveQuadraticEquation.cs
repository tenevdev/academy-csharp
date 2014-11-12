using System;

class SolveQuadraticEquation
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine()),
            b = double.Parse(Console.ReadLine()),
            c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant >= 0)
        {
            Console.WriteLine("x1= {0} \nx2= {1}", (-b + Math.Sqrt(discriminant))/2*a, (-b - Math.Sqrt(discriminant))/2*a);
        }

        else
        {
            Console.WriteLine("D<0, please enter valid data.");
        }

    }
}