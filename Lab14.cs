using System;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;
            do
            {
                Console.Write($"Please enter a grade. Enter -1 to quit. ");
                grade = Convert.ToInt32(Console.ReadLine());
                switch (grade)
                {
                    case int input when (input >= 97 && input <= 100):
                        Console.WriteLine("Grade is A+");
                        break;
                    case int input when (input >= 93 && input <= 96):
                        Console.WriteLine("Grade is A");
                        break;
                    case int input when (input >= 90 && input <= 92):
                        Console.WriteLine("Grade is A-");
                        break;
                    case int input when (input >= 87 && input <= 89):
                        Console.WriteLine("Grade is B+");
                        break;
                    case int input when (input >= 83 && input <= 86):
                        Console.WriteLine("Grade is B");
                        break;
                    case int input when (input >= 80 && input <= 82):
                        Console.WriteLine("Grade is B-");
                        break;
                    case int input when (input >= 77 && input <= 79):
                        Console.WriteLine("Grade is C+");
                        break;
                    case int input when (input >= 73 && input <= 76):
                        Console.WriteLine("Grade is C");
                        break;
                    case int input when (input >= 70 && input <= 72):
                        Console.WriteLine("Grade is C-");
                        break;
                    case int input when (input >= 67 && input <= 69):
                        Console.WriteLine("Grade is D+");
                        break;
                    case int input when (input >= 63 && input <= 66):
                        Console.WriteLine("Grade is D");
                        break;
                    case int input when (input >= 60 && input <= 62):
                        Console.WriteLine("Grade is D-");
                        break;
                    case int input when (input >= 0 && input <= 59):
                        Console.WriteLine("Grade is F");
                        break;
                    case -1:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Grade is not valid!");
                        break;
                }
            }
            while (grade != -1);
        }
    }
}
/*
Please enter a grade. Enter -1 to quit. 100
Grade is A+
Please enter a grade. Enter -1 to quit. 92
Grade is A-
Please enter a grade. Enter -1 to quit. 89
Grade is B+
Please enter a grade. Enter -1 to quit. 81
Grade is B-
Please enter a grade. Enter -1 to quit. 77
Grade is C+
Please enter a grade. Enter -1 to quit. 75
Grade is C
Please enter a grade. Enter -1 to quit. 66
Grade is D
Please enter a grade. Enter -1 to quit. 0
Grade is F
Please enter a grade. Enter -1 to quit. 200
Grade is not valid!
Please enter a grade. Enter -1 to quit. -1
Goodbye!
Press any key to continue . . .

*/