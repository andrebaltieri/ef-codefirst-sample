using EFCodeFirstSample.Model;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstSample.Mappings
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livro");

            HasKey(x => x.Id);

            Property(x => x.Titulo)
                .HasMaxLength(80)
                .IsRequired();

            HasMany(x => x.Autores);

            HasRequired(x => x.Categoria);
        }
    }
}
