using System;

class PrintGreaterNumber
{
    static void Main(string[] args)
    {
        int numberOfBitsInInt = 32; // int has 32 bits

        int a = int.Parse(Console.ReadLine()),
            b = int.Parse(Console.ReadLine());

        int c = a - b; // Store the difference

        // Shift the difference 31 bits to leave only the bit which shows the sign of the difference
        // Then get only this bit and store it
        // This will be 1 if c is negative and 0 if c is positive
        int k = (c >> (numberOfBitsInInt - 1)) & 0x1;

        // max = a - k * a + k * b
        int max = a - k * c;

        Console.WriteLine("The grater number is {0}", max);
    }
}