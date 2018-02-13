using System;


namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal principal = 10000M;



            for (int interestRates = 5; interestRates <= 10; interestRates++)
            {
                double rate = interestRates / 100.00;
                Console.WriteLine("interest Rate: {0}.00% on amount ${1}", rate * 100, principal);
                   for (int years = 1; years <= 10; years++)
                   {
                    decimal newAmount = principal * ((decimal)Math.Pow(1.0 + rate, years));
                    Console.WriteLine("{0}\t{1:C}", years, newAmount);
                   }
                Console.WriteLine();
            }



        }
    }
}

/*
 interest Rate: 5.00% on amount $10000
1       $10,500.00
2       $11,025.00
3       $11,576.25
4       $12,155.06
5       $12,762.82
6       $13,400.96
7       $14,071.00
8       $14,774.55
9       $15,513.28
10      $16,288.95

interest Rate: 6.00% on amount $10000
1       $10,600.00
2       $11,236.00
3       $11,910.16
4       $12,624.77
5       $13,382.26
6       $14,185.19
7       $15,036.30
8       $15,938.48
9       $16,894.79
10      $17,908.48

interest Rate: 7.00% on amount $10000
1       $10,700.00
2       $11,449.00
3       $12,250.43
4       $13,107.96
5       $14,025.52
6       $15,007.30
7       $16,057.81
8       $17,181.86
9       $18,384.59
10      $19,671.51

interest Rate: 8.00% on amount $10000
1       $10,800.00
2       $11,664.00
3       $12,597.12
4       $13,604.89
5       $14,693.28
6       $15,868.74
7       $17,138.24
8       $18,509.30
9       $19,990.05
10      $21,589.25

interest Rate: 9.00% on amount $10000
1       $10,900.00
2       $11,881.00
3       $12,950.29
4       $14,115.82
5       $15,386.24
6       $16,771.00
7       $18,280.39
8       $19,925.63
9       $21,718.93
10      $23,673.64

interest Rate: 10.00% on amount $10000
1       $11,000.00
2       $12,100.00
3       $13,310.00
4       $14,641.00
5       $16,105.10
6       $17,715.61
7       $19,487.17
8       $21,435.89
9       $23,579.48
10      $25,937.42

Press any key to continue . . .
*/