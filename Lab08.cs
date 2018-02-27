using System;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            
            Console.WriteLine("Number --- Square --- Cube");

            Console.WriteLine($"{x}          {x * x}          {x * x * x}");
            Console.WriteLine($"{++x}          {x * x}          {x * x * x}");
            Console.WriteLine($"{++x}          {x * x}          {x * x * x}");
            Console.WriteLine($"{++x}          {x * x}          {x * x * x}");
            Console.WriteLine($"{++x}          {x * x}         {x * x * x}");
            Console.WriteLine($"{++x}          {x * x}         {x * x * x}");
            Console.WriteLine($"{++x}          {x * x}         {x * x * x}");
            Console.WriteLine($"{++x}          {x * x}         {x * x * x}");
            Console.WriteLine($"{++x}          {x * x}         {x * x * x}");
            Console.WriteLine($"{++x}          {x * x}         {x * x * x}");
            Console.WriteLine($"{++x}         {x * x}        {x * x * x}");
        }
    }
}
/*
 Number --- Square --- Cube
0          0          0
1          1          1
2          4          8
3          9          27
4          16         64
5          25         125
6          36         216
7          49         343
8          64         512
9          81         729
10         100        1000
Press any key to continue . . .

 */
