using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AbcReports
{
    public partial class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public int TypeId { get; set; }
        //public AccountType AccountType { get; set; }
        public int UserId { get; set; }


        public List<Report> Reports { get; set; }
    }
}
