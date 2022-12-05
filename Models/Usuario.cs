using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace papagio.Models
{
    [Table(name: "Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Informe o campo Nome")]
        public string Nome { get; set; }

        [MaxLength(30)]
        [Required(ErrorMessage = "Informe o campo Login")]
        public string Login { get; set; }

        [MaxLength(8)]
        [Required(ErrorMessage = "Informe o campo Senha")]
        public string Senha { get; set; }
    }
}
