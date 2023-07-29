using LinkedListProblem.UnorderedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList.UnorderedList.LinkedList
{
    public class Linkedlist<T>
    {
        internal Node<T> head;
        internal void Add(T data)
        {
           
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("'{0}' is inserted into linked list", node.data);
        }
        internal void Display()
        {
            Console.Write("Inserted data: ");
            Node<T> temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
        internal int Search(T value)
        {
            bool isFound = false;
            Node<T> node = head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    isFound = true;
                    return count;
                }
                node = node.next;
                count++;
            }
            if (isFound)
                return count;
            else
                return -1;
        }
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node<T> temp = head;
            if (position == 0)
            {
                head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node<T> next = temp.next.next;
            temp.next = next;
        }
        public void Operation(T word)
        {
            int position = Search(word);
            if (position == -1)
            {
                Add(word);
            }
            else
            {
                DeleteNodeAtParticularPosition(position);
            }
        }
    }
}