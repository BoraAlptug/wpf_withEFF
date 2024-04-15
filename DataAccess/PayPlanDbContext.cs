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
            //data source=31.145.9.158,19006;database=SQLERPIS_GUNCEL_TEST;user id=" + kullanicikodu + ';' + "pwd=" + kullanicisifresi + ';' + "timeout=60000
            //@"server=192.168.0.4;Database=SQLERPIS;Uid=sa;Password=15Rafex!#P@sSw0rd26;TrustServerCertificate=true"
            optionsBuilder
                        .EnableSensitiveDataLogging()
                        .UseSqlServer(@"Data Source=DESKTOP-NAKORGM\BORA; Initial Catalog=Deneme; User ID=sa; pwd=C2b@admin**; TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
