namespace Server
{
    public interface IMessageClient
    {
        Task Send(NewMessage message);
    }
}
