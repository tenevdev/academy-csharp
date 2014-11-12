using System;

class NullValues
{
    static void Main(string[] args)
    {
        int? integer = null;
        double? real = null;

        Console.WriteLine("Null integer: {0}", integer);
        Console.WriteLine("Null double: {0}", real);

        Console.WriteLine("Null integer + 5 = {0}", integer + 5);
        Console.WriteLine("Null double + 2.5 = {0}", real + 2.5);

        Console.WriteLine("The result is always null");
        Console.WriteLine();
    }
}