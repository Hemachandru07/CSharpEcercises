using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkCore.Model
{
    public partial class Supllier
    {
        public Supllier()
        {
            Products = new HashSet<Product>();
        }

        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
