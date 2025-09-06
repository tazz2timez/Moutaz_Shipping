using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domains.Models;
using System.Reflection.Emit;

namespace DataAccessLibraray.Data.Config
{
    public class UserSubscriptionConfiguration : IEntityTypeConfiguration<TbUserSubscription>
    {
        public void Configure(EntityTypeBuilder<TbUserSubscription> builder)
        {

            builder.ToTable("TbUserSubscriptions");
            
          
        }

    }
   

}
