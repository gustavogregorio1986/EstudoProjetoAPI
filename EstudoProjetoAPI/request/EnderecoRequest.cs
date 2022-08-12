namespace EstudoProjetoAPI.request
{
    public class EnderecoRequest
    {
        public int IdEndereco { get; set; }

        public string Logradouro { get; set; }

        public string Cmmplemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public UsuarioRequest UsuarioRequest { get; set; }
    }
}
