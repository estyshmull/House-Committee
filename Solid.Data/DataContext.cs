using Microsoft.EntityFrameworkCore;
using Solid.Core;

namespace newHouseCommittee.Entities
{
    public class DataContext:DbContext
    {
        public DbSet<Biulding> BiuldingList { get; set; }
        public DbSet<Payment> PaymentList { get; set; }
        public DbSet<Tenant> TenantList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Esty_Db");
        }
    }
}

