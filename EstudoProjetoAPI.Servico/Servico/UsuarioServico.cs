using EstudoProjetoAPI.Data.Repositorio;
using EstudoProjetoAPI.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoProjetoAPI.Servico.Servico
{
    public class UsuarioServico
    {
        private readonly UsuarioRepositorio usuarioRepositorio;

        public UsuarioServico()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public void InseirUsuario(Usuario usuario)
        {
            usuarioRepositorio.Adicionar(usuario);
        }

        public List<Usuario> ListarUsuario()
        {
            return usuarioRepositorio.ObterTodos();
        }

        public void Atualizar(Usuario usuario)
        {
            usuarioRepositorio.Atualizar(usuario);
        }

        public void Deletar(int idUsuario)
        {
            usuarioRepositorio.Deletar(idUsuario);
        }

        public Usuario Buscar(int idUsuario)
        {
            return usuarioRepositorio.Buscar(idUsuario, idUsuario);
        }
    }
}
