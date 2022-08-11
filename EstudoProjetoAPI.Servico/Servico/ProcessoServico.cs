using EstudoProjetoAPI.Data.Repositorio;
using EstudoProjetoAPI.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoProjetoAPI.Servico.Servico
{
    public class ProcessoServico
    {
        private readonly ProcessoRepositorio processoRepositorio;

        public ProcessoServico()
        {
            processoRepositorio = new ProcessoRepositorio();
        }

        public void InserirProcesso(Processo processo)
        {
            processoRepositorio.Adicionar(processo);
        }

        public List<Processo> ListarProcesso()
        {
            return processoRepositorio.ObterTodos();
        }

        public void Atualizar(Processo processo)
        {
            processoRepositorio.Atualizar(processo);
        }

        public void Deletar(int idProcesso)
        {
            processoRepositorio.Deletar(idProcesso);
        }

        public Processo Buscar(int idProcesso)
        {
            return processoRepositorio.Buscar(idProcesso, idProcesso);
        }
    }
}
