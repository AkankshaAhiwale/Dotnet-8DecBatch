using System;

namespace AssignmentNo_5
{
    class Program
    {
        
        static void print_s(string[] str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i] + " ");
            }

        }
        static void print_n(int[] num)
        {
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i] + " ");

            }       
        }

        public static void Main(String[] args)
        {
            
            int[] n = new int[5];
            string[] str = new string[5];
            int val_num = 0;
            Console.WriteLine("Enter the integer values : ");
            for(int i = 0; i <5; i++)
            {
                val_num = Convert.ToInt32(Console.ReadLine());
                n[i] = val_num;
            }
            string val_str;
            Console.WriteLine("Enter the string values : ");
            for(int i = 0; i < 5; i++)
            {
                val_str = Console.ReadLine();
                str[i] = val_str;
            }
            int[] copy_int = new int[10];
            string[] copy_str = new string[10];
            Array.Copy(n, copy_int, n.Length);
            Array.Copy(str, copy_str, str.Length);
            Console.WriteLine("\nThe copied elements of integer and string array : ");
            print_n(n);
            print_s(str);
            Console.WriteLine(n);
            Console.WriteLine(str);


            Array.Sort(n);
            Array.Sort(str);
            Console.WriteLine("\nThe integer and string array elements after sorting : ");
            print_n(n);
            print_s(str);

            Array.Reverse(n);
            Array.Reverse(str);
            Console.WriteLine("\nAfter reversing the array elements : ");
            print_n(n);
            print_s(str);


            Array.Clear(n, 0, n.Length);
            Array.Clear(str, 0, str.Length);
            Console.WriteLine("\nThe empty array : ");
            print_n(n);
            print_s(str);
        }
    }
}
