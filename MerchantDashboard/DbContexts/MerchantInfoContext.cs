using MerchantDashboard.Entities;
using Microsoft.EntityFrameworkCore;

namespace MerchantDashboard.DbContexts
{
    public class MerchantInfoContext : DbContext
    {
        public MerchantInfoContext(DbContextOptions<MerchantInfoContext> options) : base(options) { }

        public DbSet<Merchant> Merchants { get; set; }
    }
}
