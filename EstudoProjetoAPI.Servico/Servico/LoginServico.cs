using EstudoProjetoAPI.Data.Repositorio;
using EstudoProjetoAPI.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoProjetoAPI.Servico.Servico
{
    public class LoginServico
    {
        private readonly LoginRepositorio loginRepositorio;

        public LoginServico()
        {
            loginRepositorio = new LoginRepositorio();
        }

        public void AdicionarLogin(Login login)
        {
            loginRepositorio.Adicionar(login);
        }

        public List<Login> ListarLogin()
        {
            return loginRepositorio.ObterTodos();
        }

        public void Deletar(int idLogin)
        {
            loginRepositorio.Deletar(idLogin);
        }

        public void Atualizar(Login login)
        {
            loginRepositorio.Atualizar(login);
        }

        public Login Buscar(int idLogin)
        {
            return loginRepositorio.Buscar(idLogin, idLogin);
        }
    }
}
