using System;
using entity_framework_basics.Data;
using entity_framework_basics.Models;

namespace entity_framework_basics {
    class Program {
        static void Main(string[] args) {
            using entity_framework_basics_Context context = new entity_framework_basics_Context();
            Product squeakyBone = new Product() {
                Name = "Squeaky Dog Bone",
                Price = 4.99M
            };
            context.Products.Add(squeakyBone);

            Product tennisBall = new Product() {
                Name = "Tennis Ball 3-Pack",
                Price = 9.99M
            };
            context.Add(tennisBall); //Entity Framework knows it's a product, no need to specify.
            context.SaveChanges();
        }
    }
}
