using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BloodBankManagementSoftware
{
    class DonatorContext : DbContext
    {
        public DonatorContext(): base()
        {

        }

        public DbSet<Donator> Donators { get; set; }
    }
}
