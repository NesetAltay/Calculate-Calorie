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
    public class RepastConfiguration : IEntityTypeConfiguration<Repast>
    {
        public void Configure(EntityTypeBuilder<Repast> builder)
        {
            builder.ToTable("OgunBilgileri");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.RepastName).IsRequired();
            builder.Property(x => x.RepastName).HasMaxLength(10);

            builder.Property(x => x.Date).HasDefaultValueSql("GetDate()");

            builder.HasOne(x => x.User).WithMany(x => x.Repasts).HasForeignKey(x => x.UserId);
        }
    }
}
