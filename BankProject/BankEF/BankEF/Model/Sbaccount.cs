using System;
using System.Collections.Generic;

#nullable disable

namespace BankEF.Model
{
    public partial class Sbaccount
    {
        public Sbaccount()
        {
            Sbtransactions = new HashSet<Sbtransaction>();
        }

        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public double? CurrentBalance { get; set; }

        public virtual ICollection<Sbtransaction> Sbtransactions { get; set; }
    }
}
