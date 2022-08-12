namespace EstudoProjetoAPI.request
{
    public class PagamentoRequest
    {
        public int IdPagamento { get; set; }

        public double Preco { get; set; }

        public int QtdePagamento { get; set; }

        public OcorrenciaRequest OcorrenciaRequest { get; set; }
    }
}
