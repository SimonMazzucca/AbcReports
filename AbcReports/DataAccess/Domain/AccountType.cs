using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AbcReports
{
    public partial class AccountType
    {
        [Key]
        public int AccountTypeId { get; set; }
        public string AccountTypeName { get; set; }

        //public List<Account> Accounts { get; set; }
    }
}
