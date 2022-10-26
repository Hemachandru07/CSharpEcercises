using System;
using System.Collections.Generic;

#nullable disable

namespace BankEF.Model
{
    public partial class Sbtransaction
    {
        public int Transactionid { get; set; }
        public DateTime? Transactiondate { get; set; }
        public int? AccountNumber { get; set; }
        public double? Amount { get; set; }
        public string Transactiontype { get; set; }

        public virtual Sbaccount AccountNumberNavigation { get; set; }
    }
}
