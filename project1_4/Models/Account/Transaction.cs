using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project1_4.Models.Account
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public double Amount { get; set; }
        public string TransactionType { get; set; }
        public int? GoalAccount { get; set; }
        public DateTime TransactionTime { get; set; }

        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
