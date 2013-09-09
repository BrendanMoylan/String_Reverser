using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_reverser
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToBeReversed;
            StringBuilder newString = new StringBuilder();

            Console.Write("Please input a string: ");
            stringToBeReversed = Console.ReadLine();

            for (int i = stringToBeReversed.Length - 1; i >= 0 ; i--)
            {
                newString.Append(stringToBeReversed[i]);                
            }

            Console.WriteLine("Your reversed string is: {0}", newString);

            Console.ReadKey();
        }
    }
}
