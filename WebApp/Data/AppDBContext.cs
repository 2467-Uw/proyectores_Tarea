using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data.Migrations
{
    public class AppDBContext : DbContext
    {
        public DbSet<Proyector> Proyectores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Proyector>().ToTable("Proyectores");
        }

    }
}
