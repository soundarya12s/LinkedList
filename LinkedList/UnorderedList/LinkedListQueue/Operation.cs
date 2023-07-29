using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.UnorderedList.LinkedList;

namespace LinkedList.UnorderedList.LinkedListQueue
{
    public class OperationQueue
    {
        LinkedListQueue<string> linkedList = new LinkedListQueue<string>();
        public void ReadFileAndPerformOperation(string filePath)
        {

            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                linkedList.Enqueue(data);
            }
            linkedList.Display();

        }

        //public void Search(string character)
        //{
        //    Console.WriteLine("Enter number to search:");
        //    string word = Console.ReadLine();
        //    int position = linkedList.Search(word);
        //    if (position == -1)
        //    {
        //        linkedList.Add(word);
        //    }
        //    else
        //    {
        //        linkedList.DeleteNodeAtParticularPosition(position);
        //    }
        //    linkedList.Display();
        //}
        public void WriteToFile(string filePath)
        {
            string content = string.Join(",", linkedList);
            File.WriteAllText(filePath, content);
        }
    }
}
