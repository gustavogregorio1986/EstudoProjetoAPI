﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EstudoProjetoAPI.Dominio.Entidade
{
    [Table("tb_Endereco")]
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEndereco { get; set; }

        public string Logradouro { get; set; }

        public string Cmmplemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public Usuario Usuario { get; set; }

        [ForeignKey("Usuario")]
        public int Id_Usuario { get; set; }
    }
}
