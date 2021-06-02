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
    }
}
