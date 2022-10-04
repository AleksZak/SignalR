using Messanger.DataAccess.Enteties;

namespace Messanger.DataAccess.Repositories.Interfaces
{
    public interface IMessage
    {
        public void Add(Message message);
        public void Delete(Message message);
        public void Edit(Message message);
        public string Read(Message message);

    }
}
