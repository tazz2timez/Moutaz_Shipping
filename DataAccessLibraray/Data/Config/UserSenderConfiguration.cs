using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domains.Models;

namespace DataAccessLibraray.Data.Config
{
    public class UserSenderConfiguration : IEntityTypeConfiguration<TbUserSender>
    {
        public void Configure(EntityTypeBuilder<TbUserSender> builder)
        {

            builder.ToTable("TbUserSenders");

            //with users relationship must be identified using Identity 

            //remain user relationship
        }

    }

}
