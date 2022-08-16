using MyDatabase.Entity;

namespace WebFundamentals.Service
{
    public class AuthenticateService
    {
        private DatabaseCoreContext _context = new DatabaseCoreContext();

        public bool AuthenticateLocal(string UserName, string Password)
        {
            var flag = _context.Users.Any(x => x.UserId == UserName && x.Password == Password);
            return flag;
        }

    }
}
