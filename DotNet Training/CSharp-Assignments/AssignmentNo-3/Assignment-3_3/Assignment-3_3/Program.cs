using System;

namespace Assignment_3_3
{
    class Program // Q2,Q3,Q4 combined
    {
        static void Main(string[] args)
        {
            int n;
            MyStack ms = new MyStack();
            try
            {
                do
                {
                    Console.WriteLine("Enter your choice : ");
                    Console.WriteLine("1. Push");
                    Console.WriteLine("2. Pop");
                    Console.WriteLine("3. Display");
                    Console.WriteLine("4. Clone");
                    Console.WriteLine("5. Exit");

                    n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Enter elements : ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            ms.push(num);
                            break;

                        case 2:
                            ms.pop();
                            break;

                        case 3:
                            MyStack newstack = ms.clone() as MyStack;
                            newstack.display();
                            break;

                        case 5: break;

                        default:
                            Console.WriteLine("Pls enter a valid choice");
                            break;
                    }
                } while (n != 5);
            }

            catch (StackException s)
            {
                Console.WriteLine(s);
            }
        }
    }
}
