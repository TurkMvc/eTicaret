using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace eTicaret.Models
{
    public class ETICARETDB : DbContext
    {
        public ETICARETDB() : base("ETİCARETDB")
        {

        }
        public DbSet<User> User{ get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Shopping> Shopping { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Adress>().ToTable("Adress");
            modelBuilder.Entity<Departments>().ToTable("Departments");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Shopping>().ToTable("Shopping");
        }
    }
    

}