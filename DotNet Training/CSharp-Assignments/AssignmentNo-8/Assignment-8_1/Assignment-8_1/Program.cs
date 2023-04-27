using System;
using System.Reflection;
namespace Assignment_8_1
{
    public class Reflection
    {
        public string fullName(string firstName, string lastName)
        {
            string fullname = firstName + " " + lastName;
            return fullname;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type reflectionType = executingAssembly.GetType("Assignment_8_1.Reflection");
            object fname = Activator.CreateInstance(reflectionType);
            MethodInfo addString = reflectionType.GetMethod("fullName");
            Console.WriteLine($"Type: {reflectionType}");
            MethodInfo[] methods = reflectionType.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + "  " + method.Name);
            }


            string[] str = new string[2];
            str[0] = "Akanksha";
            str[1] = "Ahiwale";


            string res = (string)addString.Invoke(fname, str);
            Console.WriteLine($"Full Name is = {res}");


        }
        }
    }
