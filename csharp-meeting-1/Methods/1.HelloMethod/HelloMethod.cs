using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HelloMethod
{
    class HelloMethod
    {
        static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            SayHello(name);
        }
    }
}
