using System;
using System.Collections.Generic;
namespace Assignment_5_3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Employee> ll = new List<Employee>();
            do
            {
                Console.WriteLine("\n1. Add element to the list.");
                Console.WriteLine("2. Display the employee list");
                Console.WriteLine("3. Count the total no. of employees");
                Console.WriteLine("4. Search an employee ");
                Console.WriteLine("5. Exit");

                Console.WriteLine("\nPls enter your choice: ");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter the number of employees : ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("\nEnter employee id : ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter employee name : ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Enter employee salary : ");
                            double sal = Convert.ToDouble(Console.ReadLine());

                            ll.Add(new Employee(id, name, sal));
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nThe Employee Details are : ");
                        foreach (object o in ll)
                        {
                            Console.WriteLine(o);
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nThe total number of employees in the linked list : " + ll.Count);
                        break;
                    case 4:
                        Console.WriteLine("\nEnter the name you want to search : ");
                        string input = Console.ReadLine();
                        bool search = false;
                        foreach (Employee s in ll)
                        {
                            if (s.e_name.Equals(input))
                            {
                                search = true;
                            }
                            else
                            {
                                search = false;
                            }
                        }
                        if (search == true)
                        {
                            Console.WriteLine("Record Found");
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found");
                        }
                        break;
                    case 5: break;

                    default:
                        Console.WriteLine("Pls enter the right choice");
                        break;
                }
            } while (true);
        }
    }
}
