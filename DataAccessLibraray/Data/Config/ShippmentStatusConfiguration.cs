using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domains.Models;

namespace DataAccessLibraray.Data.Config
{
    public class ShippmentStatusConfiguration : IEntityTypeConfiguration<TbShippmentStatus>
    {
        public void Configure(EntityTypeBuilder<TbShippmentStatus> builder)
        {

            builder.ToTable("TbShippmentStatuses");

            builder
                .HasOne(e => e.TbCarrier)
                .WithMany(e => e.TbShippmentStatuses)
                .HasForeignKey(e => e.CarrierId);


        }

    }  
}
