using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domains.Models;

namespace DataAccessLibraray.Data.Config
{
    public class UserRecieverConfiguration : IEntityTypeConfiguration<TbUserReceiver>
    {
        public void Configure(EntityTypeBuilder<TbUserReceiver> builder)
        {

            builder.ToTable("TbUserReceivers");

            //with users relationship must be identified using Identity 

            //remain user relationship

        }

    }

}
