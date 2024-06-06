using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Configurations
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.Property(s => s.ProductId)
               .IsRequired();

            builder.Property(s => s.Quantity)
                   .IsRequired();

            builder.Property(s => s.IsReadyForSale)
                   .IsRequired();

            builder.HasOne(s => s.Product)
                   .WithMany(p => p.Stocks)
                   .HasForeignKey(s => s.ProductId);
        }
    }
}
