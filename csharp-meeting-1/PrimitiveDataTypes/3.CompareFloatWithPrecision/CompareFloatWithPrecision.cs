using System;

class CompareFloatWithPrecision
{
    static void Main(string[] args)
    {
        float firstNumber = float.Parse(Console.ReadLine());
        float secondNumber = float.Parse(Console.ReadLine());
        float precision = 0.000001f;

        Console.WriteLine("({0} ; {1}) -> {2}", firstNumber.ToString(), secondNumber.ToString(), Math.Abs(firstNumber - secondNumber) < precision);
    }
}