using System;

class StringConcatenation
{
    static void Main(string[] args)
    {
        string firstString = "Hello";
        string secondString = "World";
        object concatenatenation = firstString + " " + secondString;
        string concatenationString = concatenatenation.ToString();
    }
}