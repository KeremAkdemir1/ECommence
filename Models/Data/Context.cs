using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commence.Models.Data
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-8PLNS1VS;database=ECommence;integrated security=true");
        }


        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<BeverageCategory> BeverageCategories { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<VegetableCategory> VegetableCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
