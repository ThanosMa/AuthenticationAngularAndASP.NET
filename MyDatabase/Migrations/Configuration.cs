namespace MyDatabase.Migrations
{
    using MyDatabase.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyDatabase.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyDatabase.ApplicationDbContext context)
        {
            Product p1 = new Product() { Name= "Malakas" };
            context.Products.Add(p1);
            context.SaveChanges();

        }
    }
}
