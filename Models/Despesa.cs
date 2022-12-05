using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace papagio.Models
{
    [Table(name: "Despesas")]
    public class Despesa
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Informe o campo Descricao")]
        public string Descricao { get; set; }
        public virtual ICollection<Conta> Conta { get; set; }
        
        public virtual CategoriaDespesa CategoriaDespesa { get; set; }

        [Required(ErrorMessage = "Informe o campo Categoria")]
        public int CategoriaDespesaId { get; set; }
    }
}
