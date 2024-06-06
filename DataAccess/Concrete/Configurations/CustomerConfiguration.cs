using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.CustomerName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.CustomerCode)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(c => c.Address)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(c => c.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(15);

            builder.Property(c => c.Email)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }

}
