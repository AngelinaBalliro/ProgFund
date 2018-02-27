using System;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Calculator.DisplayMenu();
            }
            while (Calculator.GetSelection() != 6);
        }
    }
     class Calculator { 
        public static void DisplayMenu()
        {
            Console.WriteLine("\n Menu:\n \t 1. Add \n \t 2. Subtract \n \t 3. Multiply \n \t 4. Divide \n \t 5. Modulus \n \t 6. Quit");  
        }
        public static int Add(int numOne, int numTwo)
        {
            Console.Write("Enter the first number: ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numTwo = Convert.ToInt32(Console.ReadLine());
            int sum = numOne + numTwo;
            Console.WriteLine($" \nResult is {sum} \n {numOne} + {numTwo} = {sum} ");
            return sum;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            Console.Write("Enter the first number: ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numTwo = Convert.ToInt32(Console.ReadLine());
            int diff = numOne - numTwo;
            Console.WriteLine($" \nResult is {diff} \n {numOne} - {numTwo} = {diff} ");
            return diff;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            Console.Write("Enter the first number: ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numTwo = Convert.ToInt32(Console.ReadLine());
            int product = numOne * numTwo;
            Console.WriteLine($" \nResult is {product} \n {numOne} * {numTwo} = {product} ");
            return product;
        }

        public static int Divide(int numOne, int numTwo)
        {
            Console.Write("Enter the first number: ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numTwo = Convert.ToInt32(Console.ReadLine());
            int dividend = numOne / numTwo;
            Console.WriteLine($" \nResult is {dividend} \n {numOne} / {numTwo} = {dividend} ");
            return dividend;

        }

        public static int Modulus(int numOne, int numTwo)
        {
            Console.Write("Enter the first number: ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numTwo = Convert.ToInt32(Console.ReadLine());
            int mod = numOne % numTwo;
            Console.WriteLine($" \nResult is {mod} \n {numOne} % {numTwo} = {mod} ");
            return mod;
        }
        public static int GetSelection()
        {
            Console.Write("Please enter a number(1-6) based on the options in the menu: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;
            if(choice == 1)
            {
               Calculator.Add(a,b);
            }
            if (choice == 2)
            {
                Calculator.Subtract(a,b);
            }
            if (choice == 3)
            {
                Calculator.Multiply(a,b);
            }
            if (choice == 4)
            {
                Calculator.Divide(a,b);
            }
            if (choice == 5)
            {
                Calculator.Modulus(a,b);
            }
            if (choice == 6)
            {
                Console.WriteLine("Thanks for using the calculator, goodbye!");
            }
            return choice;
        }
    }
}
/*
 Menu:
         1. Add
         2. Subtract
         3. Multiply
         4. Divide
         5. Modulus
         6. Quit
Please enter a number(1-6) based on the options in the menu: 1
Enter the first number: 10
Enter the second number: 4

Result is 14
 10 + 4 = 14

 Menu:
         1. Add
         2. Subtract
         3. Multiply
         4. Divide
         5. Modulus
         6. Quit
Please enter a number(1-6) based on the options in the menu: 6
Thanks for using the calculator, goodbye!
Press any key to continue . . .

 */
