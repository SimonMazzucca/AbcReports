using System;
using System.Collections.Generic;
using System.Linq;

namespace AbcReports.DataAccess.Repositories
{
    public class ReportsRepo
    {

        ABCReportsContext _context;

        public ReportsRepo(ABCReportsContext context)
        {
            _context = context;
        }

        public IList<Report> GetUserReports(string userName)
        {
            User user = _context.Users
                .Where(u => u.UserName.Equals(userName))
                .FirstOrDefault();

            List<Report> result = _context.Reports
                .Where(r => r.Account.UserId == user.UserId).ToList();

            // HACK: necessary to work around broken lazy loading
            var accounts = _context.Accounts.ToList();
            Console.WriteLine(accounts[0].Reports.ToList());
            Console.WriteLine(accounts[1].Reports.ToList());

            return result;
        }
    }
}
