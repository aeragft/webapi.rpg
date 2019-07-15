using Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public sealed class RpgContext : DbContext
    {
        public RpgContext() { }
        public RpgContext(DbContextOptions<RpgContext> options) : base(options) {}

        public DbSet<Character> Characters { get; set; }
        public DbSet<Job> Jobs { get; set; }
        //public DbSet<Weapon> Weapons { get; set; }
        //public DbSet<Skill> Skills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RPGDB;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Character>();
            builder.Entity<Job>();
            //builder.Entity<Weapon>();
            //builder.Entity<Skill>();

        }
    }
}
