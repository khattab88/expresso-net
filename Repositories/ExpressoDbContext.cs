using Models;
using Repositories.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ExpressoDbContext : DbContext
    {
        public ExpressoDbContext()
            : base("Expresso") 
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Area> Areas { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Branch> Branches { get; set; }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuSection> MenuSections { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuItemOption> MenuItemOptions { get; set; }
        public DbSet<MenuItemOptionItem> MenuItemOptionItems { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderItemOption> OrderItemOptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new CityConfiguration());
            modelBuilder.Configurations.Add(new AreaConfiguration());

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());

            modelBuilder.Configurations.Add(new RestaurantConfiguration());
            modelBuilder.Configurations.Add(new BranchConfiguration());

            modelBuilder.Configurations.Add(new MenuSectionConfiguration());
            modelBuilder.Configurations.Add(new MenuItemConfiguration());
            modelBuilder.Configurations.Add(new MenuItemOptionConfiguration());
            modelBuilder.Configurations.Add(new MenuItemOptionItemConfiguration());

            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());

            modelBuilder.Configurations.Add(new OrderItemConfiguration());
        }
    }
}
