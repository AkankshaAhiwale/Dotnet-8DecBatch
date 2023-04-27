using System;

namespace Assignment_1_5
{
    class Program
    {
        public static void Result(double r)
        {
            Console.WriteLine("The area of circle is : " + (3.14 * r * r));
            Console.WriteLine("The circumference of circle is : " + (2 * 3.14 * r));

        }

        static void Main(string[] args)
        {
            double r;
            Console.WriteLine("Enter the value of radius : ");
            r = Convert.ToDouble(Console.ReadLine());
            Result(r);

        }
    }
}
