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
            Console.WriteLine("Select an option to proceed: \n 1.LinkedList \n 2.Exit");

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
                        flag=false;
                        break;
                    default:
                        flag = false;
                        break;

                }
            }
           
            
           
        }
    }
}
