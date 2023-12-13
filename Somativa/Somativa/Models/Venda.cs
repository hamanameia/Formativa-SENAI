using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Somativa.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        [DisplayName("Nota Fiscal")]
        [Required(ErrorMessage = "O Campo Nota Fiscal Está Inválido!!!")]

        public int Nota { get; set; }
        [DisplayName("Cliente")]
        [Required(ErrorMessage = "O Campo Cliente Está Inválido!!!")]

        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        [DisplayName("Data e hora")]
        [Required(ErrorMessage = "O Campo Data e Hora Está Inválido!!!")]

        public DateTime DataHora { get; set; }
        public IEnumerable<VendaItem>? VendaItems { get; set; }
    }
}
