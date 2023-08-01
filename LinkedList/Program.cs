using LinkedList.BalancedParanthesis;
using LinkedList.Hashing;
using LinkedList.UnorderedList.LinkedListQueue;
using LinkedListProblem.BankingCashCounter;
using LinkedListProblem.UnorderedList;
using System;
namespace LinkedList
{
    class Program
    {
        static string File = @"D:\gittestrep\LinkedList\LinkedList\UnorderedList\UnorderedList.txt";
        static string ParanthesisFile= @"D:\gittestrep\LinkedList\LinkedList\BalancedParanthesis\Paranthesis.txt";
        static string OrderedFilePath = @"D:\gittestrep\LinkedList\LinkedList\OrderedLists\OrderedList.txt";
        static string HashFile = @"D:\gittestrep\LinkedList\LinkedList\Hashing\Hashingtxt.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Select an option to proceed: \n 1.LinkedList \n 2.LinkedList Stack\n 3.ListList Queue\n 4.OrderedList\n5.Exit");

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
                        Operation operationOrdered = new Operation();
                        operationOrdered.ReadFileAndPerformOperation(OrderedFilePath);
                        break;
                    case 5:
                        Console.WriteLine("Enter amount:");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        OperationBanking OpBank = new OperationBanking(amount);
                        OpBank.AddPersonsInQueue();
                        break;
                    case 6:
                        OperationParanthesis Paranthesis = new OperationParanthesis();
                        Paranthesis.ReadFileAndPerformOperation(ParanthesisFile);
                        break;
                    case 7:
                        HashingOperation hash = new HashingOperation();
                        hash.ReadFile(HashFile);
                        break;
                    default:
                        flag = false;
                        break;

                }
            }
           
            
           
        }
    }
}