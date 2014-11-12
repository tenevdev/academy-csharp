using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.SwitchTypeChoice
{
    class SwitchTypeChoice
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int integer;
            double real;
            string type = "String";
            if (double.TryParse(input, out real))
            {
                type = "Double";
            }
            if (int.TryParse(input, out integer))
            {
                type = "Integer";
            }
            switch (type)
            {
                case "Double":
                    Console.WriteLine((real+=1).ToString());
                    break;
                case "Integer":
                    Console.WriteLine((integer+=1).ToString());
                    break;
                case "String":
                    Console.WriteLine(input + "*");
                    break;
                default:
                    break;
            }
        }
    }
}
