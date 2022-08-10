using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EstudoProjetoAPI.Dominio.Entidade
{
    [Table("tb_Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPagamento { get; set; }

        public double Preco { get; set; }

        public int QtdePagamento { get; set; }

        public Ocorrencia Ocorrencia { get; set; }

        [ForeignKey("Ocorrencia")]
        public int Id_Ocorrencia { get; set; }
    }
}
