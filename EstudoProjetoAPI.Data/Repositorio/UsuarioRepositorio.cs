using EstudoProjetoAPI.Data.Repositorio.Interface;
using EstudoProjetoAPI.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoProjetoAPI.Data.Repositorio
{
    public class UsuarioRepositorio : GenericRepositorio<Usuario>, IUsuarioRepositorio
    {
        public IEnumerable<Usuario> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
