using LinkedList.UnorderedList.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Hashing
{
    public class HashingOperation
    {
        static int size = 11;
        Linkedlist<int>[] array = new Linkedlist<int>[size];
        public HashingOperation()
        {
            for(int i = 0; i < size; i++)
            {
                array[i]= new Linkedlist<int>();    
            }
        }

        public void ReadFile(string filePath)
        {
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(",");
            foreach(var data in words)
            {
                int num= Convert.ToInt32(data);
                int position = num % size;
                array[position].Add(num);
            }
          
        }
        public void Display()
        {
            foreach(var data in array)
            {
                data.Display();
                Console.WriteLine();
            }
        }
    }
}
