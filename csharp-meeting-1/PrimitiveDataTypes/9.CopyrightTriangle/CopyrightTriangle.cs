using System;
using System.Text;

class CopyrightTriangle
{
    static void Main(string[] args)
    {
        // SET CONSOLE FONT TO A NON-RASTER ONE
        Console.WriteLine("If you see C instead of copyright symbols \nchange the font of the console from properties");

        char copyRight = '©';
        Console.OutputEncoding = Encoding.Unicode;

        for (int i = 1; i < 6; i+=2)
        {
            Console.Write(new string(' ', (5-i)/2));
            Console.WriteLine(new string(copyRight, i));
        }       
    }
}