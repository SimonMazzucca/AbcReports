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
            Console.WriteLine(_context.Accounts.FirstOrDefault().Reports.ToList());

            return result;
        }
    }
}
