using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne;
            int numTwo;
            Console.WriteLine("This program will add, subtract, multiply, and find the remainder of two numbers.");
            Console.WriteLine("\n \n Please enter the first number. This number must be the larger of the two:   ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n \n Now please enter the second number:   ");
            numTwo = Convert.ToInt32(Console.ReadLine());

            //math

            int sum = numOne + numTwo;
            int difference = numOne - numTwo;
            int product = numOne * numTwo;
            int quotient = numOne / numTwo;
            int remainder = numOne % numTwo;

            //results

            Console.WriteLine(" ----Results----");
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The difference is " + difference);
            Console.WriteLine("The product is " + product);
            Console.WriteLine("The quotient is " + quotient);
            Console.WriteLine("The remainder is " + remainder);
        }
    }
}
/* This program will add, subtract, multiply, and find the remainder of two numbers.


 Please enter the first number. This number must be the larger of the two:
45


 Now please enter the second number:
5
 ----Results----
The sum is 50
The difference is 40
The product is 225
The quotient is 9
The remainder is 0
Press any key to continue . . .


This program will add, subtract, multiply, and find the remainder of two numbers.


 Please enter the first number. This number must be the larger of the two:
91


 Now please enter the second number:
3
 ----Results----
The sum is 94
The difference is 88
The product is 273
The quotient is 30
The remainder is 1
Press any key to continue . . .
*/
