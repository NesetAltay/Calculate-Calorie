using CalorieCalculate.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Model.EntityTypeCondiguration
{
    public class UserInformationConfiguration : IEntityTypeConfiguration<UserInformation>
    {
        public void Configure(EntityTypeBuilder<UserInformation> builder)
        {
            builder.ToTable("Kullanıcı Bilgileri");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(50);

            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50);

            builder.Property(x => x.BirthDate).HasColumnType("datetime2");

            builder.Property(x => x.Height).HasPrecision(18, 2);

            builder.Property(x => x.Weight).HasPrecision(18, 2);

            builder.HasOne(x => x.User).WithOne(x => x.UserInformation).HasForeignKey<UserInformation>(x => x.Id);
        }
    }
}
