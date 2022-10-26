using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Lib
{
    public interface IBankRepository
    {
        void NewAccount(); 
        void GetAccountDetails(); 
        public void GetAllAccounts();
        void DepositAmount(); 
        void WithdrawAmount(); 
        public void GetTransactions(); 
    }
}
