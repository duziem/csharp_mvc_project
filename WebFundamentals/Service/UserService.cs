using MyDatabase.Entity;
using WebFundamentals.Models;

namespace WebFundamentals.Service
{
    public class UserService
    {
        private DatabaseCoreContext _context = new DatabaseCoreContext();

        public User AddUser(UserModel um)
        {
            try
            {

                User user = new User();
                user.UserId = um.UserId;
                user.FirstName = um.FirstName;
                user.LastName = um.LastName;
                user.Email = um.Email;
                user.DateCreated = DateTime.Now;
                user.Password = um.Password;

                _context.Users.Add(user);
                _context.SaveChanges();

                return user;

            }catch(Exception err)
            {
                return null;
            }
        }

        public User UpdateUser(UserModel um)
        {
            try
            {

                User user = _context.Users.FirstOrDefault(x => x.UserId == um.UserId);

                user.FirstName = um.FirstName;
                user.LastName = um.LastName;
                user.Email = um.Email;
                user.DateCreated = DateTime.Now;
                user.Password = um.Password;

                _context.SaveChanges();

                return user;

            }
            catch (Exception err)
            {
                return null;
            }
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
