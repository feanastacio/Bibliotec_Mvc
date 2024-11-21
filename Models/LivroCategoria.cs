
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliotec.Models

{
    public class LivroCategoria
    {
        [Key]
        public int LivroCategoriaId { get; set; }

        [ForeignKey("Livro")]
        public int LivroId { get; set; }
        public Livro? Livro { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}