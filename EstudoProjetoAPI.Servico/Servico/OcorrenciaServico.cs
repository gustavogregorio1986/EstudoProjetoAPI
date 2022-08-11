using EstudoProjetoAPI.Data.Repositorio;
using EstudoProjetoAPI.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoProjetoAPI.Servico.Servico
{
    public class OcorrenciaServico
    {
        private readonly OcorrenciaRepositorio ocorrenciaRepositorio;

        public OcorrenciaServico()
        {
            ocorrenciaRepositorio = new OcorrenciaRepositorio();
        }

        public void InserirOcorrencia(Ocorrencia ocorrencia)
        {
            ocorrenciaRepositorio.Adicionar(ocorrencia);
        }

        public List<Ocorrencia> ListarOcorencia()
        {
            return ocorrenciaRepositorio.ObterTodos();
        }

        public void Deletar(int idOcorencia)
        {
            ocorrenciaRepositorio.Deletar(idOcorencia);
        }

        public void Atualizar(Ocorrencia ocorrencia)
        {
            ocorrenciaRepositorio.Atualizar(ocorrencia);
        }

        public Ocorrencia Buscar(int idOcorrencia)
        {
            return ocorrenciaRepositorio.Buscar(idOcorrencia, idOcorrencia);
        }
    }
}
