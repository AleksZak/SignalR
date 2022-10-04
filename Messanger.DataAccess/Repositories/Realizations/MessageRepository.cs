using Messanger.DataAccess.Enteties;
using Messanger.DataAccess.Repositories.Interfaces;


namespace Messanger.DataAccess.Repositories.Realizations
{
    public class MessageRepository : IMessage
    {  
        private readonly MessangerContext _context;
        public MessageRepository(MessangerContext context)
        {
            _context = context;
        }
        public void Add(Message message)
        {
            _context.Add(message);
        }

        public void Delete(Message message)
        {
            _context.Remove(message);
        }

        public void Edit(Message message)
        {
            _context.Update(message);
            _context.SaveChanges();
        }

        public string Read(Message message)
        {
            return message.Text;
        }
    }
}
