using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderedList.OrderedList
{
    public class Operation
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        public void ReadFileAndPerformOperation(string filePath)
        {
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(",");
            foreach (var data in words)
            {
                linkedList.Add(Convert.ToInt32(data));
            }
            linkedList.Display();
            Console.WriteLine("\nEnter number to search");
            int num = Convert.ToInt32(Console.ReadLine());
            int position = linkedList.Search(num);
            if (position == -1)
            {
                linkedList.Add(num);
            }
            else
            {
                linkedList.DeleteNodeAtParticularPosition(position);
            }
            linkedList.Display();
        }
    }
}