using CalorieCalculate.Model.Entities;
using CalorieCalculate.Model.EntityTypeCondiguration;
using CalorieCalculate.Model.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Model.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<TypeOfMeal> TypeOfMeals { get; set; }
        public DbSet<Repast> Repasts { get; set; }
        public DbSet<RepastMeal> RepastMeals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = 192.168.1.146; database = CalorieDb; user = SA; password = 18.Defne.01");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserInformationConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TypeOfMealConfiguration());
            modelBuilder.ApplyConfiguration(new RepastMealConfiguration());
            modelBuilder.ApplyConfiguration(new RepastConfiguration());
            modelBuilder.ApplyConfiguration(new MealConfiguration());
        }
    }
}
