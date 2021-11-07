using System.Reflection;
using DemoApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DemoApp.DataAccess
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: move configuration to separate file
            modelBuilder.Entity<User>(x =>
            {
                x.HasKey(k => k.Id);
                x.Property(p => p.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);
                x.Property(p => p.LastName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            SeedInitialData(modelBuilder);

            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        private static void SeedInitialData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                    new User(1, "User", "One"),
                    new User(2, "User", "Two"),
                    new User(3, "User", "Three"));
        }
    }

    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlServer("data source=.; initial catalog=DemoApp; integrated security=true",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(ApplicationDbContext).GetTypeInfo().Assembly.GetName().Name));

            return new ApplicationDbContext(builder.Options);
        }
    }
}
