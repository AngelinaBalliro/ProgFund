using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOne;
            int numTwo;
            int numThree;
            int numFour;

            Console.WriteLine(" This program will ask you to input four numbers. \n It will then tell you which is the largest. \n \n");
            Console.Write(" Please enter your first number: ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \n Please enter your second number: ");
            numTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \n Please enter your third number: ");
            numThree = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \n Please enter your fourth number: ");
            numFour = Convert.ToInt32(Console.ReadLine());

            if (numOne >= numTwo && numOne >= numThree && numOne >= numFour)
            {
                Console.WriteLine($"Number One is the largest number. The value is {numOne}");
            }
            if (numTwo >= numOne && numTwo >= numThree && numTwo >= numFour)
            {
                Console.WriteLine($"Number Two is the largest number. The value is {numTwo}");
            }
            if (numThree >= numOne && numThree >= numTwo && numThree >= numFour)
            {
                Console.WriteLine($"Number Three is the largest number. The value is {numThree}");
            }

            if (numFour >= numOne && numFour >= numTwo && numFour >= numThree)
            {
                Console.WriteLine($"Number Four is the largest number. The value is {numFour}");
            }

        }
    }
}
