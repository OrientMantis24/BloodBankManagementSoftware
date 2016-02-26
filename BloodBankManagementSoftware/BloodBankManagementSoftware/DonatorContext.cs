using System.Data.Entity;

namespace BloodBankManagementSoftware
{
    class DonatorContext : DbContext
    {
        public DonatorContext(): base(){}

        public DbSet<Donator> Donators { get; set; }
    }
}
