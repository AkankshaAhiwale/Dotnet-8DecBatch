using System;

namespace Assignment_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any numbers : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The addition of " + a + " and " + b + " is " + (a + b));
            Console.WriteLine("The subtraction of " + a + " and " + b + " is " + (a - b));
            Console.WriteLine("The multiplication of " + a + " and " + b + " is " + (a * b));
            Console.WriteLine("The division of " + a + " and " + b + " is " + (a / b));


        }
    }
}
