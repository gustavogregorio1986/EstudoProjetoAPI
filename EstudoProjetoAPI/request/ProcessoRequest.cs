namespace EstudoProjetoAPI.request
{
    public class ProcessoRequest
    {
        public int IdProcesso { get; set; }

        public string NomeProcesso { get; set; }

        public string Cnpj { get; set; }

        public int NumeroProcesso { get; set; }

        public UsuarioRequest UsuarioRequest { get; set; }
    }
}
