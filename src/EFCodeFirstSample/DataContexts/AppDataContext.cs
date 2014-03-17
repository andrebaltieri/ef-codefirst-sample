using EFCodeFirstSample.Mappings;
using EFCodeFirstSample.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSample.DataContexts
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            :base("MinhaConnectionString")
        {
            Database.SetInitializer<AppDataContext>(new AppDataContextInitializer());
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new LivroMap());
            modelBuilder.Configurations.Add(new CategoriaMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class AppDataContextInitializer : DropCreateDatabaseAlways<AppDataContext>
    {
    }
}
