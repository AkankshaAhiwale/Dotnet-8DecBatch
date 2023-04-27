using System;
using System.Collections.Generic;

namespace Assignment_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee_List> l = new List<Employee_List>();
            Employee_List el;
            bool isExist = false;
            Console.WriteLine("Enter the number of employees : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter employee id : ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter employee name : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter employee salary : ");
                double sal = Convert.ToDouble(Console.ReadLine());

                l.Add(el = new Employee_List(id,name,sal));
            }
            string search_name = Console.ReadLine();

            if (isExist == true)
            {

            }
            
        }
    }
}
