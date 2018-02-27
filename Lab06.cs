using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==, !=. <, >,<=, >=
            Console.WriteLine("This program will have you enter two numbers and then displays a comparison of the numbers. \n \n");
            Console.WriteLine("Please enter the first number:  ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:  ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2){
                Console.WriteLine($"{num1} = {num2}");
            }
            if (num1 != num2){
                Console.WriteLine($"{num1} != {num2}");
            }
            if(num1 < num2){
                Console.WriteLine($"{num1} < {num2}");
            }
            if (num1 > num2){
                Console.WriteLine($"{num1} > {num2}");
            }
            if (num1 <= num2){
                Console.WriteLine($"{num1} <= {num2}");
            }
            if (num1 <= num2){
                Console.WriteLine($"{num1} >= {num2}");
            }
        }
    }
}
