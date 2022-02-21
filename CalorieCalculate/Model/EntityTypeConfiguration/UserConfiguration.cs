using CalorieCalculate.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Model.EntityTypeConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Kullanıcı");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(150);

            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(8);

        }
    }
}
