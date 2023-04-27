using System;

namespace Assignment_2_1
{
    class Program // Q2 and Q3 combined
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter ID : ");
                int id = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("Enter name : ");
                string name = Console.ReadLine();

                System.Console.WriteLine("Enter salary : ");
                double sal = Convert.ToDouble(Console.ReadLine());
                if (id == 0 || name.Equals(null) || sal <= 0)
                {
                    System.Console.WriteLine("Pls check the values");
                }
                else
                {
                    Employee e = new Employee(id, name, sal);
                    e.CalculateSalary();
                    e.displayDetails();
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }
    }
}
