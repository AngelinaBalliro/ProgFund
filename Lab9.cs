using System;
namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)

        { 
            Console.WriteLine("This program is a BMI calculator and will tell you your BMI. \n \n ");

            Console.Write("Please enter your weight in pounds:");
            int weight;
            weight = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \nPlease enter your height in inches:");
            int height;
            height = Convert.ToInt32(Console.ReadLine());

            int bmi;
            bmi = (weight * 703) / (height * height);

            Console.WriteLine($" \n \n Your BMI is {bmi}");


            Console.WriteLine("\n \n BMI Value Table: \n" +
                "Underweight: Less than 18.5 \n" +
                "Normal: Between 18.5 and 24.9 \n" +
                "Overweight: Between 25 and 29.9 \n" +
                "Obese: 30 or greater");

        }
    }
}
/*
This program is a BMI calculator and will tell you your BMI.


Please enter your weight in pounds:165

Please enter your height in inches:69


 Your BMI is 24


 BMI Value Table:
Underweight: Less than 18.5
Normal: Between 18.5 and 24.9
Overweight: Between 25 and 29.9
Obese: 30 or greater
Press any key to continue . . .
*/