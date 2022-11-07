using Microsoft.EntityFrameworkCore;
using shopLocal.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopLocal.Data.EF
{
    public class shopLocationDdContext : DbContext
    {
        public shopLocationDdContext(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<Product> Products ;
        public DbSet<Category> Categories ;
    }
}
