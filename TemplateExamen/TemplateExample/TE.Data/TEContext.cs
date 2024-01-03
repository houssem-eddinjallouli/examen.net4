using Microsoft.EntityFrameworkCore;
using TE.Data.Config;

namespace TE.Data
{
    public class TEContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog = MyDBNamekafala; 
                                        Integrated Security = true");
            optionsBuilder.UseLazyLoadingProxies(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BeneficeryConfig());
            modelBuilder.ApplyConfiguration(new DonatorConfig());
            modelBuilder.ApplyConfiguration(new KafalaConfig());
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //configurationBuilder.Properties<string>().HaveMaxLength(10);
            //configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }
    }
}