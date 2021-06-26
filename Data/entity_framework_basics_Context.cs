using entity_framework_basics.Models;
using Microsoft.EntityFrameworkCore;

namespace entity_framework_basics.Data {
    public class entity_framework_basics_Context : DbContext {
        public DbSet<Customer> MyProperty { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("db_connection_string_here");
        }
    }

}