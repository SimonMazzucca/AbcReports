namespace AbcReports.DataAccess
{
    public static class ExtensionMethods
    {
        public static string ToVerbose(this string periodCode)
        {
            if (periodCode == "PWK")
                return "Prev. Week";
            else if (periodCode == "MTD")
                return "Month to Date";
            else if (periodCode == "YTD")
                return "Year to Date";
            else
                return periodCode;
        }
    }
}
