using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace VitalWeb.Models
{
    public class DatabaseCxt : DbContext
    {
        public DatabaseCxt(DbContextOptions<DatabaseCxt> options) : base(options) { }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<Resto> Restos { get; set; }
        public DbSet<Sondage> Sondages { get; set; }
    }
}