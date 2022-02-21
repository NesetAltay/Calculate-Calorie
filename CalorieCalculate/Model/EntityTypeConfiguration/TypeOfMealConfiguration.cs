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
   public class TypeOfMealConfiguration : IEntityTypeConfiguration<TypeOfMeal>
    {
        public void Configure(EntityTypeBuilder<TypeOfMeal> builder)
        {
            #region Kolon Bilgileri
            builder.ToTable("Yemek Grupları");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.MealType).IsRequired();
            builder.Property(x => x.MealType).HasMaxLength(100);
            #endregion

            #region Veri Girişi
            builder.HasData
                (
                new TypeOfMeal { Id = 1, MealType = "Süt Grubu"},
                new TypeOfMeal { Id = 2, MealType = "Et Grubu"},
                new TypeOfMeal { Id = 3, MealType = "Kurubaklagil Grubu"},
                new TypeOfMeal { Id = 4, MealType = "Ekmek Grubu"},
                new TypeOfMeal { Id = 5, MealType = "Sebze Grubu"},
                new TypeOfMeal { Id = 6, MealType = "Meyve Grubu"},
                new TypeOfMeal { Id = 7, MealType = "Yağ Grubu"},
                new TypeOfMeal { Id = 8, MealType = "Tatlı Grubu"},
                new TypeOfMeal { Id = 9, MealType = "Kuruyemiş Grubu"}
                );
            #endregion
        }
    }
}
