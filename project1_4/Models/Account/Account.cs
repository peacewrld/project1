using project1_4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1_4.Models.Account
{
    public class Account
    {
        public int Id { get; set; }

        public int AccountNumber { get; set; }
        public int? RoutingNumber { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }
        public bool isActive { get; set; }
        public string AccountType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? CloseDate { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
