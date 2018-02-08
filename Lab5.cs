using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;

            Console.WriteLine("This program will find the diameter, circumference, and area of a circle, based on a radius.");
            Console.WriteLine("\n \nPlease enter the radius:   ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" \nThe Diameter of the circle is:   ");
            Console.WriteLine(2 * radius);
            Console.WriteLine(" \nThe Circumference of the circle is:   ");
            Console.WriteLine((2 * Math.PI) * radius);
            Console.WriteLine(" \nThe Area of the circle is:   ");
            Console.WriteLine(Math.PI * (radius * radius));


        }
    }
}
