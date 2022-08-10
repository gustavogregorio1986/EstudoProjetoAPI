using EstudoProjetoAPI.Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoProjetoAPI.Data.Contexto
{
    public class EstudoProjetoAPIContexto : DbContext
    {
        public EstudoProjetoAPIContexto(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Administrador> Administradores { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Processo> Processos { get; set; }

        public DbSet<Ocorrencia> Ocorrencias { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}
