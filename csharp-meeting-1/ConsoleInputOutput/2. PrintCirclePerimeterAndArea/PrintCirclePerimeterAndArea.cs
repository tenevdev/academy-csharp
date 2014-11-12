using System;

class PrintCirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;

        Console.WriteLine("The circle's area is: {0}", area);
        Console.WriteLine("The circle's perimeter is: {0}", perimeter);
    }
}