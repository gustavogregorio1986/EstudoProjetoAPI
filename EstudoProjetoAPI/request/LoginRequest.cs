namespace EstudoProjetoAPI.request
{
    public class LoginRequest
    {
        public int IdLogin { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Perfil { get; set; }
    }
}
