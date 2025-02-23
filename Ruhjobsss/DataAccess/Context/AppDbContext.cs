using Microsoft.EntityFrameworkCore;
using Ruhjobsss.DataAccess.Entity;
using System.Collections.Generic;

namespace Ruhjobsss.DataAccess.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<About>Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Job> Jobs { get; set; }





        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }













    }
}
