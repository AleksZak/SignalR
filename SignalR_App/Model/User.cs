namespace SignalR_App.Model
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public HashSet<string> UserConnectiionId { get; set; }
        public bool IsOnline { get; set; }
    }
}
