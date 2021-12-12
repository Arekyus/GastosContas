using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


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
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public DateTime DataDoPagamento { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
