using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program that finds the volume of a rectangle using height, length and width.
namespace WelcomeBack3
{
    class Program
    {
        static void Main(string[] args)
        {
            //promt to enter height
            Console.WriteLine("Please enter the height of the rectangle.");
            string input = Console.ReadLine();
            int value;
            int.TryParse(input, out value);//convert to integer value

            //promt to enter length
            Console.WriteLine("Please enter the length of the rectangle.");
            string input2 = Console.ReadLine();
            int value2;
            int.TryParse(input2, out value2);//convert to value 2

            //prompt to enter width
            Console.WriteLine("Please enter the width of the rectangle.");
            string input3 = Console.ReadLine();
            int value3;
            int.TryParse(input3, out value3);//convert to value 3
            Console.WriteLine(value * value2 * value3);//multiply each int variable to get volume
        }
    }
}
