using System;

namespace Lab_10a
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

                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("The letter grade is an A.");
                }

                if (grade >= 80 && grade <= 89)
                {
                    Console.WriteLine("The letter grade is a B.");
                }

                if (grade >= 70 && grade <= 79)
                {
                    Console.WriteLine("The letter grade is a C.");
                }

                if (grade >= 60 && grade <= 69)
                {
                    Console.WriteLine("The letter grade is a D.");
                }

                if (grade >= 0 && grade <= 59)
                {
                    Console.WriteLine("The letter grade is a F.");
                }
                else
                {
                    Console.WriteLine("Goodbye");
                }

            }
            while (grade != -1); 
        }
    }
}

/*
Please enter a grade. Type -1 to quit.22
The letter grade is a F.
Please enter a grade. Type -1 to quit.67
The letter grade is a D.
Goodbye
Please enter a grade. Type -1 to quit.75
The letter grade is a C.
Goodbye
Please enter a grade. Type -1 to quit.86
The letter grade is a B.
Goodbye
Please enter a grade. Type -1 to quit.92
The letter grade is an A.
Goodbye
Please enter a grade. Type -1 to quit.-1
Goodbye
Press any key to continue . . .
*/