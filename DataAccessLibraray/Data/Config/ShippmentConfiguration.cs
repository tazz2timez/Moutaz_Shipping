using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.Models;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DataAccessLibraray.Data.Config
{
    public class ShippmentConfiguration : IEntityTypeConfiguration<TbShippment>
    {
        public void Configure(EntityTypeBuilder<TbShippment> builder)
        {

            builder.ToTable("TbShippments");


          
            builder
            .HasOne(e => e.TbPaymentMethod)
            .WithMany(e => e.TbShippments)
            .HasForeignKey(e => e.PaymentMethodId)
            .IsRequired(false);
                 
            builder
            .HasOne(e => e.TbSender)
            .WithMany(e => e.TbShippments)
            .HasForeignKey(e => e.SenderId)
            .IsRequired();
                             
            builder
            .HasOne(e => e.TbReceiver)
            .WithMany(e => e.TbShippments)
            .HasForeignKey(e => e.ReceiverId)
            .IsRequired();

             builder
            .HasOne(e => e.TbShippingType)
            .WithMany(e => e.TbShippments)
            .HasForeignKey(e => e.ShippingTypeId)
            .IsRequired();

            builder
            .HasMany(e => e.TbShippmentStatuses)
            .WithOne(e => e.TbShippment)
            .HasForeignKey(e => e.ShippmentId)
            .IsRequired();


            // Add other configurations if needed

        }

    }


}
