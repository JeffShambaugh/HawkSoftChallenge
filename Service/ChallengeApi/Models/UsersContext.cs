namespace ChallengeApi.Models
{
    using Microsoft.EntityFrameworkCore;

    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        
    }
}