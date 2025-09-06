using Microsoft.EntityFrameworkCore;
using Domains.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Data;
using DataAccessLibraray.UserModels;

namespace DataAccessLibraray.Data
{
    public partial class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        //public virtual DbSet<baseTable>BaseTables{ get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<TbCarrier> TbCarriers { get; set; }
        public virtual DbSet<TbCity> TbCities { get; set; }
        public virtual DbSet<TbCountry> TbCountries { get; set; }
        public virtual DbSet<TbPaymentMethod> TbPaymentMethods { get; set; }
        public virtual DbSet<TbSetting> TbSettings { get; set; }
        public virtual DbSet<TbShippingType> TbShippingTypes { get; set; }
        public virtual DbSet<TbShippment> TbShippments { get; set; }
        public virtual DbSet<TbShippmentStatus> TbShippmentStatuses { get; set; }
        public virtual DbSet<TbSubscriptionPackage> TbSubscriptionPackages { get; set; }
        public virtual DbSet<TbUserReceiver> TbUserReceivers { get; set; }
        public virtual DbSet<TbUserSender> TbUserSenders { get; set; }
        public virtual DbSet<TbUserSubscription> TbUserSubscriptions { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If you haven't configured this in Program.cs
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = DARK-HORSE-ATIE; Database=ShippingDb; Integrated Security= SSPI;  TrustServerCertificate = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(200);
            configurationBuilder.Properties<decimal>().HaveColumnType("decimal(8,2)");
            configurationBuilder.Properties<DateTime>().HaveColumnType("Date");
            configurationBuilder.Properties<Enum>().HaveMaxLength(200);
        }
    }
}
