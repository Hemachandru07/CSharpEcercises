using System;
using BankEF.Model;
using System.Linq;

namespace BankEF
{
    public class Class1
    {
        public static BankDBContext db = new BankDBContext();
        public static Sbtransaction s = new Sbtransaction();

        public void GetTransactions()
        {
                Console.WriteLine("Enter the AccountNumber : ");
                int accno = Convert.ToInt32(Console.ReadLine());
                
        }
    }
}
