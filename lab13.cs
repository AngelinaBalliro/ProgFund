using System;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal principle = 0M;
            double interestRate = 0;
            int nTimes = 0;
            int years = 0;
            decimal newAmount = 0M;

            Console.Write("Enter Principle amount: ");
            principle = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the Interest Rate: ");
            interestRate = double.Parse(Console.ReadLine());
            Console.Write("Enter number of years invested ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of times per year that the interest is compounded (2, 4, or 12): ");
            nTimes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n \n \n");



            Console.WriteLine("Intrest rate: {0} on amount ${1}", interestRate , principle);
            Console.WriteLine("Year\tCurrent Balance");

            for (int loop = 0; loop < years; loop++)
            {
                newAmount = principle * (decimal)Math.Pow((1 + ((interestRate / 100) / nTimes)), (1 * nTimes));
                principle = newAmount;
                Console.WriteLine("{0}\t{1:C}", loop + 1, principle);
            }
        }
    }
}


/*
 Enter Principle amount: 10000
Enter the Interest Rate: 3.5
Enter number of years invested 10
Enter number of times per year that the interest is compounded (2, 4, or 12): 2




Intrest rate: 3.5 on amount $10000
Year    Current Balance
1       $10,353.06
2       $10,718.59
3       $11,097.02
4       $11,488.82
5       $11,894.44
6       $12,314.39
7       $12,749.17
8       $13,199.29
9       $13,665.31
10      $14,147.78
Press any key to continue . . .
*/