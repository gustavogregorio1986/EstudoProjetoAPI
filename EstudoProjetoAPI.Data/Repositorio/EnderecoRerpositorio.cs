using EstudoProjetoAPI.Data.Repositorio.Interface;
using EstudoProjetoAPI.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoProjetoAPI.Data.Repositorio
{
    public class EnderecoRerpositorio : GenericRepositorio<Endereco>, IEnderecoRepositorio
    {
        public IEnumerable<Endereco> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
