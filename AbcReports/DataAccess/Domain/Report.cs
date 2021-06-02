using System;

#nullable disable

namespace AbcReports
{
    public partial class Report
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public DateTime CreationDate { get; set; }
        public int AccountId { get; set; }
        public string Period { get; set; }
    }
}
