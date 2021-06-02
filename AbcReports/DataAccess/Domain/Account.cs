using System;
using System.Collections.Generic;

#nullable disable

namespace AbcReports
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public int TypeId { get; set; }
        public int UserId { get; set; }
    }
}
