namespace ChallengeApi.Models
{    
    using Microsoft.EntityFrameworkCore;

     public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options)
            : base(options)
        {
        }

        public DbSet<Contacts> Contacts { get; set; }
    }
}