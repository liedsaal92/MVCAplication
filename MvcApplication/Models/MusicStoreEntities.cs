using System.Data.Entity;

namespace MvcApplication.Models
{
    public class MusicStoreEntities  : DbContext
    {
        public DbSet<album> albums { get; set; }
        public DbSet<Genre> genres { get; set; }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}