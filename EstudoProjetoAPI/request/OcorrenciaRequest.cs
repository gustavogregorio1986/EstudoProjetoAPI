using System;

namespace EstudoProjetoAPI.request
{
    public class OcorrenciaRequest
    {
        public int IdOcorrencia { get; set; }

        public int NumeroOcorrencia { get; set; }

        public DateTime DataOcorrencia { get; set; }

        public ProcessoRequest ProcessoRequest { get; set; }
    }
}
