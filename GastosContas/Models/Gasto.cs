using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GastosContas.Models
{
    public class Gasto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Este campo é de preenchimento obrigatório")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("Valor do Pagamento")]
        public decimal Valor { get; set; }
        
        [DisplayName("Data do pagamento")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataDoPagamento { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
