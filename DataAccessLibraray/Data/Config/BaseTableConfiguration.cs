using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domains.Models;
using DataAccessLibraray.UserModels;

namespace DataAccessLibraray.Data.Config
{
    public class BaseTableConfiguration : IEntityTypeConfiguration<baseTable>
    {
        public void Configure(EntityTypeBuilder<baseTable> builder)
        {
            builder.UseTpcMappingStrategy();//this can prevent creating BaseTable in SQL server
            
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd(); // Configures Id as auto-generated

            builder
           .HasOne<ApplicationUser>()
            .WithMany()
            .HasForeignKey(b => b.CreatedBy)
            .IsRequired(true)
            .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne<ApplicationUser>()
                .WithMany()
                .HasForeignKey(b => b.UpdatedBy)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }

}
