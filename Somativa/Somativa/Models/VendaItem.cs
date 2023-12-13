using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Somativa.Models
{
    public class VendaItem
    {
        public Guid VendaItemId { get; set; }
        [DisplayName("Nota Fiscal")]
        [Required(ErrorMessage = "O Campo Nota Fiscal Está Inválido!!!")]

        public Guid VendaId { get; set; }
        public Venda? Venda { get; set; }
        [DisplayName("Produto")]
        [Required(ErrorMessage = "O Campo Produto Está Inválido!!!")]

        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        [Required(ErrorMessage = "O Campo Quantidade Está Inválido!!!")]

        public int Quantidade { get; set; }
        [Required(ErrorMessage = "O Campo Unitário Está Inválido!!!")]

        public decimal Unitario { get; set; }
    }
}
