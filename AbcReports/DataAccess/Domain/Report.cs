using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AbcReports
{
    public partial class Report
    {
        [Key]
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public DateTime CreationDate { get; set; }

        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public string Period { get; set; }

    }
}
