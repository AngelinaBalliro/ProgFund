using System;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {

            //while loop
            Console.WriteLine("While Loop");
            int x = 0;
            while (x <= 10)
            {
                Console.WriteLine($"Line {x++}");
            }

            //for loop
            Console.WriteLine("\n \nFor Loop");
            for (int z = 0; z <= 10; z++)
            {
                Console.WriteLine($"Line {z}");
            }

            //do while loop
            Console.WriteLine("\n \nDo-While Loop");
            int y = 0;
            do
            {
                Console.WriteLine($"Line {y}");
                y++;
            } while (y <= 10);

            //while loop with modulus
            Console.WriteLine(" \n \n While Loop with Modulus");
            int numStarsToPrint = 100;
            int loopCount = 0;
            while (loopCount < numStarsToPrint)
            {
                if (loopCount % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write("*");
                loopCount++;
            }

            //nested while loop
            Console.WriteLine("\n \n Nested While Loops");
            int StarsToPrint = 10;
            int loop = 0;
            int totalLoops = 10;
            int initialLoop = 0;
            while (initialLoop < totalLoops)
            {
                while (loop < StarsToPrint)
                {
                    Console.Write("*");
                    loop++;
                }
                Console.WriteLine();
                initialLoop++;
                loop = 0;
            }

            //nested for loops
            Console.WriteLine("X with two nested for loops.");
            for (int rows = 1; rows <= 11; rows++)
            {
                for (int col = 1; col <= 11; col++)
                {
                    if (rows == col || col == (11 + 1) - rows)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

/*
 * 
 * While Loop
Line 0
Line 1
Line 2
Line 3
Line 4
Line 5
Line 6
Line 7
Line 8
Line 9
Line 10


For Loop
Line 0
Line 1
Line 2
Line 3
Line 4
Line 5
Line 6
Line 7
Line 8
Line 9
Line 10


Do-While Loop
Line 0
Line 1
Line 2
Line 3
Line 4
Line 5
Line 6
Line 7
Line 8
Line 9
Line 10


 While Loop with Modulus

**********
**********
**********
**********
**********
**********
**********
**********
**********
**********

 Nested While Loops
**********
**********
**********
**********
**********
**********
**********
**********
**********
**********
X with two nested for loops.
*         *
 *       *
  *     *
   *   *
    * *
     *
    * *
   *   *
  *     *
 *       *
*         *
Press any key to continue . . .

 */
