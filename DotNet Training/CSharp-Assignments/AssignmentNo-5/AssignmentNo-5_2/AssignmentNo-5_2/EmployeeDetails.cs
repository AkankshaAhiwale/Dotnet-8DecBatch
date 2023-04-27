using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentNo_5_2
{
    class EmployeeDetails
    {
        int id;
        string name;
        double sal;
        public EmployeeDetails(int id,
        string name,
        double sal)
        {
            this.id = id;
            this.name = name;
            
            this.sal = sal;
        }

        public override string ToString()
        {
            return "\nID : " + id + "\nName : " + name + "\nSalary : " + sal;
        }
        
    }
}