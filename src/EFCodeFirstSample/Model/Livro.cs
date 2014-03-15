using System.Collections.Generic;

namespace EFCodeFirstSample.Model
{
    public class Livro
    {
        public Livro()
        {
            this.Autores = new List<Autor>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Autor> Autores { get; set; }
    }
}
