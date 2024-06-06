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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FullName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(15);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(u => u.Gender)
                   .IsRequired()
                   .HasMaxLength(1);

            builder.Property(u => u.PasswordHash)
                   .IsRequired();

            builder.Property(u => u.PasswordSalt)
                   .IsRequired();

            builder.HasMany(u => u.UserRoles)
               .WithOne(ur => ur.User)
               .HasForeignKey(ur => ur.UserId);
        }
    }
}
