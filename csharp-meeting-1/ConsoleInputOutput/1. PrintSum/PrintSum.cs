using System;

class PrintSum
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} + {2} = {3}", firstNumber, secondNumber, thirdNumber, firstNumber + secondNumber + thirdNumber);
    }
}