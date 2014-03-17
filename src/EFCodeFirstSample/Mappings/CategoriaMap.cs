using EFCodeFirstSample.Model;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstSample.Mappings
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            ToTable("Categoria");

            Property(x => x.Titulo)
                .HasMaxLength(30)
                .IsRequired();

            HasMany(x => x.Livros);
        }
    }
}
