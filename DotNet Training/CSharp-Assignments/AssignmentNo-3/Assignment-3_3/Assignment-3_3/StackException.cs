using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_3
{
    interface Icloneable
    {
    }

    public class StackException : Exception
    {
        public StackException(string message) : base(message)
        {

        }
    }
    public class MyStack : Icloneable
    {
        private int[] arr = new int[20];
        private int top = -1;
        private int size;

        public object clone()
        {
            Console.WriteLine("Cloned Array");
            MyStack stack_element = new MyStack
            {
                arr = this.arr,
                top = this.top,
                size = this.size
            };
            return stack_element;
        }
        public int SIZE
        {
            get { return size; }
            set
            {
                this.size = arr.Length;
            }
        }
        public void push(int a)
        {
            try
            {
                if (top == arr.Length - 1)
                {
                    throw new StackException("Stack Overflow");
                }
                arr[++top] = a;
                Console.WriteLine("\nPushed {a} in to the stack");
            }
            catch (StackException e)
            {
                Console.WriteLine(e);
            }
        }
        public void pop()
        {
            try
            {
                if (top == -1)
                {
                    throw new StackException("Stack underflow");
                }
                Console.WriteLine("\n {a} popped from the stack");
                arr[top--] = 0;
            }
            catch (StackException e)
            {
                Console.WriteLine(e);
            }
        }
        public void display()
        {
            Console.WriteLine("The Stack elements are : ");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}

