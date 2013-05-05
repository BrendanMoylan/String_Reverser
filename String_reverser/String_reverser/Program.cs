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
            string newString = "";

            Console.Write("Please input a string: ");
            stringToBeReversed = Console.ReadLine();

            for (int i = stringToBeReversed.Length; i > 0 ; i--)
            {
                newString += Convert.ToString(stringToBeReversed[i-1]);                
            }

            Console.WriteLine("Your reversed string is: " + newString);

            Console.ReadKey();
        }
    }
}
