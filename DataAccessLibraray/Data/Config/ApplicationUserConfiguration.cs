using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataAccessLibraray.UserModels;

namespace DataAccessLibraray.Data.Config
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

            builder.HasKey(x => x.Id);
            builder.ToTable("AspNetUsers");
            //many senders and receivers
            //with users relationship must be identified using Identity 
            builder.HasMany(x=>x.TbSenders)
                   .WithOne()
                   .HasForeignKey(e => e.UserId)
                   .IsRequired();

            builder.HasMany(x => x.TbReceivers)
                   .WithOne()
                   .HasForeignKey(e => e.UserId)
                   .IsRequired();

            builder.HasMany(x => x.TbUserSubscriptions)
                  .WithOne()
                  .HasForeignKey(e => e.UserId)
                  .IsRequired(false);

            builder.HasMany(x => x.TbShippments)
               .WithOne()
               .HasForeignKey(e => e.UserId)
               .IsRequired(false);

        }

    }

}
