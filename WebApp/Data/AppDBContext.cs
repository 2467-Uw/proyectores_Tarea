using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.Models.Services;

namespace WebApp.Data.Migrations
{
    public class AppDBContext : DbContext
    {
        public DbSet<Proyector> Proyectores { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Proyector>().ToTable("Proyectores");
        }

    }
}
