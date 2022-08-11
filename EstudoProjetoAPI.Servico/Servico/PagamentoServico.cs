using EstudoProjetoAPI.Data.Repositorio;
using EstudoProjetoAPI.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoProjetoAPI.Servico.Servico
{
    public class PagamentoServico
    {
        private readonly PagamentoRepositorio pagamentoRepositorio;

        public PagamentoServico()
        {
            pagamentoRepositorio = new PagamentoRepositorio();
        }

        public void InserirPagamento(Pagamento pagamento)
        {
            pagamentoRepositorio.Adicionar(pagamento);
        }

        public List<Pagamento> ListarPagamento()
        {
            return pagamentoRepositorio.ObterTodos();
        }

        public void Deletar(int idPagamento)
        {
            pagamentoRepositorio.Deletar(idPagamento);
        }

        public void Atualizar(Pagamento pagamento)
        {
            pagamentoRepositorio.Atualizar(pagamento);
        }

        public Pagamento Buscar(int idPagamento)
        {
            return pagamentoRepositorio.Buscar(idPagamento, idPagamento);
        }
    }
}
