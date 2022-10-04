using Messanger.DataAccess.Enteties;
namespace Messanger.DataAccess.Repositories.Interfaces
{
    publicinterface IUser
    {
        public void Add(User user);
        public void Update(User user);
        public void Delete(User user);
       
    }
}
