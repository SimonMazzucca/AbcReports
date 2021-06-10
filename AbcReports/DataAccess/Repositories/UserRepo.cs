using System;
using System.Collections.Generic;
using System.Linq;

namespace AbcReports.DataAccess.Repositories
{
    public class UserRepo
    {
        ABCReportsContext _context;

        public UserRepo(ABCReportsContext context)
        {
            _context = context;
        }

        public bool IsLoginValid(string userName, string password)
        {
            User result = _context.Users
                .Where(u => u.UserName.Equals(userName) && u.Password.Equals(password))
                .FirstOrDefault();

            return result != null;
        }

        internal List<Account> GetUserAccounts(int userId)
        {
            List<Account> result = _context.Accounts.Where(a => a.UserId == userId).ToList();
            return result;
        }
    }
}
