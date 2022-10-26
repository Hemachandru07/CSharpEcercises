using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkCore.Model
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public double? Price { get; set; }
        public int? Qty { get; set; }
        public DateTime? Dom { get; set; }
        public int? Sid { get; set; }

        public virtual Supllier SidNavigation { get; set; }
    }
}
