using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program will print out declared values of different varibles. \nThen it will print out values inputted by the user that overwrite the declared values. \n \n");


            //declaring and initializing all of the data type variables.
            int myInt = 10;
            short myShort = 5;
            long myLong = 20;
            byte myByte = 127;
            float myFloat = 44.44F;
            double myDouble = 3.333;
            decimal myDecimal = 555.55M;
            char myChar = 'y';
            bool myBool = true;
            string myString = "Good Morning";

            //printing out the variables that were initialized and declared above.
            Console.WriteLine("These are the original values. \n");
            Console.WriteLine("The int = {0}",myInt);
            Console.WriteLine("The short = {0}", myShort);
            Console.WriteLine("The long = {0}", myLong);
            Console.WriteLine("The byte = {0}", myByte);
            Console.WriteLine("The float = {0}", myFloat);
            Console.WriteLine("The double = {0}", myDouble);
            Console.WriteLine("The decimal = {0}", myDecimal);
            Console.WriteLine("The char = {0}", myChar);
            Console.WriteLine("The bool = {0}", myBool);
            Console.WriteLine("The string = {0}", myString);

            Console.WriteLine("\n Now it's your turn to enter values for the variables.");
            //prompt user, read user's input, convert it to the data type.
            Console.Write(" \n \n Please enter a value for Int: ");
            myInt = Convert.ToInt32(Console.ReadLine()); 

            Console.Write(" \n Please enter a value for Short: ");
            myShort = Convert.ToInt16(Console.ReadLine());

            Console.Write(" \n Please enter a value for Long: ");
            myLong = Convert.ToInt64(Console.ReadLine());

            Console.Write(" \n Please enter a value for Byte: ");
            myByte = Convert.ToByte(Console.ReadLine());

            Console.Write(" \n Please enter a value for Float: ");
            myFloat = Convert.ToSingle(Console.ReadLine());

            Console.Write("\n Please enter a value for Double: ");
            myDouble = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Please enter a value for Decimal: ");
            myDecimal = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n Please enter a value for Char: ");
            myChar = Convert.ToChar(Console.ReadLine());

            Console.Write("\n Please enter a value for Bool. (true or false): ");
            myBool = Convert.ToBoolean(Console.ReadLine());

            Console.Write("\n Please enter a calue for string: ");
            myString = Convert.ToString(Console.ReadLine());

            // Printing out the new values
            Console.WriteLine("\n \n The new values are displayed below. \n");

            Console.WriteLine("The int = {0}", myInt);
            Console.WriteLine("The short = {0}", myShort);
            Console.WriteLine("The long = {0}", myLong);
            Console.WriteLine("The byte = {0}", myByte);
            Console.WriteLine("The float = {0}", myFloat);
            Console.WriteLine("The double = {0}", myDouble);
            Console.WriteLine("The decimal = {0}", myDecimal);
            Console.WriteLine("The char = {0}", myChar);
            Console.WriteLine("The bool = {0}", myBool);
            Console.WriteLine("The string = {0}", myString);

        }
    }
}

/*
 This program will print out declared values of different varibles.
Then it will print out values inputted by the user that overwrite the declared values.


These are the original values.

The int = 10
The short = 5
The long = 20
The byte = 127
The float = 44.44
The double = 3.333
The decimal = 555.55
The char = y
The bool = True
The string = Good Morning

Now it's your turn to enter values for the variables


 Please enter a value for Int: 31

 Please enter a value for Short: 15

 Please enter a value for Long: 20125

 Please enter a value for Byte: 33

 Please enter a value for Float: 45.79

 Please enter a value for Double: 3014.678

 Please enter a value for Decimal: 44.99

 Please enter a value for Char: M

 Please enter a value for Bool. (true or false): false

 Please enter a calue for string: Book


 The new values are displayed below.

The int = 31
The short = 15
The long = 20125
The byte = 33
The float = 45.79
The double = 3014.678
The decimal = 44.99
The char = M
The bool = False
The string = Book
Press any key to continue . . .
*/
