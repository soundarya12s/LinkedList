using LinkedList.UnorderedList.LinkedListStack;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.BalancedParanthesis
{
    public class OperationParanthesis
    {
        LinkedListStack<string> stack = new LinkedListStack<string>();
        public void ReadFileAndPerformOperation(string filePath)
        {
            String readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(" ");
            foreach(var data in words)
            {
                if(data.Equals("("))
                    stack.Push(data);
                if(data.Equals(")"))    
                    stack.Pop();
            }

            if (stack.top !=null)
                Console.WriteLine("Balanced Paranthesis");
            else
                Console.WriteLine("Not a Balanced paranthesis");
        }
    }
}
