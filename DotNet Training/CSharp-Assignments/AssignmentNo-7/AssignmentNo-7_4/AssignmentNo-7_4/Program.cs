using Assignment_7_4;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AssignmentNo_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Id:");
            int emp_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Employee Name");
            String emp_nm = Console.ReadLine();

            Console.WriteLine("\nEnter Employee Salary");
            int sal = Convert.ToInt32(Console.ReadLine());
            string path = @"C:\Users\AAHIWALE\source\repos\AssignmentNo-7_4\EmployeeDetails.txt";
            
            Employee emp = new Employee(emp_id, emp_nm, sal);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();


            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine("\nFile Created Successfully -> " + path);


            FileStream stream1 = new FileStream(path, FileMode.Open, FileAccess.Read);
            Employee emp_obj = (Employee)bf.Deserialize(stream1);

            Console.WriteLine("\nThe Employee details are : \n");
            Console.WriteLine(emp_obj.id);
            Console.WriteLine(emp_obj.name);
            Console.WriteLine(emp_obj.salary);
        }
    }
}
