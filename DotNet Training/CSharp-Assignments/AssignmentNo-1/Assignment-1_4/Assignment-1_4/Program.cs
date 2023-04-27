using System;

namespace Assignment_1_4
{
    class Program
    {
        static void swapno_method()
        {
            Console.WriteLine("Enter any two numbers : ");
            int a, b, temp;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping, the numbers are :"
            + a + "\t" + b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping, the numbers are : " + a + "\t" + b);
        }
            static void Main(string[] args)
        {
            swapno_method();
        }
    }
}
