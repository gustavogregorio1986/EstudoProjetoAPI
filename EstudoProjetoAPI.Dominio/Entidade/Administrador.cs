using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EstudoProjetoAPI.Dominio.Entidade
{
    [Table("tb_Administrador")]
    public class Administrador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAdmin { get; set; }

        public string NomeAdm { get; set; }

        public string Sexo { get; set; }

        public Login Login { get; set; }

        [ForeignKey("Login")]
        public int Id_Login { get; set; }
    }
}
