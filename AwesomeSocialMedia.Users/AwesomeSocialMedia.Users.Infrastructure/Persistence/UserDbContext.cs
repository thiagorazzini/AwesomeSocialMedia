using AwesomeSocialMedia.Users.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AwesomeSocialMedia.Users.Infrastructure.Persistence
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

        public List<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e =>
            {
                e.HasKey(u => u.Id);

                e.OwnsOne(u => u.Location,
                    builder =>
                    {
                        builder.Property(p => p.City).HasColumnName("City").IsRequired(false);
                        builder.Property(p => p.State).HasColumnName("State").IsRequired(false);
                        builder.Property(p => p.Country).HasColumnName("Country").IsRequired(false);

                    });

                e.OwnsOne(u => u.Contact,
                    builder =>
                    {
                        builder.Property(p => p.Email).HasColumnName("Email").IsRequired(false);
                        builder.Property(p => p.Website).HasColumnName("Website").IsRequired(false);
                        builder.Property(p => p.PhoneNumber).HasColumnName("PhoneNumber").IsRequired(false);
                    });
            });
        }
    }
}
