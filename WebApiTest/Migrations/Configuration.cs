namespace WebApiTest.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiTest.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiTest.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApiTest.Models.ApplicationDbContext context)
        {

            if (!context.Roles.Any(x => x.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole() { Name = "Admin" };
                manager.Create(role);
            }

            if (!context.Roles.Any(x => x.Name == "Author"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole() { Name = "Author" };
                manager.Create(role);
            }

            if (!context.Roles.Any(x => x.Name == "Reader"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole() { Name = "Reader" };
                manager.Create(role);
            }


            var passwordHass = new PasswordHasher();//ergaliothikh gia na kruptografw kwdikous
            if (!context.Users.Any(x => x.Email == "Thanos@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store); // gnostopoiw sto Asp.Net
                var user = new ApplicationUser()   //ftiaxnw ton user
                {
                    UserName = "Thanos",
                    Email = "Thanos@gmail.com",
                    PasswordHash = passwordHass.HashPassword("Thanos123"),
                    FirstName = "Athanasios",
                    LastName = "Mastrogiannis"
                    
                };
                manager.Create(user);
                manager.AddToRole(user.Id, "Admin");
            }

            ////////////////////////////////////////////////////////////////////////////////
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

        }
    }
}
