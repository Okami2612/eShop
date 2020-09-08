using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.EF
{
    class eShopDbContext: DbContext
    {
        public eShopDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
