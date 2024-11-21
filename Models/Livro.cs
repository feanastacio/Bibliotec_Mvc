
using System.ComponentModel.DataAnnotations;

namespace Bibliotec.Models

{
    public class Livro
    {
        [Key]
        public int LivroId { get; set; }
        public string? Nome { get; set; }
        public string? Escritor { get; set; }
        public string? Editoria { get; set; }
        public string? Descricao { get; set; }
        public string? Idioma { get; set; }
        public string? Imagem { get; set; }
        public bool Reservado { get; set; }
        public bool Ativado { get; set; }
    }
}