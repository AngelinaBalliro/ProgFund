using System;

namespace Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int wrong = 0;

            Q1();
            input = Convert.ToInt32(Console.ReadLine());
            if (!Check(input, 1))
            {
                Console.WriteLine("Incorrect!");
                wrong++;
            }
            else
            {
                Console.WriteLine("Correct!");
            }
            Q2();
            input = Convert.ToInt32(Console.ReadLine());
            if (!Check(input, 2))
            {
                Console.WriteLine("Inorrect!");
                wrong++;
            }
            else
            {
                Console.WriteLine("Correct!");
            }
            Q3();
            input = Convert.ToInt32(Console.ReadLine());
            if (!Check(input, 3))
            {
                Console.WriteLine("Inorrect!");
                wrong++;
            }
            else
            {
                Console.WriteLine("Correct!");
            }
            Q4();
            input = Convert.ToInt32(Console.ReadLine());
            if (!Check(input, 4))
            {
                Console.WriteLine("Inorrect!");
                wrong++;
            }
            else
            {
                Console.WriteLine("Correct!");
            }

            Q5();
            input = Convert.ToInt32(Console.ReadLine());
            if (!Check(input, 5))
            {
                Console.WriteLine("Inorrect!");
                wrong++;
            }
            else
            {
                Console.WriteLine("Correct!");
            }

            switch (wrong)
            {
                case 0:
                    Console.WriteLine($"\nExcelent! You got all the answers right!");
                    break;
                case 1:
                    Console.WriteLine($"\nGood Job!");
                    break;
                default:
                    Console.WriteLine(" \n \nTime to brush up on your knowledge of global warming: ");
                    Console.WriteLine("http://news.nationalgeographic.com/news/2004/12/1206_041206_global_warming.html");
                    Console.WriteLine("http://lwf.ncdc.noaa.gov/oa/climate/gases.html");
                    Console.WriteLine("http://globalwarming-facts.info/50-tips.html");
                    break;
            }
        }

        static bool Check(int input, int questionid)
        {
            int answer = 0;

            switch (questionid)
            {
                case 1:
                    answer = 2;
                    break;
                case 2:
                    answer = 4;
                    break;
                case 3:
                    answer = 1;
                    break;
                case 4:
                    answer = 4;
                    break;
                case 5:
                    answer = 1;
                    break;
            }
            return (input == answer);
        }
        static void Q1() 
        {
            Console.WriteLine("Question One");
            Console.WriteLine("By how much have average temperatures risen since 1880?");
            Console.WriteLine("1: 0.4 degrees F");
            Console.WriteLine("2: 1.4 degrees F");
            Console.WriteLine("3: 2.4 degrees F");
            Console.WriteLine("4: 3.4 degrees F");
            Console.Write("\nSelect: ");
        }
        static void Q2() 
        {
            Console.WriteLine("\nQuestion Two");
            Console.WriteLine("Montana's Glacier National Park had 150 glaciers in 1910. \nHow many does it have now ?");
            Console.WriteLine("1: 0");
            Console.WriteLine("2: 7");
            Console.WriteLine("3: 17");
            Console.WriteLine("4: 27");
            Console.Write("\nSelect: ");
        }
        static void Q3() 
        {
            Console.WriteLine("\nQuestion Three");
            Console.WriteLine("What is the most abundant greenhouse gas?");
            Console.WriteLine("1: Water Vapor");
            Console.WriteLine("2: Carbon Dioxide");
            Console.WriteLine("3: Methane");
            Console.WriteLine("4: Carbon Monoxide");
            Console.Write("\nSelect: ");
        }
        static void Q4() 
        {
            Console.WriteLine("\nQuestion Four");
            Console.WriteLine("Which of these should you NOT do to help stop global warming?");
            Console.WriteLine("1: Use less hot water");
            Console.WriteLine("2: Reuse your shopping bag");
            Console.WriteLine("3: Plant a tree");
            Console.WriteLine("4: Take a bath instead of a shower");
            Console.Write("\nSelect: ");
        }
        static void Q5() 
        {
            Console.WriteLine("\nQuestion Five");
            Console.WriteLine("Which of these should you NOT to do help stop global warming?");
            Console.WriteLine("1: Buy more frozen foods");
            Console.WriteLine("2: Fly less");
            Console.WriteLine("3: Use a clothesline instead of a dryer");
            Console.WriteLine("4: Cover pots while cooking");
            Console.Write("\nSelect: ");
        }
    }
}

