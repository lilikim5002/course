using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace skynet.Data
{
    public class StoreContext : DbContext
    {

        public StoreContex(DbContextOptiions<StoreContex> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}