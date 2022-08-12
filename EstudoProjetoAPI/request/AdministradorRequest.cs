namespace EstudoProjetoAPI.request
{
    public class AdministradorRequest
    {
        public int IdAdmin { get; set; }

        public string NomeAdm { get; set; }

        public string Sexo { get; set; }

        public LoginRequest LoginRequest { get; set; }
    }
}
