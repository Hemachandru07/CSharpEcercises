using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
     class ex3
    {
        public static void Main()
        {
            int Initial_Balance = 5000;
            Console.WriteLine("Enter the Account Number : ");
            string AccountNum = Console.ReadLine();
            Console.WriteLine("Select (1) for Deposit or (2) for Withdraw option : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the amount to be deposited : ");
                        int deposit = int.Parse(Console.ReadLine());
                        int Balance = Initial_Balance + deposit;
                        Console.WriteLine("Current Balance :" + Balance);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the amount to be Withdrawn : ");
                        int withdraw = int.Parse(Console.ReadLine());
                        if (withdraw <= 5000)
                        {
                            int Balance = Initial_Balance - withdraw;
                            Console.WriteLine("Current Balance : " + Balance);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Invalid option");
                    break;

            }

        }
    }
}
