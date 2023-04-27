using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_5
{
    class Employee_List
    {
        int id;
        string name;
        double sal;

        public Employee_List(int id,string name,double sal)
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
