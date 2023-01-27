using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanAssitance
{
    public class StackMember<T>
    {
        public T[] arr = new T[100];
        public int top;

        public StackMember()
        {
            top = -1;
        }

        public virtual void Value()
        {
            Array.ForEach(arr, a => {
                Console.WriteLine(a);
            });
        }

        public void pop()
        {
            if (top == -1) { 
                Console.WriteLine("Stack is empty");
                return;
            }
            else if (top == arr.Length - 1) { 
                Console.WriteLine("Stack full");
                return;
            }

            Console.WriteLine(arr[top] + " has removed");

            top -= 1;
        }
        public void push(T data)
        {
            if (isFull())
            {
                Console.WriteLine("Stack full");
                return;
            }
            top += 1;
            arr[top] = data;
            Console.WriteLine(data + " has pushed");
        }

        public bool isFull()
        {
            if (top == arr.Length - 1)
                return true;
            else
                return false;
        }
    }
}
