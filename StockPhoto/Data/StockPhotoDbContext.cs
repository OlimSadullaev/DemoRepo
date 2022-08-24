using Microsoft.EntityFrameworkCore;
using StockPhoto.Entities;

namespace StockPhoto.Data
{
    public class StockPhotoDbContext : DbContext
    {
        public DbSet<AltPhoto> Photos { get; set; }

        public DbSet<AltText> Texts { get; set; }

        public DbSet<Author> Authors { get; set; }

        public StockPhotoDbContext(DbContextOptions options) : base(options) { }

       /* protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Author>()
                .WithMany(b =>b.Photo)
                .WithMany(b =>b.Author)
                .HasForeignKey(b => b.Author.Id)
                .OnDelete(DeleteBehavior.Cascade);
         }*/
    }
}
