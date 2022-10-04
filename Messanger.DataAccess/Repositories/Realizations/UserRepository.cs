using Messanger.DataAccess.Enteties;
using Messanger.DataAccess.Repositories.Interfaces;

namespace Messanger.DataAccess.Repositories.Realizations
{
    public class UserRepository : IUser
    {
        private readonly MessangerContext _context;
        public UserRepository(MessangerContext context)
        {
            _context = context ;
        }
        public void Add(User user)
        {
           _context.Add(user);
        }

        public void Delete(User user)
        {
           _context.Remove(user);
        }

        public void Update(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }
    }
}
