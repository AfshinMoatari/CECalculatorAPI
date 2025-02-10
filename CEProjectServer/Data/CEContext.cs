using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

namespace CEProjectServer.Data
{
    public class CEContext : DbContext
    {
        public CEContext(DbContextOptions<CEContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed data into the tables
            modelBuilder.Seed();

            //Disabled cascading delete for following Tables
            modelBuilder.Entity<PopulationModel>()
                .HasMany(e => e.TotalSectorCostModel)
            .WithOne(e => e.PopulationModel)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<SectorModel>()
                .HasMany(e => e.TotalSectorCostModel)
                .WithOne(e => e.SectorModel)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<StakeholderModel>()
                .HasMany(e => e.TotalSectorCostModel)
                .WithOne(e => e.StakeholderModel)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<MeasurementModel>()
               .HasMany(e => e.TotalSectorCostModel)
               .WithOne(e => e.MeasurementModel)
               .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<InterventionEffectModel> InterventionEffects { get; set; }
        public DbSet<PopulationModel> Populations { get; set; }
        public DbSet<SectorModel> Sectors { get; set; }
        public DbSet<StakeholderModel> Stakeholders { get; set; }
        public DbSet<TotalSectorCostModel> TotalSectorCosts { get; set; }
        public DbSet<EconomicFactorModel> EconomicFactors { get; set; }
        public DbSet<AnalyticModel> Analytics { get; set; }
    }
}
