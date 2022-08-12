using EstudoProjetoAPI.Dominio.Entidade;
using EstudoProjetoAPI.request;
using EstudoProjetoAPI.Servico.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstudoProjetoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastrarLoginController : ControllerBase
    {

        private readonly LoginServico loginServico;

        public CadastrarLoginController()
        {
            loginServico = new LoginServico();
        }

        [HttpPost]
        public JsonResult CadastrarLogin(LoginRequest loginRequest)
        {
            loginRequest = new LoginRequest();
            Login login = new Login();
            loginRequest.IdLogin = login.IdLogin;
            loginRequest.Email = login.Email;
            loginRequest.Senha = login.Senha;
            loginRequest.Perfil = login.Perfil;
            loginServico.AdicionarLogin(login);
            return new JsonResult(loginRequest);
        }
    }
}
