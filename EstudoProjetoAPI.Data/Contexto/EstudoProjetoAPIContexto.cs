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
        public EstudoProjetoAPIContexto()
        {

        }

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

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Login>().HasKey(x => x.IdLogin);
            builder.Entity<Login>().ToTable("tb_Login");
            builder.Entity<Usuario>().HasKey(x => x.IdUsuario);
            builder.Entity<Usuario>().ToTable("tb_Usuario");
            builder.Entity<Administrador>().HasKey(x => x.IdAdmin);
            builder.Entity<Endereco>().ToTable("tb_Administrador");
            builder.Entity<Endereco>().HasKey(x => x.IdEndereco);
            builder.Entity<Endereco>().ToTable("tb_Endereco");
            builder.Entity<Ocorrencia>().HasKey(x => x.IdOcorrencia);
            builder.Entity<Ocorrencia>().ToTable("tb_Ocorrencia");
            builder.Entity<Processo>().HasKey(x => x.IdProcesso);
            builder.Entity<Processo>().ToTable("tb_Processo");
            builder.Entity<Pagamento>().HasKey(x => x.IdPagamento);
            builder.Entity<Pagamento>().ToTable("tb_Pagamento");
            base.OnModelCreating(builder);
        }
    }
}
