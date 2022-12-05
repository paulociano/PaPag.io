using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace papagio.Models
{
    [Table(name: "CategoriaDespesas")]
    public class CategoriaDespesa
    {

        public int Id { get; set; }

        [MaxLength(30)]
        [Required(ErrorMessage = "Informe o campo Descrição")]
        public string Descricao { get; set; }

        public virtual ICollection<Despesa> Despesa { get; set; }
    }
}
