using System;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                int input, temp;
                DisplayMenu();
                input = GetSelection();
                input = ValidateSelection(input);
                temp = GetTemperatureToConvert(input);
                DoConversion(input, temp);
            }
        }

        private static int ValidateSelection(int sel)
        {
            if (sel > 0 && sel < 3)
            {
                return sel;
            }
            else if (sel == 3)
            {
                Environment.Exit(0);
                return -1;
            }
            else
            {
                Console.WriteLine("Invalid Selection...");
                DisplayMenu();
                return ValidateSelection(GetSelection());
            }
        }

        private static int GetSelection()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Temperature Conversion Menu");
            Console.WriteLine("\t 1. Farenheit to Celsius");
            Console.WriteLine("\t 2. Celsius to Farenheit");
            Console.WriteLine("\t 3. Exit");
            Console.WriteLine("------------------------------");
            Console.Write("\n\t Enter Choice: ");
        }

        private static int GetTemperatureToConvert(int sel)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (sel)
            {
                case 1:
                    Console.Write("\nEnter Farenheit temperature: ");
                    break;
                case 2:
                    Console.Write("\nEnter Celsius temperature: ");
                    break;
            }
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void DoConversion(int sel, int temp2Convert)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            switch (sel)
            {
                case 1:
                    Console.WriteLine($"\n{temp2Convert} Farenheit is {FarenheitToCelsius(temp2Convert):0} Celsius \n");
                    break;
                case 2:
                    Console.WriteLine($"\n{temp2Convert} Celsius is {CelsiusToFarenheit(temp2Convert):0} Farenheit \n");
                    break;
            }
        }
        static double CelsiusToFarenheit(double c) => ((9.0 / 5.0) * c) + 32;
        static double FarenheitToCelsius(double f) => ((f - 32) * (5.0 / 9.0));
    }
}

/*
 Temperature Conversion Menu
         1. Farenheit to Celsius
         2. Celsius to Farenheit
         3. Exit
------------------------------

         Enter Choice: 1

Enter Farenheit temperature: 75

75 Farenheit is 24 Celsius

Temperature Conversion Menu
         1. Farenheit to Celsius
         2. Celsius to Farenheit
         3. Exit
------------------------------

         Enter Choice: 2

Enter Celsius temperature: 24

24 Celsius is 75 Farenheit

Temperature Conversion Menu
         1. Farenheit to Celsius
         2. Celsius to Farenheit
         3. Exit
------------------------------

         Enter Choice: 3
Press any key to continue . . .
     
*/
