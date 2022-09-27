using MyDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext():base("DefaultConnection2")
        {
            
        }
        public DbSet<Product> Products { get; set; }

    }
}
