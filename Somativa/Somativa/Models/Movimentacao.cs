using System.ComponentModel;
using System.Security.Policy;
using System.ComponentModel.DataAnnotations;

namespace Somativa.Models
{
	public class Movimentacao
	{		
		public Guid Id { get; set; }
		[DisplayName("Nota Fiscal")]
        [Required(ErrorMessage = "O Campo Nota Fiscal Está Inválido!!!")]

        public int Nota { get; set; }
		[DisplayName("Data e hora")]
        [Required(ErrorMessage = "O Campo Data e Hora Está Inválido!!!")]

        public DateTime DataHora { get; set; }
		[DisplayName("Tipo de movimentação")]
        [Required(ErrorMessage = "O Campo Tipo de movimentação Está Inválido!!!")]

        public string TipoMovimentacao { get; set; }
        [Required(ErrorMessage = "O Campo Produto Está Inválido!!!")]

        public string Produto { get; set; }
        [Required(ErrorMessage = "O Campo Quantidade Está Inválido!!!")]

        public int Quantidade { get; set; }
		[DisplayName("Preço unitário")]
        [Required(ErrorMessage = "O Campo Preço unitário Está Inválido!!!")]

        public decimal Unitario { get; set; }
	}
}
