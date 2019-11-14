using Microsoft.EntityFrameworkCore;
using Obra.Web.Data.Entities;

namespace Obra.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
 
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<PartnerType> PartnerTypes { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Construction> Constructions { get; set; }
        public DbSet<ProfitCenter> ProfitCenters { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasIndex(i => i.Name).IsUnique().HasName("IX_Currency_Name");
            modelBuilder.Entity<Region>().HasIndex(i => i.Name).IsUnique().HasName("IX_Region_Name");
            modelBuilder.Entity<PartnerType>().HasIndex(i => i.Name).IsUnique().HasName("IX_PartnerType_Name");
            modelBuilder.Entity<PersonType>().HasIndex(i => i.Name).IsUnique().HasName("IX_PersonType_Name");
            modelBuilder.Entity<Country>().HasIndex(i => i.Name).IsUnique().HasName("IX_Country_Name");
            modelBuilder.Entity<State>().HasIndex(i => i.Name).IsUnique().HasName("IX_State_Name");
            modelBuilder.Entity<Company>().HasIndex(i => i.Name).IsUnique().HasName("IX_Company_Name");
            modelBuilder.Entity<Construction>().HasIndex(i => i.Name).IsUnique().HasName("IX_Construction_Name");
            modelBuilder.Entity<ProfitCenter>().HasIndex(i => i.Name).IsUnique().HasName("IX_ProfitCenter_Name");
            modelBuilder.Entity<CostCenter>().HasIndex(i => i.Name).IsUnique().HasName("IX_CostCenter_Name");
        }
    }
}
