using System;
using System.Collections;

namespace AssignmentNo_5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList arr_list = new ArrayList();
            EmployeeDetails ed;
            int id;
            String name;
            double sal;
            Console.WriteLine("Enter the no of employee objects you want to create : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Id : ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name : ");
                name = Console.ReadLine();

                Console.WriteLine("Enter Salary : ");
                sal = Convert.ToDouble(Console.ReadLine());

                arr_list.Add(ed = new EmployeeDetails(id, name, sal));
            }
            Console.WriteLine("\nThe Employee details are : ");
            foreach(Object o in arr_list)
            {
                Console.WriteLine(o);
            }
            
        }
    }
}
