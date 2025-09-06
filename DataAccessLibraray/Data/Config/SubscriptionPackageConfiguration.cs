using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domains.Models;

namespace DataAccessLibraray.Data.Config
{
    public class SubscriptionPackageConfiguration : IEntityTypeConfiguration<TbSubscriptionPackage>
    {
        public void Configure(EntityTypeBuilder<TbSubscriptionPackage> builder)
        {

            builder.ToTable("TbSubscriptionPackages");

            builder
              .HasMany(e => e.TbUserSubscriptions)
              .WithOne(e => e.TbPackage)
              .HasForeignKey(e => e.PackageId)
              .IsRequired();


        }

    }
}
