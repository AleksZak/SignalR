using Microsoft.EntityFrameworkCore;
using Messanger.DataAccess.Enteties;


namespace Messanger.DataAccess
{
    public class MessangerContext : DbContext
    {
        public MessangerContext(DbContextOptions options) : base(options)   
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user => 
            {
                user.HasKey(id=>id.ID);
                user.Property(name=>name.UserName).IsRequired();    
                user.Property(connection=>connection.UserConnectiionId).IsRequired();
                user.HasMany(entity=>entity.Messages).WithOne(entity=>entity.User).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Message>(message => 
            {
                message.HasKey(key=>key.MassageID);
                message.Property(tittle=>tittle.Title).IsRequired();
                message.Property(text=>text.Text).IsRequired();
            });
        
        }
    }
}
