using System;
using System.Collections.Generic;

#nullable disable

namespace AbcReports
{
    public partial class AccountTransaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string AccountId { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
