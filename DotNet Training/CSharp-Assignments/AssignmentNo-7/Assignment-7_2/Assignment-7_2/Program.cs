using System;
using System.IO;
namespace Assignment_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\AAHIWALE\source\repos\Assignment-7_2\CustomerAccountDetails.txt";
            
            Console.WriteLine("Enter Customer Details....");
            Console.WriteLine("\nEnter Account Number:");
            int Acc_Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Customer Name:");
            string Customer_Name = Console.ReadLine();

            Console.WriteLine("\nEnter Balance:");
            int Balance = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write("Customer Name:" + Customer_Name + "\nAccount Number:" + Acc_Number + "\nBalance:" + Balance);
            }
            Console.WriteLine("The customer's account details are Saved");



            Console.WriteLine("\n\nReading Text File:::");
            using (StreamReader reader = new StreamReader(path))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
