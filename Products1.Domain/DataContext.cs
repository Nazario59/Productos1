using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products1.Domain
{
    public  class DataContext: DbContext
    {
        // Se conecta a la base de datos si no existe la crea sila tabla no existe la crea
        public DataContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Category> Categories { get; set; }  

        public DbSet<Product> Products { get; set; }

       // public DbSet<Customer> Customers { get; set; }

       // public DbSet<Ubication> Ubications { get; set; }
    }
}
