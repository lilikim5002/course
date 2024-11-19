using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using skynet.Entities;


namespace skynet.Data
{
    public class StoreContext : DbContext
    {

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {


        }

        public DbSet<Product> Products { get; set; }
    }
}