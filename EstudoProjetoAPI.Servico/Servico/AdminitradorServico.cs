using EstudoProjetoAPI.Data.Repositorio;
using EstudoProjetoAPI.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoProjetoAPI.Servico.Servico
{
    public class AdminitradorServico
    {
        private readonly AdministradorRepositorio administradorRepositorio;

        public AdminitradorServico()
        {
            administradorRepositorio = new AdministradorRepositorio();
        }

        public void InserirAdministrador(Administrador administrador)
        {
            administradorRepositorio.Adicionar(administrador);
        }

        public List<Administrador> ListarAdministrador()
        {
            return administradorRepositorio.ObterTodos();
        }

        public void Deletar(int idAdministrador)
        {
            administradorRepositorio.Deletar(idAdministrador);
        }

        public void Atualizar(Administrador administrador)
        {
            administradorRepositorio.Atualizar(administrador);
        }

        public Administrador BuscarAdmiistrador(int idAdministrador)
        {
            return administradorRepositorio.Buscar(idAdministrador, idAdministrador);
        }
    }
}
