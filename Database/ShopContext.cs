using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Models;

namespace ShopApi.Database
{
   public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }
        public DbSet<ProductInfo> ProductInfo { get; set; }

        public DbSet<ProductCategory> ProductCategory { get; set; }

        public DbSet<ProductSubCategory> ProductSubCategory { get; set; }

    }
}
