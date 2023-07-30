using LinkedList.UnorderedList.LinkedListQueue;
using System;
using System.Diagnostics.Metrics;

using System.Diagnostics;
using System.Numerics;

namespace LinkedListProblem.BankingCashCounter
{
    public class OperationBanking
    {
        LinkedListQueue<string> queue = new LinkedListQueue<string>();
        int amount;
        public OperationBanking(int amount)
        {
            this.amount = amount;
        }
        public void AddPersonsInQueue()
        {
            Console.WriteLine("Enter num of persons in Queue");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Person's number:");
                queue.Enqueue(Console.ReadLine());
            }
            while (num > 0)
            {
                Console.WriteLine("Choose an option to proceed \n1.WithDraw\n2.Deposit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        WithDraw();
                        Console.WriteLine("current balance:");
                        DisplayAmountInATM();
                        break;
                    case 2:
                        Deposit();
                        Console.WriteLine("current balance:");
                        DisplayAmountInATM();
                        break;
                    case 3:

                        break;
                }
                queue.Dequeue();
                num--;
            }
        }

        private void DisplayAmountInATM()
        {
            Console.WriteLine(amount);
        }

        private void Deposit()
        {
            Console.WriteLine("Enter amount to withdraw");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            amount += depositAmount;
        }

        public void WithDraw()
        {
            Console.WriteLine("Enter amount to withdraw");
            int withDrawAmount = Convert.ToInt32(Console.ReadLine());
            if (withDrawAmount <= amount)
                amount -= withDrawAmount;
            else
                Console.WriteLine("Insufficient Amount..Please try again later");
            }
    }
    }


    