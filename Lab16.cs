using System;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_NUM = 5;
            int factorial = 1;
            Console.WriteLine("Calculating the factorial of 20 could prove difficult because it would be an extremely large number, \nand an int wouldn't be able to hold that value. \n \n");
            Console.WriteLine("n     n!");
            Console.WriteLine("--------");

            for (int x = 1; x <= MAX_NUM; x++)
            {
                factorial*=x;
                Console.WriteLine($"{x}      {factorial}");
            }
        }
    }
}

/*
 Calculating the factorial of 20 could prove difficult because it would be an extremely large number,
and an int wouldn't be able to hold that value.


n     n!
--------
1      1
2      2
3      6
4      24
5      120
Press any key to continue . . .     
*/
