using LinkedListProblem.UnorderedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList.UnorderedList.LinkedListStack
{
    public class LinkedListStack<T>
    {
        internal Node<T> top;
        public LinkedListStack()
        {
            top = null;
        }
        internal void Push(T value)
        {
            Node<T> temp = new Node<T>(value);

         
            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }
            temp.data = value;
            temp.next = top;
            top = temp;
            Console.WriteLine("{0} pushed to stack", value);
        }

        internal void Display()
        {
            Console.WriteLine("\nDisplaying stack:");
            Node<T> temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");

        }

        internal void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", top.data);
        }
        internal void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is : {0}", top.data);
            top = top.next;
        }

        internal void IsEmpty()
        {
            while (top != null)
            {
                Peek();
                Pop();
            }
        }

    }
}
