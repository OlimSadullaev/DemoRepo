using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationship.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Character> Characters { get; set; }
    }
}
