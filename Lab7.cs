using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne;
            int numTwo;
            int numThree;
           
            Console.WriteLine(" This program will ask you to input three integers. \n It will then find the sum, average, product, and the smallest and largest number in the group. \n \n");
            Console.WriteLine(" Please enter your first number:   ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" \n Please enter your second number:   ");
            numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" \n Please enter your third number:   ");
            numThree = Convert.ToInt32(Console.ReadLine());


            int sum = numOne + numTwo + numThree;
            int average = (numOne + numTwo + numThree) / 3;
            int product = numOne * numTwo * numThree;

            Console.WriteLine("----------Results----------");

            Console.WriteLine($"The sum of the numbers is {sum}");
            Console.WriteLine($"The product of the numbers is {product}");
            Console.WriteLine($"The average of the numbers is {average}");

            if (numOne > numTwo && numOne > numThree)
            {
                Console.WriteLine($"{numOne} is the largest number.");
            }
            if (numTwo > numOne && numTwo > numThree)
            {
                Console.WriteLine($"{numTwo} is the largest number.");
            }
            if (numThree > numOne && numThree > numTwo)
            {
                Console.WriteLine($"{numThree} is the largest number.");
            }


            if (numOne < numTwo && numOne < numThree)
            {
                Console.WriteLine($"{numOne} is the smallest number.");
            }
            if (numTwo < numOne && numTwo < numThree)
            {
                Console.WriteLine($"{numTwo} is the smallest number.");
            }
            if (numThree < numOne && numThree < numTwo)
            {
                Console.WriteLine($"{numThree} is the smallest number.");
            }
        }
    }
}


/*  This program will ask you to input three integers.
 It will then find the sum, average, product, and the smallest and largest number in the group.


 Please enter your first number:
10

 Please enter your second number:
20

 Please enter your third number:
30
----------Results----------
The sum of the numbers is 60
The product of the numbers is 6000
The average of the numbers is 20
30 is the largest number.
10 is the smallest number.
Press any key to continue . . .
*/