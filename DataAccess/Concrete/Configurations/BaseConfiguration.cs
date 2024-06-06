using Core.Entities;
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
    public class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedUserId)
               .IsRequired();

            builder.Property(x => x.CreatedDate)
                   .IsRequired();

            builder.Property(x => x.LastUpdatedUserId)
                   .IsRequired();

            builder.Property(x => x.LastUpdatedDate)
                   .IsRequired();

            builder.Property(x => x.Status)
                   .IsRequired();

            builder.Property(x => x.IsDeleted)
                   .IsRequired();
        }
    }
}
