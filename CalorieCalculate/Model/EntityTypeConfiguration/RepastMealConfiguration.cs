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
   public class RepastMealConfiguration : IEntityTypeConfiguration<RepastMeal>
    {
        public void Configure(EntityTypeBuilder<RepastMeal> builder)
        {
            builder.ToTable("OgunYemek");

            builder.Property(x => x.EatenPortion).HasPrecision(18, 2);

            builder.Property(x => x.MealImage).IsRequired(false); // null geçilebilir
            builder.Property(x => x.MealImage).HasMaxLength(600);

            builder.HasKey(x => new { x.MealId, x.RepastId });

            builder.HasOne(x => x.Meal).WithMany(x => x.RepastMeals).HasForeignKey(x => x.MealId);
            builder.HasOne(x => x.Repast).WithMany(x => x.RepastMeals).HasForeignKey(x => x.RepastId);
        }
    }
}
