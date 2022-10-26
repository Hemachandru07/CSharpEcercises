using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Lib
{
    public class SBTransaction
    {
        public string TransactionId;
        public DateTime TransactionDate { get; set;}
        public int AccountNumber { get; set; }
        public float Amount { get; set; }
        public char TransactionType { get; set; }
    }
}
