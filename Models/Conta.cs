using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace papagio.Models
{
    [Table(name: "Contas")]
    public class Conta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o campo Valor")]
        public float Valor { get; set; }
 
        [Required(ErrorMessage = "Informe o campo Data")]
        public DateTime Data { get; set; }
        
        public virtual Despesa Despesa { get; set; }

        [Required(ErrorMessage = "Informe o campo Despesa")]
        public int DespesaId { get; set; }
    }
}
