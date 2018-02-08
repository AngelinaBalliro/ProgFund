using System;
namespace Lab_10b
{
    class Program
    {
        static void Main(string[] args)
        {

            int grade;
            do
            {
                Console.Write("Please enter a grade. Type -1 to quit.");
                grade = Convert.ToInt32(Console.ReadLine());

                switch (grade / 10)
                {

                    case 10:
                        Console.WriteLine("You got an A");
                        break;
                    case 9:
                        Console.WriteLine("You got an A");
                        break;
                    case 8:
                        Console.WriteLine("You got a B");
                        break;
                    case 7:
                        Console.WriteLine("You got a C");
                        break;
                    case 6:
                        Console.WriteLine("You got a D");
                        break;
                    case 5:
                        Console.WriteLine("You got a F");
                        break;
                    case 4:
                        Console.WriteLine("You got a F");
                        break;
                    case 3:
                        Console.WriteLine("You got a F");
                        break;
                    case 2:
                        Console.WriteLine("You got a F");
                        break;
                    case 1:
                        Console.WriteLine("You got a F");
                        break;
                    default:
                        Console.WriteLine("Goodbye!");
                        break;
                }

            }
            while (grade != -1);


        }
    }
}
/*
Please enter a grade. Type -1 to quit.22
You got a F
Please enter a grade. Type -1 to quit.67
You got a D
Please enter a grade. Type -1 to quit.75
You got a C
Please enter a grade. Type -1 to quit.86
You got a B
Please enter a grade. Type -1 to quit.92
You got an A
Please enter a grade. Type -1 to quit.-1
Goodbye!
Press any key to continue . . .
 */
