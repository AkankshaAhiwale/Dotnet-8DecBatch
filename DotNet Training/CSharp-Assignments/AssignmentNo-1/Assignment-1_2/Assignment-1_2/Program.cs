using System;

namespace Assignment_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1, m2, m3, m4, m5;
            Console.WriteLine("Enter marks : ");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            m4 = Convert.ToInt32(Console.ReadLine());
            m5 = Convert.ToInt32(Console.ReadLine());

            if (m1 > m2 && m1 > m3 && m1 > m4 && m1 > m5)
            {
                Console.WriteLine(m1 + " are the highest marks");
            }
            else if (m2 > m3 && m2 > m4 && m2 > m5)
            {
                Console.WriteLine(m2 + " are the highest marks");
            }
            else if (m3 > m4 && m3 > m5)
            {
                Console.WriteLine(m3 + " are the highest marks");
            }
            else if (m4 > m5)
            {
                Console.WriteLine(m4 + " are the highest marks");
            }
            else
            {
                Console.WriteLine(m5 + " are the highest marks");
            }

        }
    }
}
