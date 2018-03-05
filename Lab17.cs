using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal priceOne = 2.98M;
            const decimal priceTwo = 4.5M;
            const decimal priceThree = 9.98M;

            decimal productOne = 0M;
            decimal productTwo = 0M;
            decimal productThree = 0M;
            int id = 1;
            int quantity = 0;

            do
            {
                Console.Write("Enter product ID (1-3). Enter 0 to stop: ");
                id = Convert.ToInt32(Console.ReadLine());
                if (id == 0)
                {
                    break;
                }
                Console.Write("Enter quantity sold: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                switch (id)
                {
                    case 1:
                        productOne += priceOne * quantity;
                        break;

                    case 2:
                        productTwo += priceTwo * quantity;
                        break;

                    case 3:
                        productThree += priceThree * quantity;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;

                }
            } while (true);

            Console.WriteLine($"\nProduct 1: {productOne:C}");
            Console.WriteLine($"Product 2: {productTwo:C}");
            Console.WriteLine($"Product 3: {productThree:C}");


        }
    }
}
/*
Enter product ID (1-3). Enter 0 to stop: 1
Enter quantity sold: 100
Enter product ID (1-3). Enter 0 to stop: 2
Enter quantity sold: 200
Enter product ID (1-3). Enter 0 to stop: 1
Enter quantity sold: 50
Enter product ID (1-3). Enter 0 to stop: 3
Enter quantity sold: 10
Enter product ID (1-3). Enter 0 to stop: 1
Enter quantity sold: 100
Enter product ID (1-3). Enter 0 to stop: 0

Product 1: $745.00
Product 2: $900.00
Product 3: $99.80
Press any key to continue . . .
*/
