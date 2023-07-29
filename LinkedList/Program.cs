using LinkedList.UnorderedList.LinkedListQueue;
using LinkedListProblem.UnorderedList;
using System;
namespace LinkedList
{
    class Program
    {
        static string File = @"D:\gittestrep\LinkedList\LinkedList\UnorderedList\UnorderedList.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Select an option to proceed: \n 1.LinkedList \n 2.LinkedList Stack\n 3.ListList Queue\n 4.Exit");

            while (flag)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Operation op = new Operation();
                        op.ReadFileAndPerformOperation(File);
                        break;
                    case 2:
                        OperationStack stack = new OperationStack();
                        stack.ReadFileAndPerformOperation(File);
                        break;
                    case 3:
                        OperationQueue queue = new OperationQueue();
                        queue.ReadFileAndPerformOperation(File);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        flag = false;
                        break;

                }
            }
           
            
           
        }
    }
}