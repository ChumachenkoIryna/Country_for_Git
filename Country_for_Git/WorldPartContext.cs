using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Country_for_Git
{
    public class WorldPartContext : DbContext
    {
        public WorldPartContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<WorldPart> WorldParts { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // метод UseLazyLoadingProxies() делает доступной ленивую загрузку.
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=IRISKA-PC;Database=CountryDB;Integrated Security=SSPI;TrustServerCertificate=true");
        }
    }
}
