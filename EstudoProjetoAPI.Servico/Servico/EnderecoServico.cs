using EstudoProjetoAPI.Data.Repositorio;
using EstudoProjetoAPI.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoProjetoAPI.Servico.Servico
{
    public class EnderecoServico
    {
        private readonly EnderecoRerpositorio enderecoRerpositorio;

        public EnderecoServico()
        {
            enderecoRerpositorio = new EnderecoRerpositorio();
        }

        public void InseriurEndereco(Endereco endereco)
        {
            enderecoRerpositorio.Adicionar(endereco);
        }

        public List<Endereco> ListarEndereco()
        {
            return enderecoRerpositorio.ObterTodos();
        }

        public void Deletar(int idEndereco)
        {
            enderecoRerpositorio.Deletar(idEndereco);
        }

        public void Atualizar(Endereco endereco)
        {
            enderecoRerpositorio.Atualizar(endereco);
        }

        public Endereco BuscarEndereco(int IdEndereco)
        {
            return enderecoRerpositorio.Buscar(IdEndereco, IdEndereco);
        }
    }
}
