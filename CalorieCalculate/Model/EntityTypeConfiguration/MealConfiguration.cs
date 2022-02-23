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
    public class MealConfiguration : IEntityTypeConfiguration<Meal> // IEntityTypeConfiguration<SınıfAdı> Hangi sınıfın adı yazıldıysa o sınıftan oluşturulan tablo içerisinde ki özellikleri tanımlar
    {
        public void Configure(EntityTypeBuilder<Meal> builder) // kullanılan hazırlanmış method sınıf içerisinde hangi özellikleri kullanıcağımızı belirmemize yardımcı olur, builder sınıf içerisinde yaptığımız değişikleri tanımlar
        {
            #region Kolon Bilgileri
            builder.ToTable("YemekBilgileri"); // ToTable : Tabloya isim verir

            builder.HasKey(x => x.Id); // HasKey Primery key belirtir
            builder.Property(x => x.Id).UseIdentityColumn(); // UseIdentityColumn kolona ıdentity özelliği tanımlar

            builder.Property(x => x.MealName).IsRequired(); // IsRequired kolonun boş geçilemez olduğunu belirtir
            builder.Property(x => x.MealName).HasMaxLength(50); // HasMaxLenght string ifadenin en fazla kaç karakter alacağını belirtir

            builder.Property(x => x.MealDescription).IsRequired();
            builder.Property(x => x.MealDescription).HasMaxLength(300);

            builder.HasOne(x => x.TypeOfMeal).WithMany(x => x.Meals).HasForeignKey(x => x.TypeMealId);
            // HasOne sınıf içerisinde ilişkili olan sınıfı belirtir
            // WithMany Çoklu ilişki belirtir
            // HasForeignKey Sınıf içerisinde ki foreignkey i belirtir
            #endregion

            #region Veri Girisi
            builder.HasData(
               new Meal { Id = 1, MealName = "Süt", MealDescription = "1 porsiyon, 1 su bardağı, 200 ml", Calorie = 114000, TypeMealId = 1 },
               new Meal { Id = 2, MealName = "Yoğurt", MealDescription = "1 porsiyon, 1 kase, 200 gram", Calorie = 114000, TypeMealId = 1 },
               new Meal { Id = 3, MealName = "Süzme Yoğurt", MealDescription = "1 porsiyon, 2 yemek kaşığı, 50 gram", Calorie = 114000, TypeMealId = 1 },
               new Meal { Id = 4, MealName = "Ayran", MealDescription = "1 porsiyon, 1 su bardağı, 200 ml", Calorie = 57000, TypeMealId = 1 },
               new Meal { Id = 5, MealName = "Kefir", MealDescription = "1 porsiyon, 1 su bardağı, 200 ml", Calorie = 114000, TypeMealId = 1 },
               new Meal { Id = 6, MealName = "Probiyotik Yoğurt", MealDescription = "1 porsiyon, 1 kutu, 125 gram", Calorie = 57000, TypeMealId = 1 },
               new Meal { Id = 7, MealName = "Beyaz Peynir", MealDescription = "1 porsiyon, 1 kibrit kutusu, 30 gram", Calorie = 69000, TypeMealId = 1 },
               new Meal { Id = 8, MealName = "Labne Peyniri", MealDescription = "1 porsiyon, 1 kibrit kutusu, 30 gram", Calorie = 69000, TypeMealId = 1 },
               new Meal { Id = 9, MealName = "Kaşar Peyniri", MealDescription = "1 porsiyon, 1 kibrit kutusu, 30 gram", Calorie = 120000, TypeMealId = 1 },
               new Meal { Id = 10, MealName = "Dil Peyniri", MealDescription = "1 porsiyon, 1 kibrit kutusu, 30 gram", Calorie = 69000, TypeMealId = 1 },
               new Meal { Id = 11, MealName = "Yağsız Lor Peyniri", MealDescription = "1 porsiyon, 3 yemek kaşığı, 70 gram", Calorie = 69000, TypeMealId = 1 },
               new Meal { Id = 12, MealName = "Tulum Peyniri", MealDescription = "1 porsiyon, 1 yemek kaşığı, 70 gram", Calorie = 69000, TypeMealId = 1 },
               new Meal { Id = 13, MealName = "Üçgen Karper Peynir", MealDescription = "1 porsiyon, 2 adet, 50 gram", Calorie = 69000, TypeMealId = 1 },
               new Meal { Id = 14, MealName = "Otlu Peynir", MealDescription = "1 porsiyon, 1 kibrit kutusu, 30 gram", Calorie = 97000, TypeMealId = 1 },
               new Meal { Id = 15, MealName = "Hellim Peyniri", MealDescription = "1 porsiyon, 1 kibrit kutusu, 30 gram", Calorie = 69000, TypeMealId = 1 },
               new Meal { Id = 16, MealName = "Mozarella", MealDescription = "1 porsiyon, 1 kibrit kutusu, 30 gram", Calorie = 69000, TypeMealId = 1 },
               new Meal { Id = 17, MealName = "Kıyma", MealDescription = "1 porsiyon, 1 köfte kadar, 30 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 18, MealName = "Köfte", MealDescription = "1 porsiyon, 1 avuç büyüklükte, 30 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 19, MealName = "Kuşbaşı", MealDescription = "1 porsiyon, 4 adet, 30 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 20, MealName = "Bonfile", MealDescription = "1 porsiyon, 1 küçük boy, 30 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 21, MealName = "Tavuk-Hindi", MealDescription = "1 porsiyon, 1 köfte kadar, 30 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 22, MealName = "Yumurta", MealDescription = "1 porsiyon, 1 adet, 50 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 23, MealName = "Balık", MealDescription = "1 porsiyon, 1 köfte kadar, 30 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 24, MealName = "Ton Balığı", MealDescription = "1 porsiyon, 1 yemek kaşığı, 30 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 25, MealName = "Sucuk", MealDescription = "1 porsiyon, 5 ince halka, 30 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 26, MealName = "Pastırma", MealDescription = "1 porsiyon, 2 ince dilim, 30 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 27, MealName = "Hindi/Piliç Jambon", MealDescription = "1 porsiyon, 3 dilim, 40 gram", Calorie = 69000, TypeMealId = 2 },
               new Meal { Id = 28, MealName = "Nohut", MealDescription = "1 porsiyon, 4 yemek kaşığı, 25 gram", Calorie = 80000, TypeMealId = 3 },
               new Meal { Id = 29, MealName = "Kurufasulye", MealDescription = "1 porsiyon, 4 yemek kaşığı, 25 gram", Calorie = 80000, TypeMealId = 3 },
               new Meal { Id = 30, MealName = "Mercimek", MealDescription = "1 porsiyon, 4 yemek kaşığı, 25 gram", Calorie = 80000, TypeMealId = 3 },
               new Meal { Id = 31, MealName = "Barbunya", MealDescription = "1 porsiyon, 4 yemek kaşığı, 25 gram", Calorie = 80000, TypeMealId = 3 },
               new Meal { Id = 32, MealName = "Ekmek(kepek,buğday,çavdar,mısır)", MealDescription = "1 porsiyon, 1 ince dilim, 25 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 33, MealName = "Çorba", MealDescription = "1 porsiyon, 1 küçük kase, 160 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 34, MealName = "Pirinç/Bulgur pilavı", MealDescription = "1 porsiyon, 3 yemek kaşığı, 50 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 35, MealName = "Makarna/Erişte", MealDescription = "1 porsiyon, 3 yemek kaşığı, 50 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 36, MealName = "Haşlanmış Patates", MealDescription = "1 porsiyon, 1 küçük boy, 90 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 37, MealName = "Haşlanmış Tane Mısır", MealDescription = "1 porsiyon, 2 yemek kaşığı, 40 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 38, MealName = "Kahvaltılık Gevrek", MealDescription = "1 porsiyon, 1 Kase , 30 gram", Calorie = 103000, TypeMealId = 4 },
               new Meal { Id = 39, MealName = "Patlamış Mısır(yağsız)", MealDescription = "1 porsiyon, 1 Su Bardağı , 20 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 40, MealName = "Galeta sade(Büyük)", MealDescription = "1 porsiyon, 1.5 Adet , 20 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 41, MealName = "Galeta sade(Küçük)", MealDescription = "1 porsiyon, 7 Adet , 20 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 42, MealName = "Simit(susamlı)", MealDescription = "1 porsiyon, 1/3 Adet , 25 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 43, MealName = "Kestane", MealDescription = "1 porsiyon, 2-3 orta boy , 45 gram", Calorie = 68000, TypeMealId = 4 },
               new Meal { Id = 44, MealName = "Bamya(Pişmiş)", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 45, MealName = "Brokoli(Pişmiş)", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 46, MealName = "Ebegümeci(Pişmiş)", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 47, MealName = "Ispanak(Pişmiş)", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 48, MealName = "Karnabahar(Pişmiş)", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 49, MealName = "Lahana(Pişmiş)", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 50, MealName = "Mantar", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 51, MealName = "Patlıcan(Pişmiş)", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 52, MealName = "Pazı(Pişmiş)", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 53, MealName = "Semizotu(Pişmiş)", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 54, MealName = "Taze Fasulye(Pişmiş)", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 55, MealName = "Bakla", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 56, MealName = "Bezelye", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 57, MealName = "Enginar", MealDescription = "1 porsiyon, 1 orta boy , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 58, MealName = "Havuç", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 59, MealName = "Kereviz", MealDescription = "1 porsiyon, 4 yemek kaşığı , 200 gram", Calorie = 25000, TypeMealId = 5 },
               new Meal { Id = 60, MealName = "Elma", MealDescription = "1 porsiyon, 1 küçük boy , 120 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 61, MealName = "Armut", MealDescription = "1 porsiyon, 1 küçük boy , 120 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 62, MealName = "Portakal", MealDescription = "1 porsiyon, 1 orta boy , 220 gram", Calorie = 103000, TypeMealId = 6 },
               new Meal { Id = 63, MealName = "Mandalina", MealDescription = "1 porsiyon, 1 büyük boy , 150 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 64, MealName = "Greyfurt", MealDescription = "1 porsiyon, 1 küçük boy , 150 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 65, MealName = "Muz", MealDescription = "1 porsiyon, 1 orta boy , 60 gram", Calorie = 150000, TypeMealId = 6 },
               new Meal { Id = 66, MealName = "Kivi", MealDescription = "1 porsiyon, 1 orta boy , 120 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 67, MealName = "Ananas", MealDescription = "1 porsiyon, 3 halka , 120 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 68, MealName = "Ayva", MealDescription = "1 porsiyon, 1 orta boy , 250 gram", Calorie = 98000, TypeMealId = 6 },
               new Meal { Id = 69, MealName = "Nar", MealDescription = "1 porsiyon, 1 küçük boy , 200 gram", Calorie = 120000, TypeMealId = 6 },
               new Meal { Id = 70, MealName = "üzüm", MealDescription = "1 porsiyon, 15 iri adet , 100 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 71, MealName = "Yeni Dünya", MealDescription = "1 porsiyon, 6 adet , 100 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 72, MealName = "Kayısı", MealDescription = "1 porsiyon, 4 adet , 120 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 73, MealName = "Erik", MealDescription = "1 porsiyon, 5 adet , 85 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 74, MealName = "İncir", MealDescription = "1 porsiyon, 1 adet , 100 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 75, MealName = "Kiraz", MealDescription = "1 porsiyon, 8 iri adet , 90 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 76, MealName = "Kuru Kayısı", MealDescription = "1 porsiyon, 4 adet , 20 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 77, MealName = "Kuru İncir", MealDescription = "1 porsiyon, 1 küçük boy , 20 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 78, MealName = "Kuru Erik", MealDescription = "1 porsiyon, 5 Adet, 20 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 79, MealName = "Kuru Üzüm", MealDescription = "1 porsiyon, 1 yemek kaşığı, 20 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 80, MealName = "Hurma", MealDescription = "1 porsiyon, 3 adet, 20 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 81, MealName = "Çilek", MealDescription = "1 porsiyon, 15 adet küçük , 150 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 82, MealName = "Şeftali", MealDescription = "1 porsiyon, 1 orta boy, 120 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 83, MealName = "Kavun", MealDescription = "1 porsiyon, 1 ince dilim, 200 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 84, MealName = "Karpuz", MealDescription = "1 porsiyon, 1 ince dilim, 200 gram", Calorie = 60000, TypeMealId = 6 },
               new Meal { Id = 85, MealName = "Vişne Suyu", MealDescription = "1 porsiyon, 1 bardak, 200 ml", Calorie = 99000, TypeMealId = 6 },
               new Meal { Id = 86, MealName = "Elma Suyu", MealDescription = "1 porsiyon, 1 bardak, 200 ml", Calorie = 98000, TypeMealId = 6 },
               new Meal { Id = 87, MealName = "Portakal Suyu", MealDescription = "1 porsiyon, 1 bardak, 200 ml", Calorie = 120000, TypeMealId = 6 },
               new Meal { Id = 88, MealName = "Nar Suyu", MealDescription = "1 porsiyon, 1 bardak, 200 ml", Calorie = 106000, TypeMealId = 6 },
               new Meal { Id = 89, MealName = "Zeytin", MealDescription = "1 porsiyon, 5 adet, 15 gram", Calorie = 45000, TypeMealId = 7 },
               new Meal { Id = 90, MealName = "Zeytinyağı", MealDescription = "1 porsiyon, 1 tatlı kaşığı , 5 gram", Calorie = 45000, TypeMealId = 7 },
               new Meal { Id = 91, MealName = "Bitkisel sıvıyağ", MealDescription = "1 porsiyon, 1 tatlı kaşığı, 5 gram", Calorie = 45000, TypeMealId = 7 },
               new Meal { Id = 92, MealName = "Tereyağ", MealDescription = "1 porsiyon, 1 tatlı kaşığı, 5 gram", Calorie = 45000, TypeMealId = 7 },
               new Meal { Id = 93, MealName = "Bal", MealDescription = "1 porsiyon, 1 yemek kaşığı, 30 gram", Calorie = 68000, TypeMealId = 8 },
               new Meal { Id = 94, MealName = "Reçel", MealDescription = "1 porsiyon, 3 tatlı kaşığı, 30 gram", Calorie = 68000, TypeMealId = 8 },
               new Meal { Id = 95, MealName = "Marmelat", MealDescription = "1 porsiyon, 3 tatlı kaşığı, 30 gram", Calorie = 68000, TypeMealId = 8 },
               new Meal { Id = 96, MealName = "Pekmez", MealDescription = "1 porsiyon, 3 tatlı kaşığı, 30 gram", Calorie = 68000, TypeMealId = 8 },
               new Meal { Id = 97, MealName = "Leblebi", MealDescription = "1 porsiyon, 1 çay bardağı, 20 gram", Calorie = 68000, TypeMealId = 9 },
               new Meal { Id = 98, MealName = "Ceviz içi", MealDescription = "1 porsiyon, 2 adet, 8 gram", Calorie = 45000, TypeMealId = 9 },
               new Meal { Id = 99, MealName = "Ay Çekirdeği", MealDescription = "1 porsiyon, 1 avuç, 10 gram", Calorie = 68000, TypeMealId = 9 },
               new Meal { Id = 100, MealName = "Kabak Çekirdeği", MealDescription = "1 porsiyon, 1 avuç, 10 gram", Calorie = 68000, TypeMealId = 9 },
               new Meal { Id = 101, MealName = "Badem içi", MealDescription = "1 porsiyon, 5 adet, 10 gram", Calorie = 68000, TypeMealId = 9 },
               new Meal { Id = 102, MealName = "Fındık içi", MealDescription = "1 porsiyon, 7 adet, 10 gram", Calorie = 68000, TypeMealId = 9 },
               new Meal { Id = 103, MealName = "Fıstık içi", MealDescription = "1 porsiyon, 7 adet, 10 gram", Calorie = 68000, TypeMealId = 9 }
               ); 
            #endregion
        }
    }
}
