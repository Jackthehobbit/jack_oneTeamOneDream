using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jack_oneTeamOneDreamEntities;

namespace jack_oneTeamOneDreamDatabase
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() :base("DatabaseContext")
        {

        }

        public DbSet<Bid> Bids { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

    }
}
