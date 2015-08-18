using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication.Models
{
    public class MusicStoreEntities  : DbContext
    {
        public DbSet<album> albums { get; set; }
        public DbSet<Genre> genres { get; set; }

    }
}