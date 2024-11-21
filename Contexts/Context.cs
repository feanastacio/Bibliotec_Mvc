
// Classe que terá as informações do banco de dados

using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace Bibliotec.Contexts

{
    public class Context : DbContext
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { /*OnConfiguring possoui a configuração da conexão com o banco de dados*/
            // Colocar as informações do banco
            if (!optionsBuilder.IsConfigured) /*Para saber se as configurações existem*/
            // A string de conexão do banco de dados:
            // Data Source => Nome do servidor do banco de dados
            // Initial Catalog => Nome do banco de dados
            //  User Id e Passoword => Informações de acesso ao servidor do banco de dados 
            {
                optionsBuilder.UseSqlServer(@"Data Source= NOTE23-S28; 
                Initial Catalog = Bibliotec; 
                User Id=sa; Password=abc123; 
                Integrated Security=true; 
                TrustServerCertificate = true");
            }
        }
        // As referências das nossas tabelas no banco de dados:
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<LivroCategoria> LivroCategoria { get; set; }
        public DbSet<LivroReserva> LivroReserva { get; set; }
    }
}
