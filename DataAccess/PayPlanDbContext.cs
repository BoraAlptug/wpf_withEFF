using Microsoft.EntityFrameworkCore;
using OdemePlanı_11.Entities.Table;

namespace OdemePlanı_11.DataAccess
{
    public class PayPlanDbContext:DbContext
    {
        public PayPlanDbContext()
        {
            
        }
        public PayPlanDbContext(DbContextOptions<PayPlanDbContext> options) : base(options)
        {

        }
        public DbSet<musteriteklifleriozet_odemesekli> musteriteklifleriozet_odemesekli { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder
                        .EnableSensitiveDataLogging()
                        .UseSqlServer(@"");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
