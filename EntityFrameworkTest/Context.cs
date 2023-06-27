using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkTest
{
    internal class Context : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Deal> Deals { get; set; }

        // ctor - сниппет для конструктора
        public Context()
        {
                //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-AI3C159; Database = NotarialOffice; Trusted_Connection=True; TrustServerCertificate=Yes");
        }
    }
}
