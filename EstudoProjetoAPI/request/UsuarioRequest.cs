namespace EstudoProjetoAPI.request
{
    public class UsuarioRequest
    {
        public int IdUsuario { get; set; }

        public string NomeUsuario { get; set; }

        public string Sexo { get; set; }

        public string Telefone { get; set; }

        public LoginRequest LoginRequest { get; set; }
    }
}
