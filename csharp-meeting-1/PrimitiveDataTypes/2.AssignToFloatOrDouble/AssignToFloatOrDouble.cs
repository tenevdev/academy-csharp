using System;

class AssignToFloatOrDouble
{
    static void Main(string[] args)
    {
        //34.567839023, 12.345, 8923.1234857, 3456.091

        double firstNumber = 34.567839023;
        Console.WriteLine("{0} is double", firstNumber);

        float secondNumber = 12.345f;
        Console.WriteLine("{0} is float", secondNumber);

        double thirdNumber = 8923.1234857;
        Console.WriteLine("{0} is double", thirdNumber);

        float fourthNumber = 3456.091f;
        Console.WriteLine("{0} is float", fourthNumber);
    }
}