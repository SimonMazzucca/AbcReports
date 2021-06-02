using System.Linq;

namespace AbcReports.DataAccess.Repositories
{
    public class LoginRepo
    {
        ABCReportsContext _context;

        public LoginRepo(ABCReportsContext context)
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
