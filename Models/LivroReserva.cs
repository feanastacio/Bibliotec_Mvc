
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliotec.Models

{
    public class LivroReserva
    {
        [Key]
        public int LivroReservaId {get; set;} 
        public DateOnly DtReserva {get; set;}
        public DateOnly DtDevolucao {get; set;}
        public int Status {get; set;}

        [ForeignKey("Usuario")]
        public int UsuarioId {get; set;}
        public Usuario? Usuario {get; set;}  

        [ForeignKey("Livro")]
        public int LivroId {get; set;}
        public Livro? Livro {get; set;}
    }
}