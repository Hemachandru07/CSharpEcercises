using System;
using Bank_Lib;
using System.Data.SqlClient;



namespace BankProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankRepository obj = new BankRepository();
            Console.WriteLine("Enter the option [1] Admin [2] User :");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the choice : \n1.New account \n2.Get All Accounts \n3.Get Account Details");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            obj.NewAccount();
                        }
                        else if (choice == 2)
                        {
                            obj.GetAllAccounts();
                        }
                        else if (choice == 3)
                        {
                            obj.GetAccountDetails();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Choice");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the choice : \n1.Get Transactions \n2.Deposit Amount \n3.Withdraw Ammount");
                        int choice1 = Convert.ToInt32(Console.ReadLine());
                        if(choice1 == 1)
                        {
                            obj.GetTransactions();
                        }
                        else if(choice1 == 2)
                        {
                            obj.DepositAmount();
                        }
                        else if (choice1 == 3)
                        {
                            obj.WithdrawAmount();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Choice");
                        }
                        
                    break;
                    }
                default :
                    {
                        Console.WriteLine("Invalid Choice");
                        break;
                    }
            }
        }
    }
}
