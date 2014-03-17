using EFCodeFirstSample.Model;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstSample.Mappings
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("Autor");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(80).IsRequired();

            HasMany(x => x.Livros)
                .WithMany(x => x.Autores)
                .Map(x => x.ToTable("LivroAutor"));
        }
    }
}
